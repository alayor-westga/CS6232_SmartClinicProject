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
    }
}