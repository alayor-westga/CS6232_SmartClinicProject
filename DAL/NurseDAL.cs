using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

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
            " SELECT n.nurse_id, n.username, n.password, cp.first_name, cp.last_name" +
            " FROM Nurses n" +
            " INNER JOIN ClinicPersons cp ON (n.clinic_person_id = cp.clinic_person_id)" +
            " WHERE n.username = @UserName COLLATE Latin1_General_CS_AS" +
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
                                LastName = reader["last_name"].ToString()
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
        /// <returns>The id of the new nurse.</returns>
        internal int AddNurse(int clinicPersonID, SqlConnection connection, SqlTransaction transaction)
        {
            if (clinicPersonID < 0)
            {
                throw new ArgumentException("The clinicPersonID must not be negative");
            }
            string insertStatement =
                " INSERT Nurses" +
                " (clinic_person_id)" +
                " VALUES (@ClinicPersonID); SET @ID = SCOPE_IDENTITY();";


            using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection, transaction))
            {
                insertCommand.Parameters.AddWithValue("@ClinicPersonID", clinicPersonID);

                SqlParameter param = new SqlParameter("@ID", SqlDbType.Int, 4);
                param.Direction = ParameterDirection.Output;
                insertCommand.Parameters.Add(param);
                insertCommand.ExecuteNonQuery();
                return int.Parse(insertCommand.Parameters["@ID"].Value.ToString());
            }
        }

        /// <summary>
        /// It returns all the nurses in the system.
        /// </summary>
        /// <returns>The list of nurses.</returns>
        public List<Nurse> GetAllNurses()
        {
            string selectStatement =
            " SELECT n.nurse_id, n.username, n.password, cp.first_name, cp.last_name, cp.date_of_birth, cp.street1," +
            " cp.street2, cp.city, cp.state, cp.ssn" +
            " FROM Nurses n" +
            " INNER JOIN ClinicPersons cp ON (n.clinic_person_id = cp.clinic_person_id);";

            return SelectMany(selectStatement, null);
        }

        private List<Nurse> SelectMany(string selectStatement, Hashtable parameters = null)
        {
            List<Nurse> nurseList = new List<Nurse>();
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
                             Nurse Nurse = new Nurse()
                            {
                                NurseId = Int32.Parse(reader["nurse_id"].ToString()),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                                Street1 = reader["street1"].ToString(),
                                Street2 = reader["street2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                SSN = reader["ssn"].ToString(),
                                UserName = reader["username"] == DBNull.Value ? null : reader["username"].ToString(),
                                HasCredentialsSet = reader["username"].ToString().Length > 0 && reader["password"].ToString().Length > 0
                            };
                            nurseList.Add(Nurse);
                        }
                    }
                }
                return nurseList;
            }
        }

        /// <summary>
        /// It updates the user name and password of the nurse.
        /// </summary>
        /// <param name="username">The new username.</param>
        /// <param name="password">The new password.</param>
        /// <param name="currentUserName">The current user name.</param>
        /// <param name="currentPassword">The current password.</param>
        /// <returns>True if the update was successful. False otherwise</returns>
        public bool SetUserNameAndPassword(
            int nurseId, 
            string username, 
            string password, 
            string currentUserName
            ) 
        {
            if (nurseId < 0)
            {
                throw new ArgumentException("nurseId must not be null.");
            }
            if (String.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("username must have a value.");
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("username must have a value.");
            }
            string updateStatement =
               " UPDATE Nurses SET" +
                    " username = @UserName, " +
                    " password = HASHBYTES('SHA2_512', @Password+CAST(@Username AS NVARCHAR(36)))" +
                " WHERE nurse_id = @NurseId";
            updateStatement += currentUserName == null ? " AND username IS NULL;" : " AND username = @CurrentUserName;";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@NurseId", nurseId);
                    updateCommand.Parameters.AddWithValue("@UserName", username);
                    updateCommand.Parameters.AddWithValue("@Password", password);
                    if (currentUserName != null)
                    {
                        updateCommand.Parameters.AddWithValue("@CurrentUserName", currentUserName);
                    }

                    int count = updateCommand.ExecuteNonQuery();
                    if (count > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        /// <summary>
        /// Checks if a nurse user name exists.
        /// </summary>
        /// <param name="username">the username to check</param>
        /// <returns>true if username exists, false otherwise.</returns>
        public bool UserNameExists(string username)
        {
            if (username == null) 
            {
                throw new ArgumentNullException("username");
            }

            string selectStatement =
                "SELECT COUNT(1) FROM Nurses WHERE username = @UserName COLLATE Latin1_General_CS_AS;";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@UserName", username);

                    if ((Int32)selectCommand.ExecuteScalar() == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
}