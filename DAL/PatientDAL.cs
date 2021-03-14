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
            " cp.street2, cp.city, cp.state" +
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
            " cp.street2, cp.city, cp.state" +
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
            " cp.street2, cp.city, cp.state" +
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
                            };
                            patientList.Add(patient);
                        }
                    }
                }
                return patientList;
            }
        }

        public List<PatientVisits> SearchPatientVisitsByDOB(DateTime dateOfBirth)
        {
            if (dateOfBirth == null)
            {
                throw new ArgumentNullException("dateOfBirth");
            }
            string selectStatement =
            "SELECT p.patient_id as 'PID', a.appointment_id as 'AID', cpp.first_name + ' ' + cpp.last_name as 'Patient'," +
            "cpd.first_name + ' ' + cpd.last_name as 'Doctor', a.date as 'Visit Date' " +

            "FROM Appointments a " +
            "JOIN Visits v on a.appointment_id = v.appointment_id " +
            "JOIN Patients p on a.patient_id = p.patient_id " +
            "JOIN Doctors d on d.doctor_id = a.doctor_id " +
            "JOIN Nurses n on n.nurse_id = v.nurse_id " +
            "JOIN ClinicPersons cpp on cpp.clinic_person_id = p.clinic_person_id " +
            "JOIN ClinicPersons cpd on cpd.clinic_person_id = d.clinic_person_id " +
            "JOIN ClinicPersons cpn on cpn.clinic_person_id = n.clinic_person_id " +
            "WHERE cpp.date_of_birth = @DateOfBirth";

            return SelectManyPatientVisits(selectStatement, new Hashtable()
                {
                    {"@DateOfBirth", dateOfBirth.Date}
                }
            );
        }

        internal List<PatientVisits> SelectManyPatientVisits(string selectStatement, Hashtable parameters = null) //Don't need anymore
        {
            List<PatientVisits> patientVisitList = new List<PatientVisits>();
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (parameters != null)
                    {
                        foreach (DictionaryEntry param in parameters)
                        {
                            selectCommand.Parameters.AddWithValue((String)param.Key, param.Value);
                        }
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PatientVisits patientVisit = new PatientVisits()
                            {
                                AppointmentID = Int32.Parse(reader["AID"].ToString()),
                                PatientID = Int32.Parse(reader["PID"].ToString()),                             
                                VisitDate = DateTime.Parse(reader["Visit Date"].ToString()),
                                Patient = reader["Patient"].ToString(),
                                Doctor = reader["Doctor"].ToString(),
                            };
                            patientVisitList.Add(patientVisit);
                        }
                    }
                }
                return patientVisitList;
            }
        }

        public bool UpdatePatientInformation(ClinicPerson oldPatient, ClinicPerson newPatient) 
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
                    "AND phone_number = @OldPhoneNumber ";
            updateStatement += oldPatient.SSN == null ? "AND ssn IS NULL;" : "AND ssn = @OldSSN;";

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
                    if (oldPatient.SSN != null) 
                    {
                        updateCommand.Parameters.AddWithValue("@OldSSN", oldPatient.SSN);
                    }

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public void DeletePatient(int patientID)
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
                            patient.SSN = reader["ssn"] == DBNull.Value ? null : (string)reader["ssn"];
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
