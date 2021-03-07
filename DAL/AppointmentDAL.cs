using System;
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
        public void Insert(Appointment newAppointment)
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

        /// <summary>
        /// It verifies if an appoinment exists for the same doctor and date.
        /// </summary>
        /// <param name="doctorId">The appointment's doctorId.</param>
        /// <param name="appointmentDate">The appointment's date time.</param>
        /// <returns>True if exists. False otherwise.</returns>
        public bool ExistsForDoctorAndDate(int doctorId, DateTime appointmentDate)
        {
            if (doctorId < 0)
            {
                throw new ArgumentException("doctorId must not be negative.");
            }
            if (appointmentDate == null)
            {
                throw new ArgumentNullException("appointmentDate");
            }
            string selectStatement =
            " SELECT appointment_id" +
            " FROM Appointments" +
            " WHERE doctor_id = @DoctorId" +
            " AND date = @AppointmentDate;";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@DoctorId", doctorId);
                    selectCommand.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
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