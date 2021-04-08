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
    }
}
