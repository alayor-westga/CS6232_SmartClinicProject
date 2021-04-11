using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace SmartClinic.DAL
{
    /// <summary>
    /// Class that communicates with the Lab Tests table in the DB. 
    /// </summary>
    public class LabTestDAL
    {
        /// <summary>
        /// It returns all the lab tests in the system.
        /// </summary>
        /// <returns>The list of LabTests.</returns>
        public List<LabTest> GetAllLabTests()
        {
            string selectStatement =
            " SELECT lab_test_code, name" +
            " FROM LabTests;";

            return SelectMany(selectStatement, null);
        }

        private List<LabTest> SelectMany(string selectStatement, Hashtable parameters = null)
        {
            List<LabTest> labTestList = new List<LabTest>();
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
                             LabTest labTest = new LabTest()
                            {
                                LabTestCode = reader["lab_test_code"].ToString(),
                                Name = reader["name"].ToString(),
                            };
                            labTestList.Add(labTest);
                        }
                    }
                }
                return labTestList;
            }
        }

       public void AddOrderedTests(List<LabTestResults> orderedTests)
       {
            if (orderedTests == null)
            {
                throw new ArgumentNullException("orderedTests");
            }
            string insertStatement =
           "INSERT LabTestResults " +
             "(appointment_id, lab_test_code) " +
           "VALUES (@AppointmentID, @LabTestCode)";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    foreach (LabTestResults orderedTest in orderedTests)
                    {
                        using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection, transaction))
                        {
                            insertCommand.Parameters.AddWithValue("@AppointmentID", orderedTest.AppointmentID);
                            insertCommand.Parameters.AddWithValue("@LabTestCode", orderedTest.LabTestCode);

                            insertCommand.ExecuteNonQuery();
                        }
                    }                                      
                    transaction.Commit();                    
                }
                catch 
                {
                    transaction.Rollback();
                    throw new Exception("Could not add tests. Check to be sure \neach test has not already been ordered.");
                }
            }
       }

        public List<LabTestResults> GetTestsForAppointment(int appointmentID)
        {
            if (appointmentID < 0)
            {
                throw new ArgumentException("The patientId must not be negative");
            }

            string selectStatement =
            "SELECT appointment_id, lab_test_code, date_performed, result, is_normal " +
            " WHERE appointment_id=@AppoinmtentID;";

            List<LabTestResults> labTestSearchResults = new List<LabTestResults>();
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentID", appointmentID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LabTestResults labTestResult = new LabTestResults()
                            {
                                AppointmentID = Int32.Parse(reader["appointment_id"].ToString()),
                                LabTestCode = reader["lab_test_code"].ToString(),
                                DatePerformed = DateTime.Parse(reader["date_performed"].ToString()),
                                Result = reader["result"].ToString(),
                                IsNormal = (bool) reader["street2"],                             
                            };
                            labTestSearchResults.Add(labTestResult);
                        }
                    }
                }
            }
            return labTestSearchResults;
        }
    }
}
