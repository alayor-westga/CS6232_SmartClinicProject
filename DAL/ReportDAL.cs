using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Data.SqlClient;
using System.Data;

namespace SmartClinic.DAL
{
    /// <summary>
    /// Class that generates reports frrom the DB. 
    /// </summary>
    public class ReportDAL
    {
        /// <summary>
        ///  Gets the statistics that show the most performed tests during the 
        ///  specified period of time for the tests that were performed at least twice.
        /// </summary>
        /// <param name="startDate">The start date range within the tests were performed.</param>
        /// <param name="endDate">The end date range within the tests were performed.</param>
        /// <returns>The list of most performed test during the specified date range.</returns>
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