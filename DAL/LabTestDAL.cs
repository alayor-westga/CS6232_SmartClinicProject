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
                            selectCommand.Parameters.AddWithValue((String)param.Key, param.Value);
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

            "SELECT appointment_id, LabTests.lab_test_code, LabTests.name, date_performed, result, is_normal " +
            "FROM LabTestResults " +
            "JOIN LabTests on LabTests.lab_test_code = LabTestResults.lab_test_code" +
            " WHERE appointment_id=@AppointmentID;";

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
                            LabTestResults labTestResult = new LabTestResults();
                            {

                                labTestResult.AppointmentID = Int32.Parse(reader["appointment_id"].ToString());
                                labTestResult.LabTestCode = reader["lab_test_code"].ToString();
                                labTestResult.LabTestName = reader["name"].ToString();

                                if (reader[3] != DBNull.Value)
                                {
                                    labTestResult.DatePerformed = DateTime.Parse(reader["date_performed"].ToString());
                                }

                                labTestResult.Result = reader["result"].ToString();

                                if (reader[5] != DBNull.Value)
                                {
                                    labTestResult.IsNormal = (bool)reader["is_normal"];
                                }

                            }
                            labTestSearchResults.Add(labTestResult);
                        }
                    }
                }
            }
            return labTestSearchResults;
        }

        public LabTestResults GetSingleLabTestResult(string labTestCode, int appointmentID)
        {
            LabTestResults labTestResult = new LabTestResults();
            string selectStatement =

                 "SELECT appointment_id, LabTests.lab_test_code, LabTests.name, date_performed, result, is_normal " +
                 "FROM LabTestResults " +
                 "JOIN LabTests on LabTests.lab_test_code = LabTestResults.lab_test_code " +
                 "WHERE appointment_id=@AppointmentID AND LabTests.lab_test_code=@LabTestCode";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentID", appointmentID);
                    selectCommand.Parameters.AddWithValue("@LabTestCode", labTestCode);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            {
                                labTestResult.AppointmentID = Int32.Parse(reader["appointment_id"].ToString());
                                labTestResult.LabTestCode = reader["lab_test_code"].ToString();
                                labTestResult.LabTestName = reader["name"].ToString();

                                if (reader[3] != DBNull.Value)
                                {
                                    labTestResult.DatePerformed = DateTime.Parse(reader["date_performed"].ToString());
                                }

                                labTestResult.Result = reader["result"].ToString();

                                if (reader[5] != DBNull.Value)
                                {
                                    labTestResult.IsNormal = (bool)reader["is_normal"];
                                    Console.WriteLine("In get single lab test: " + labTestResult.IsNormal);

                                }
                                
                            }
                            return labTestResult;
                        }
                        else
                        {
                            Console.Write("in null");
                            return null;

                        }
                    }
                }
            }
        }

        public bool UpdateLabTestResults(LabTestResults oldResults, LabTestResults newResults, string updateVariation)
        {
            Console.WriteLine("In DAL: " + newResults.DatePerformed);
            Console.WriteLine("In update lab test results - old results: " + oldResults.IsNormal);


            if (oldResults == null)
            {
                throw new ArgumentNullException("oldResults");
            }
            if (newResults == null)
            {
                throw new ArgumentNullException("newResults");
            }
            if (updateVariation == null)
            {
                throw new ArgumentNullException("updateVariation");
            }
            string updateStatement = this.GetUpdateStatement(updateVariation);

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    if (updateVariation == "update date")
                    {


                        updateCommand.Parameters.AddWithValue("@NewDatePerformed", newResults.DatePerformed);
                        updateCommand.Parameters.AddWithValue("@OldDatePerformed", DBNull.Value);

                    }
                    if (updateVariation == "update result")
                    {


                        updateCommand.Parameters.AddWithValue("@NewResult", newResults.Result);
                        updateCommand.Parameters.AddWithValue("@OldResult", DBNull.Value);

                        updateCommand.Parameters.AddWithValue("@NewIsNormal", newResults.IsNormal);
                        updateCommand.Parameters.AddWithValue("@OldIsNormal", DBNull.Value);

                    }
                    if (updateVariation == "update result and date")
                    {
                        updateCommand.Parameters.AddWithValue("@NewResult", newResults.Result);
                        updateCommand.Parameters.AddWithValue("@OldResult", DBNull.Value);

                        updateCommand.Parameters.AddWithValue("@NewIsNormal", newResults.IsNormal);
                        updateCommand.Parameters.AddWithValue("@OldIsNormal", DBNull.Value);

                        updateCommand.Parameters.AddWithValue("@NewDatePerformed", newResults.DatePerformed);
                        updateCommand.Parameters.AddWithValue("@OldDatePerformed", DBNull.Value);
                    }
                    updateCommand.Parameters.AddWithValue("@OldAppointmentID", oldResults.AppointmentID);
                    updateCommand.Parameters.AddWithValue("@OldLabTestCode", oldResults.LabTestCode);

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        private string GetUpdateStatement(string updateVariation)
        {
            if (updateVariation == "update date")
            {
                return "UPDATE LabTestResults SET " +
                   "date_performed = @NewDatePerformed " +
               "WHERE appointment_id = @OldAppointmentID " +
                   "AND lab_test_code = @OldLabTestCode " +
                   "AND date_performed IS NULL";
            }
            else if (updateVariation == "update result")
            {
                return "UPDATE LabTestResults SET " +
                   "result = @NewResult, " +
                   "is_normal = @NewIsNormal " +
               "WHERE appointment_id = @OldAppointmentID " +
                   "AND lab_test_code = @OldLabTestCode " +
                   "AND result IS NULL " +
                   "AND is_normal IS NULL";
            }
            else
            {
                return "UPDATE LabTestResults SET " +
                   "date_performed = @NewDatePerformed, " +
                   "result = @NewResult, " +
                   "is_normal = @NewIsNormal " +
               "WHERE appointment_id = @OldAppointmentID " +
                   "AND lab_test_code = @OldLabTestCode " +
                   "AND result IS NULL " +
                   "AND date_performed IS NULL " +
                   "AND is_normal IS NULL";
            }
        }
        public bool UpdateLabTestResults(LabTestResults oldResults, LabTestResults newResults)
        {
            Console.WriteLine("In DAL: " + newResults.DatePerformed);
            Console.WriteLine("In update lab test results - old results: " + oldResults.IsNormal);


            if (oldResults == null)
            {
                throw new ArgumentNullException("oldResults");
            }
            if (newResults == null)
            {
                throw new ArgumentNullException("newResults");
            }

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                string updateStatement =
                    "UPDATE LabTestResults SET " +
                        "date_performed = @NewDatePerformed, " +
                        "result = @NewResult, " +
                        "is_normal = @NewIsNormal " +
                    "WHERE appointment_id = @OldAppointmentID " +
                        "AND lab_test_code = @OldLabTestCode " +
                        "AND (result = @OldResult OR result IS NULL and @OldResult IS NULL) " +
                        "AND (date_performed = @OldDatePerformed OR date_performed IS NULL and @OldDatePerformed IS NULL) " +
                        "AND (is_normal = @OldIsNormal OR is_normal IS NULL and @OldIsNormal IS NULL)";
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {

                    if (newResults.DatePerformed == null)
                    {
                        updateCommand.Parameters.AddWithValue("@NewDatePerformed", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@NewDatePerformed", newResults.DatePerformed);
                    }
                    if (newResults.Result == "")
                    {
                        updateCommand.Parameters.AddWithValue("@NewResult", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@NewResult", newResults.Result);
                    }
                    if (newResults.IsNormal == null)
                    {
                        updateCommand.Parameters.AddWithValue("@NewIsNormal", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@NewIsNormal", newResults.IsNormal);
                    }


                    if (oldResults.DatePerformed == null)
                    {
                        updateCommand.Parameters.AddWithValue("@OldDatePerformed", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@OldDatePerformed", oldResults.DatePerformed);
                    }
                    if (oldResults.Result == "")
                    {
                        updateCommand.Parameters.AddWithValue("@OldResult", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@OldResult", oldResults.Result);
                    }
                    if (oldResults.IsNormal == null)
                    {
                        updateCommand.Parameters.AddWithValue("@OldIsNormal", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@OldIsNormal", oldResults.IsNormal);
                    }
                 
                    updateCommand.Parameters.AddWithValue("@OldAppointmentID", oldResults.AppointmentID);
                    updateCommand.Parameters.AddWithValue("@OldLabTestCode", oldResults.LabTestCode);

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}

