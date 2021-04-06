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
        /// <param name="username">The nurse's username.</param>
        /// <param name="password">The nurse's password.</param>
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
            " SELECT n.nurse_id, n.username, cp.first_name, cp.last_name" +
            " FROM Nurses n" +
            " INNER JOIN ClinicPersons cp ON (n.clinic_person_id = cp.clinic_person_id)" +
            " WHERE n.username = @UserName" +
            "   AND password = HASHBYTES('SHA2_512', @Password+CAST(username AS NVARCHAR(36)));";

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

        /// <summary>
        /// It inserts a nurse into the DB.
        /// </summary>
        /// <param name="clinicPersonID">The clinic person id of the nurse.</param>
        /// <returns>The number of rows affected.</returns>
        public int AddNurse(int clinicPersonID)
        {
            return 0;
        }
    }
}