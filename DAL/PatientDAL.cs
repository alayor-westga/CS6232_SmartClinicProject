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

        internal bool UpdatePatientInformation(ClinicPerson oldPatient, ClinicPerson newPatient) //here is where I am currently working
        {
            string updateStatement =
               "UPDATE ClinicPersons SET " +
                    "first_name = @NewFirstName, " +
                    "last_name = @NewLastName, " +
                    "date_of_birth = @NewDateOfBirth, " +
                    "gender = @NewGender, " +
                    "street1 = @NewStreet1, " +
                    "street2 = @NewStreet2, " +
                    "city = @NewCity, " +
                    "state = @NewState, " +
                    "zip_code = @NewZipCode, " +
                    "phone_number = @NewPhoneNumber, " +
                    "ssn = @NewSSN " +
                "WHERE clinic_person_id = @OldClinicPersonID " +
                    "AND first_name = @OldFirstName " +
                    "AND last_name = @OldLastName " +
                    "AND date_of_birth = @OldDateOfBirth " +
                    "AND gender = @OldGender " +
                    "AND street1 = @OldStreet1 " +
                    "AND street2 = @OldStreet2 " +
                    "AND city = @OldCity " +
                    "AND state = @OldState " +
                    "AND zip_code = @OldZipCode " +
                    "AND phone_number = @OldPhoneNumber " +
                    "AND ssn = @OldSSN";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@NewFirstName", newPatient.FirstName);
                    updateCommand.Parameters.AddWithValue("@NewLastName", newPatient.LastName);
                    updateCommand.Parameters.AddWithValue("@NewDateOfBirth", newPatient.DateOfBirth);
                    updateCommand.Parameters.AddWithValue("@NewGender", newPatient.Gender);
                    updateCommand.Parameters.AddWithValue("@NewStreet1", newPatient.Street1);
                    updateCommand.Parameters.AddWithValue("@NewStreet2", newPatient.Street2);
                    updateCommand.Parameters.AddWithValue("@NewCity", newPatient.City);
                    updateCommand.Parameters.AddWithValue("@NewState", newPatient.State);
                    updateCommand.Parameters.AddWithValue("@NewZipCode", newPatient.ZipCode);
                    updateCommand.Parameters.AddWithValue("@NewPhoneNumber", newPatient.Phone);
                    updateCommand.Parameters.AddWithValue("@NewSSN", newPatient.SSN);
       

                    updateCommand.Parameters.AddWithValue("@OldClinicPersonID", oldPatient.ClinicPersonID);
                    updateCommand.Parameters.AddWithValue("@OldFirstName", oldPatient.FirstName);
                    updateCommand.Parameters.AddWithValue("@OldLastName", oldPatient.LastName);
                    updateCommand.Parameters.AddWithValue("@OldDateOfBirth", oldPatient.DateOfBirth);
                    updateCommand.Parameters.AddWithValue("@OldGender", oldPatient.Gender);
                    updateCommand.Parameters.AddWithValue("@OldStreet1", oldPatient.Street1);
                    updateCommand.Parameters.AddWithValue("@OldStreet2", oldPatient.Street2);
                    updateCommand.Parameters.AddWithValue("@OldCity", oldPatient.City);
                    updateCommand.Parameters.AddWithValue("@OldState", oldPatient.State);
                    updateCommand.Parameters.AddWithValue("@OldZipCode", oldPatient.ZipCode);
                    updateCommand.Parameters.AddWithValue("@OldPhoneNumber", oldPatient.Phone);
                    updateCommand.Parameters.AddWithValue("@OldSSN", oldPatient.SSN);

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            };
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
             "(date_of_birth, gender, first_name, last_name, street1, street2, city, state, zip_code, phone_number, ssn) " +
           "VALUES (@DateOfBirth, @Gender, @FirstName, @LastName, @Street1, @Street2, @City, @State, @ZipCode, @Phone, @SSN)";

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
                    insertCommand.Parameters.AddWithValue("@SSN", newPatient.SSN);

                    insertCommand.ExecuteNonQuery();
                }
            }
            return this.GetLastClinicPersonID();
        }

        public ClinicPerson GetClinicPerson(int patientID)
        {
            ClinicPerson patient = new ClinicPerson();
            string selectStatement =

                "SELECT " +
                    "c.clinic_person_id, " +
                    "first_name, " +
                    "last_name, " +
                    "date_of_birth, " +
                    "gender, " +
                    "street1, " +
                    "street2, " +
                    "city, " +
                    "state, " +
                    "zip_code, " +
                    "phone_number, " +
                    "ssn " +
                "FROM ClinicPersons c " +
                    "JOIN Patients p " +
                        "ON c.clinic_person_id = p.clinic_person_id " +
                "WHERE patient_id = @PatientID";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientID", patientID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))

                    {
                        while (reader.Read())
                        {
                            patient.ClinicPersonID = (int)reader["clinic_person_id"];
                            patient.FirstName = (string)reader["first_name"];
                            patient.LastName = (string)reader["last_name"];
                            patient.DateOfBirth = (DateTime)reader["date_of_birth"];
                            patient.Gender = (string)reader["gender"];
                            patient.Street1 = (string)reader["street1"];
                            if (reader[5] == DBNull.Value)
                            {
                                patient.Street2 = "";
                            }
                            else
                            {
                                patient.Street2 = (string)reader["street2"];
                            }
                            patient.City = (string)reader["city"];
                            patient.State = (string)reader["state"];
                            patient.ZipCode = (string)reader["zip_code"];
                            patient.Phone = (string)reader["phone_number"];
                            patient.SSN = (string)reader["ssn"];
                        }
                    }
                }
                return patient;
            }
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
