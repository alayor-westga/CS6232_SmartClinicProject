using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Data.SqlClient;

namespace SmartClinic.DAL
{
    /// <summary>
    /// Class that communicates with the Appointments table in the DB. 
    /// </summary>
    public class AppointmentDAL
    {
        /// <summary>
        /// It inserts a new appointment in the data base.
        /// </summary>
        /// <param name="newAppointment">The appointment to be inserted.</param>
        public void AddAppointment(Appointment newAppointment)
        {
            if (newAppointment == null)
            {
                throw new ArgumentNullException("newAppointment");
            }
            string insertStatement = "INSERT Appointments" +
            " (patient_id, date, doctor_id, reason)" +
            " VALUES (@PatientId, @Date, @DoctorId, @Reason)";
            
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@PatientId", newAppointment.PatientId);
                    insertCommand.Parameters.AddWithValue("@Date", newAppointment.Date);
                    insertCommand.Parameters.AddWithValue("@DoctorId", newAppointment.DoctorId);
                    insertCommand.Parameters.AddWithValue("@Reason", newAppointment.Reason);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}