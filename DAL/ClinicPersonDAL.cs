using System;
using System.Collections.Generic;
using System.Collections;
using SmartClinic.Model;
using System.Data.SqlClient;
using System.Data;

namespace SmartClinic.DAL
{
    /// <summary>
    /// Class that communicates with the Clinic Persons table in the DB. 
    /// </summary>
    public class ClinicPersonDAL
    {

        /// <summary>
        /// Checks if a ClinicPerson exists via UQ and NOT NULL key ssn
        /// </summary>
        /// <param name="ssn">ssn</param>
        /// <returns>true if ssn is not unique, false otherwise</returns>
        public bool SsnIsNotUnique(string ssn)
        {
            string selectStatement =
                "SELECT count(*) FROM ClinicPersons WHERE ssn = @SSN";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@SSN", ssn);

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

        /// <summary>
        /// It adds a clinic person to the DB.
        /// </summary>
        /// <param name="newClinicPerson">The new clinic person.</param>
        /// <returns>The number of rows affected.</returns>
        public int AddClinicPerson(ClinicPerson newClinicPerson)
        {
            if (newClinicPerson == null)
            {
                throw new ArgumentNullException("newClinicPerson");
            }
            string insertStatement =
           "INSERT ClinicPersons " +
             "(date_of_birth, gender, first_name, last_name, street1, street2, city, state, zip_code, phone_number, ssn) " +
           "VALUES (@DateOfBirth, @Gender, @FirstName, @LastName, @Street1, @Street2, @City, @State, @ZipCode, @Phone, @SSN)";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@DateOfBirth", newClinicPerson.DateOfBirth);
                    insertCommand.Parameters.AddWithValue("@Gender", newClinicPerson.Gender);
                    insertCommand.Parameters.AddWithValue("@FirstName", newClinicPerson.FirstName);
                    insertCommand.Parameters.AddWithValue("@LastName", newClinicPerson.LastName);
                    insertCommand.Parameters.AddWithValue("@Street1", newClinicPerson.Street1);
                    insertCommand.Parameters.AddWithValue("@Street2", newClinicPerson.Street2);
                    insertCommand.Parameters.AddWithValue("@City", newClinicPerson.City);
                    insertCommand.Parameters.AddWithValue("@State", newClinicPerson.State);
                    insertCommand.Parameters.AddWithValue("@ZipCode", newClinicPerson.ZipCode);
                    insertCommand.Parameters.AddWithValue("@Phone", newClinicPerson.Phone);
                    insertCommand.Parameters.AddWithValue("@SSN", newClinicPerson.SSN);

                    insertCommand.ExecuteNonQuery();
                }
            }
            return this.GetLastClinicPersonID();
        }

        private int GetLastClinicPersonID()
        {
            int lastClinicPersonID = 0;
            string selectStatement =

           "SELECT TOP 1 clinic_person_id FROM ClinicPersons ORDER BY clinic_person_id DESC";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))

                    {
                        while (reader.Read())
                        {
                            lastClinicPersonID = (int)reader["clinic_person_id"];
                        }
                    }
                }
            }
            return lastClinicPersonID;
        }
    }
}
