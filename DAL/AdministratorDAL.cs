using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Data.SqlClient;

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
    }
}