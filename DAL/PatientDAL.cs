using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Data.SqlClient;
using System.Data;

namespace SmartClinic.DAL
{
    /// <summary>
    /// Class that communicates with the Patients table in the DB. 
    /// </summary>
    public class PatientDAL
    {
        /// <summary>
        /// It searches patients by their name, id, and date of birth.
        /// </summary>
        /// <param name="firstName">The patients's username.</param>
        /// <param name="lastName">The patients's lastName.</param>
        /// <param name="patientId">The patients's patientId.</param>
        /// <param name="dateOfBirth">The patients's dateOfBirth.</param>
        /// <returns>The list of found patients.</returns>
        public List<Patient> SearchPatients(string firstName, string lastName, int patientId, DateTime? dateOfBirth)
        {
            if (String.IsNullOrWhiteSpace(firstName) &&
                String.IsNullOrWhiteSpace(lastName) &&
                patientId <= 0 &&
                dateOfBirth == null)
            {
                throw new ArgumentException("At least one parameter must be neither null nor empty.");
            }
            string selectStatement =
            " SELECT p.patient_id, cp.first_name, cp.last_name, cp.date_of_birth, cp.street1," +
            " cp.street2, cp.city, cp.state" +
            " FROM Patients p" +
            " INNER JOIN ClinicPersons cp ON (p.clinic_person_id = cp.clinic_person_id)" +
            " WHERE 1=2";
            if (patientId > 0)
            {
                selectStatement += " OR p.patient_id = @PatientId";
            }
            if (!String.IsNullOrWhiteSpace(firstName))
            {
                selectStatement += " OR cp.first_name LIKE @FirstName";
            }
            if (!String.IsNullOrWhiteSpace(lastName))
            {
                selectStatement += " OR cp.last_name LIKE @LastName";
            }
            if (dateOfBirth != null)
            {
                selectStatement += " OR cp.date_of_birth = @DateOfBirth";
            }
            selectStatement += ";";

            List<Patient> patientList = new List<Patient>();
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (patientId > 0)
                    {
                        selectCommand.Parameters.AddWithValue("@PatientId", patientId);
                    }
                    if (!String.IsNullOrWhiteSpace(firstName))
                    {
                        selectCommand.Parameters.AddWithValue("@FirstName", '%' + firstName + '%');
                    }
                    if (!String.IsNullOrWhiteSpace(lastName))
                    {
                        selectCommand.Parameters.AddWithValue("@LastName", '%' + lastName + '%');
                    }
                    if (dateOfBirth != null)
                    {
                        selectCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.GetValueOrDefault().Date);
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient()
                            {
                                PatientId = Int32.Parse(reader["patient_id"].ToString()),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                                Street1 = reader["street1"].ToString(),
                                Street2 = reader["street2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                            };
                            patientList.Add(patient);
                        }
                    }
                }
            }
            return patientList;
        }

        internal void DeletePatient(int patientID)
        {
            string insertStatement = "DELETE FROM Patients WHERE patient_id = @PatientID";


            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@PatientID", patientID);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        public bool PatientIsNotADoctor(int patientID) //may not need this class, but keeping just in case
        {
            string selectStatement =

                "select count(*) from Patients p, ClinicPersons cp, Doctors d " +
                "where p.clinic_person_id = cp.clinic_person_id and " +
                "cp.clinic_person_id = d.clinic_person_id and " +
                "p.patient_id = @PatientID";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientID", patientID);

                    if ((Int32)selectCommand.ExecuteScalar() == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        public bool PatientHasNoAppointments(int patientID)
        {
            string selectStatement =

                "SELECT count(*) FROM Appointments WHERE patient_id = @PatientID";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientID", patientID);

                    if ((Int32)selectCommand.ExecuteScalar() == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public List<Patient> SearchPatients(string firstName, string lastName, DateTime? dateOfBirth)
        {
            if (String.IsNullOrWhiteSpace(firstName) &&
                String.IsNullOrWhiteSpace(lastName) &&
                dateOfBirth == null)
            {
                throw new ArgumentException("At least one parameter must be neither null nor empty.");
            }
            string selectStatement =
            " SELECT p.patient_id, cp.first_name, cp.gender, cp.last_name, cp.date_of_birth, cp.street1," +
            " cp.street2, cp.city, cp.state" +
            " FROM Patients p" +
            " INNER JOIN ClinicPersons cp ON (p.clinic_person_id = cp.clinic_person_id)" +
            " WHERE 1=2";
            if (!String.IsNullOrWhiteSpace(firstName))
            {
                selectStatement += " OR cp.first_name LIKE @FirstName";
            }
            if (!String.IsNullOrWhiteSpace(lastName))
            {
                selectStatement += " OR cp.last_name LIKE @LastName";
            }
            if (dateOfBirth != null)
            {
                selectStatement += " OR cp.date_of_birth = @DateOfBirth";
            }
            selectStatement += ";";

            List<Patient> patientList = new List<Patient>();
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    
                    if (!String.IsNullOrWhiteSpace(firstName))
                    {
                        selectCommand.Parameters.AddWithValue("@FirstName", '%' + firstName + '%');
                    }
                    if (!String.IsNullOrWhiteSpace(lastName))
                    {
                        selectCommand.Parameters.AddWithValue("@LastName", '%' + lastName + '%');
                    }
                    if (dateOfBirth != null)
                    {
                        selectCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.GetValueOrDefault().Date);
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient()
                            {
                                PatientId = Int32.Parse(reader["patient_id"].ToString()),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                Gender = reader["gender"].ToString(),
                                DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                                Street1 = reader["street1"].ToString(),
                                Street2 = reader["street2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                            };
                            patientList.Add(patient);
                        }
                    }
                }
            }
            return patientList;
        }

        internal int AddPatient(int clinicPersonID)
        {
            string insertStatement =

                       "INSERT Patients " +
                         "(clinic_person_id) " +
                       "VALUES (@ClinicPersonID)";


            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@ClinicPersonID", clinicPersonID);                 
                    insertCommand.ExecuteNonQuery();
                }
            }
            return this.GetLastPatientID();
        }

        private int GetLastPatientID()
        {
            int lastPatientID = 0;
            string selectStatement =

           "SELECT TOP 1 patient_id FROM Patients ORDER BY patient_id DESC";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))

                    {
                        while (reader.Read())
                        {
                            lastPatientID = (int)reader["patient_id"];
                        }
                    }
                }
            }
            return lastPatientID;
        }
    

        public int AddClinicPerson(ClinicPerson newPatient)
        {
            string insertStatement =
                 
           "INSERT ClinicPersons " +
             "(date_of_birth, gender, first_name, last_name, street1, street2, city, state, zip_code, phone_number) " +
           "VALUES (@DateOfBirth, @Gender, @FirstName, @LastName, @Street1, @Street2, @City, @State, @ZipCode, @Phone)";
            

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@DateOfBirth", newPatient.DateOfBirth);
                    insertCommand.Parameters.AddWithValue("@Gender", newPatient.Gender);
                    insertCommand.Parameters.AddWithValue("@FirstName", newPatient.FirstName);
                    insertCommand.Parameters.AddWithValue("@LastName", newPatient.LastName);
                    insertCommand.Parameters.AddWithValue("@Street1", newPatient.Street1);
                    insertCommand.Parameters.AddWithValue("@Street2", newPatient.Street2);
                    insertCommand.Parameters.AddWithValue("@City", newPatient.City);
                    insertCommand.Parameters.AddWithValue("@State", newPatient.State);
                    insertCommand.Parameters.AddWithValue("@ZipCode", newPatient.ZipCode);
                    insertCommand.Parameters.AddWithValue("@Phone", newPatient.Phone);

                    insertCommand.ExecuteNonQuery();
                }
            }
            return this.GetLastClinicPersonID();
        }

        private int GetLastClinicPersonID()
        {
            int lastClinicPersonID = 0;
            string selectStatement =

           "SELECT TOP 1 clinic_person_id FROM ClinicPersons ORDER BY clinic_person_id DESC";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {                  
                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))

                    {
                        while (reader.Read())
                        {
                            lastClinicPersonID = (int)reader["clinic_person_id"];                           
                        }
                    }
                }
            }
            return lastClinicPersonID;
        }
    }
}
