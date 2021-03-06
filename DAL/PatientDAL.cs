using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Data.SqlClient;

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
                patientId == 0 &&
                dateOfBirth == null)
            {
                throw new ArgumentException("At least one parameter must be neither null nor empty.");
            }
            string selectStatement =
            " SELECT p.patient_id, cp.first_name, cp.last_name, cp.date_of_birth, cp.street1" +
            " cp.street2, cp.city, cp.state" +
            " FROM Patients p" +
            " INNER JOIN ClinicPersons cp ON (p.clinic_person_id = cp.clinic_person_id)" +
            " WHERE p.patient_id = @PatientId" +
            "   OR cp.first_name like '%@FirstName%'" +
            "   OR cp.last_name like '%@LastName%';";
            "   OR cp.date_of_birth = '%@DateOfBirth%';";

            List<Patient> patientList = new List<Patient>();
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@UserName", username);
                    selectCommand.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient()
                            {
                                PatientId = Int32.Parse(reader["patient_id"].ToString()),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                DateOfBirth = reader["date_of_birth"].ToString(),
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
    }
}