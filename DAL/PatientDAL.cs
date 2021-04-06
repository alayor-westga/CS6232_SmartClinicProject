using System;
using System.Collections.Generic;
using System.Collections;
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
        /// It searches patients by their date of birth.
        /// </summary>
        /// <param name="dateOfBirth">The patients's date of birth.</param>
        /// <returns>The list of found patients.</returns>
        public List<Patient> SearchByDOB(DateTime dateOfBirth)
        {
            if (dateOfBirth == null)
            {
                throw new ArgumentNullException("dateOfBirth");
            }
            string selectStatement =
            " SELECT p.patient_id, cp.first_name, cp.last_name, cp.date_of_birth, cp.street1," +
            " cp.street2, cp.city, cp.state, cp.ssn" +
            " FROM Patients p" +
            " INNER JOIN ClinicPersons cp ON (p.clinic_person_id = cp.clinic_person_id)" +
            " WHERE cp.date_of_birth = @DateOfBirth";

            return SelectMany(selectStatement, new Hashtable()
                {
                    {"@DateOfBirth", dateOfBirth.Date}
                }
            );
        }

        /// <summary>
        /// It searches patients by their names.
        /// </summary>
        /// <param name="firstName">The patients's first name.</param>
        /// <param name="lastName">The patients's last name.</param>
        /// <returns>The list of found patients.</returns>
        public List<Patient> SearchByName(string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Please enter a name to search.");
            }
            string selectStatement =
            " SELECT p.patient_id, cp.first_name, cp.last_name, cp.date_of_birth, cp.street1," +
            " cp.street2, cp.city, cp.state, cp.ssn" +
            " FROM Patients p" +
            " INNER JOIN ClinicPersons cp ON (p.clinic_person_id = cp.clinic_person_id)" +
            " WHERE 1=1";

            Hashtable parameters = new Hashtable();
            if (!String.IsNullOrWhiteSpace(firstName))
            {
                selectStatement += " AND cp.first_name like @FirstName";
                parameters.Add("@FirstName", "%" + firstName + "%");
            }
            if (!String.IsNullOrWhiteSpace(lastName))
            {
                selectStatement += " AND cp.last_name like @LastName";
                parameters.Add("@LastName", "%" + lastName + "%");
            }

            return SelectMany(selectStatement, parameters);
        }

        /// <summary>
        /// It searches patients by their date of birth and last name.
        /// </summary>
        /// <param name="dateOfBirth">The patients's date of birth</param>
        /// <param name="lastName">The patients's last name.</param>
        /// <returns>The list of found patients.</returns>
        public List<Patient> SearchByDOBAndLastName(DateTime dateOfBirth, string lastName)
        {
            if (dateOfBirth == null)
            {
                throw new ArgumentNullException("dateOfBirth");
            }
            string selectStatement =
            " SELECT p.patient_id, cp.first_name, cp.last_name, cp.date_of_birth, cp.street1," +
            " cp.street2, cp.city, cp.state, cp.ssn" +
            " FROM Patients p" +
            " INNER JOIN ClinicPersons cp ON (p.clinic_person_id = cp.clinic_person_id)" +
            " WHERE cp.date_of_birth = @DateOfBirth";
            
            Hashtable parameters = new Hashtable()
                {
                    {"@DateOfBirth", dateOfBirth.Date}
                };

            if (!String.IsNullOrWhiteSpace(lastName))
            {
                selectStatement += " AND cp.last_name like @LastName";
                parameters.Add("@LastName", "%" + lastName + "%");
            }

            return SelectMany(selectStatement, parameters);
        }

        internal List<Patient> SelectMany(string selectStatement, Hashtable parameters = null)
        {
            List<Patient> patientList = new List<Patient>();
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (parameters != null)
                    {
                        foreach (DictionaryEntry param in parameters)
                        {
                            selectCommand.Parameters.AddWithValue((String) param.Key, param.Value);
                        }
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
                                SSN = reader["ssn"].ToString(),
                            };
                            patientList.Add(patient);
                        }
                    }
                }
                return patientList;
            }
        }

        /// <summary>
        /// It updates a patient in the DB.
        /// </summary>
        /// <param name="oldPatient">The old patient info.</param>
        /// <param name="newPatient">The new patient info.</param>
        /// <returns>True if the update was successful. False otherwise</returns>
        public bool UpdatePatientInformation(ClinicPerson oldPatient, ClinicPerson newPatient) 
        {
            if (oldPatient == null)
            {
                throw new ArgumentNullException("oldPatient");
            }
            if (newPatient == null)
            {
                throw new ArgumentNullException("newPatient");
            }
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
                    "AND ssn = @OldSSN;";

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
            }
        }

        /// <summary>
        /// It removes a patient from the DB.
        /// </summary>
        /// <param name="patientID">The patient to be removed.</param>
        public void DeletePatient(int patientID)
        {
            if (patientID < 0)
            {
                throw new ArgumentException("The patientID must not be negative");
            }
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

        public bool PatientHasNoAppointments(int patientID)
        {
            if (patientID < 0)
            {
                throw new ArgumentException("The patientID must not be negative");
            }
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

        /// <summary>
        /// It adds a patient to the DB.
        /// </summary>
        /// <param name="clinicPersonID">The clinic person id of the patient.</param>
        /// <returns>The number of rows affected.</returns>
        public int AddPatient(int clinicPersonID)
        {
            if (clinicPersonID < 0)
            {
                throw new ArgumentException("The clinicPersonID must not be negative");
            }
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

         public ClinicPerson GetClinicPerson(int patientID)
        {
            if (patientID < 0)
            {
                throw new ArgumentException("patientID must not be negative");
            }
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
    }
}
