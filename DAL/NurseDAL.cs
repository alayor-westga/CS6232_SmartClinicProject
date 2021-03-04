using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Data.SqlClient;

namespace SmartClinic.DAL
{
    /// <summary>
    /// Class that communicates with the Nurses table in the DB. 
    /// </summary>
    public class NurseDAL
    {
        /// <summary>
        /// It verifies if a nurse exists with the provided username and password.
        /// </summary>
        /// <returns>The nurse if found. Null otherwise.</returns>
        public Nurse GetByUserNameAndPassword(string username, string password)
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
            " SELECT n.nurse_id, cp.first_name, cp.last_name" +
            " FROM Nurses n" +
            " INNER JOIN ClinicPersons cp" +
            " WHERE n.username = @UserName" +
            "   AND password = @Password;";

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
                            Nurse nurse = new Nurse()
                            {
                                NurseId = Int32.Parse(reader["nurse_id"].ToString()),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                            };
                            return nurse;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }
}