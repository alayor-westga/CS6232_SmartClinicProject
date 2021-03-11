using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Data.SqlClient;
using System.Data;

namespace SmartClinic.DAL
{
    /// <summary>
    /// Class that communicates with the Visits table in the DB. 
    /// </summary>
    public class VisitDAL
    {
        /// <summary>
        /// It verifies if an appoinment is assigned to a visit.
        /// </summary>
        /// <param name="appointmentId">The appointment id to be searched.</param>
        /// <returns>True if exists. False otherwise.</returns>
        public bool ExistsForAppointmentId(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointmentId must not be negative.");
            }
            string selectStatement =
            " SELECT appointment_id" +
            " FROM Visits" +
            " WHERE appointment_id = @AppointmentId";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
    }
}