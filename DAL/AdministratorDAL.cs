using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Data.SqlClient;
using System.Data;

namespace SmartClinic.DAL
{
    /// <summary>
    /// Class that communicates with the Administrators table in the DB. 
    /// </summary>
    public class AdministratorDAL
    {
        /// <summary>
        /// It verifies if an admin exists with the provided username and password.
        /// </summary>
        /// <param name="username">The admin's username.</param>
        /// <param name="password">The admin's password.</param>
        /// <returns>The admin if found. Null otherwise.</returns>
        public Administrator GetByUserNameAndPassword(string username, string password)
        {
            if (String.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("username cannot be null or empty.");
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("password cannot be null or empty.");
            }
            string selectStatement =
            " SELECT a.administrator_id, a.username, cp.first_name, cp.last_name" +
            " FROM Administrators a" +
            " INNER JOIN ClinicPersons cp ON (a.clinic_person_id = cp.clinic_person_id)" +
            " WHERE a.username = @UserName" +
            "   AND a.password = HASHBYTES('SHA2_512', @Password+CAST(a.username AS NVARCHAR(36)));";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@UserName", username);
                    selectCommand.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Administrator admin = new Administrator()
                            {
                                AdministratorId = Int32.Parse(reader["administrator_id"].ToString()),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                            };
                            return admin;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public List<MostPerformedTestDuringDates> getMostPerformedTestsDuringDates(DateTime startDate, DateTime endDate)
        {
            if (startDate == null)
            {
                throw new ArgumentNullException("startDate");
            }
            if (endDate == null)
            {
                throw new ArgumentNullException("endDate");
            }
            List<MostPerformedTestDuringDates> mostPerformedTestDuringDatesList = new List<MostPerformedTestDuringDates>();
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("getMostPerformedTestsDuringDates", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MostPerformedTestDuringDates mostPerformedTestDuringDates = new MostPerformedTestDuringDates()
                            {
                                LabTestCode = reader["lab_test_code"].ToString(),
                                LabTestName = reader["lab_test_name"].ToString(),
                                TestsCount = int.Parse(reader["tests_count"].ToString()),
                                AllTestsCount = int.Parse(reader["all_tests_count"].ToString()),
                                TestCountPercentage = reader["test_count_percentage"].ToString(),
                                NormalResultsCount = int.Parse(reader["normal_results_count"].ToString()),
                                AbnormalResultsCount = int.Parse(reader["abnormal_results_count"].ToString()),
                                TestsOn18To29Percent = reader["tests_on_18_29_percent"].ToString(),
                                TestsOn30To39Percent = reader["tests_on_30_39_percent"].ToString(),
                                TestsNotOn18To39Percent = reader["tests_on_not_18_39_percent"].ToString(),
                            };
                            mostPerformedTestDuringDatesList.Add(mostPerformedTestDuringDates);
                        }
                    }
                }
            }
            return mostPerformedTestDuringDatesList;
        }
    }
}