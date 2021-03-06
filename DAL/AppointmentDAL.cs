using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Data.SqlClient;
using System.Data;

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
        /// It updates an appointment in the data base.
        /// </summary>
        /// <param name="existingAppointment">The existing appoinment.</param>
        /// <param name="newAppointment">The appointment to be updated.</param>
        /// <returns>The number of deleted rows.</returns>
        public int Update(Appointment existingAppointment, Appointment appointmentChanges)
        {
            if (appointmentChanges == null)
            {
                throw new ArgumentNullException("appointmentChanges");
            }
            string updateStatement = "UPDATE Appointments" +
            " SET date = @Date, doctor_id = @DoctorId, reason = @Reason" +
            " WHERE appointment_id = @AppointmentId" +
            " AND date = @ExistingDate" +
            " AND doctor_id = @ExistingDoctorId" +
            " AND reason = @ExistingReason;";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@AppointmentId", appointmentChanges.AppointmentId);
                    updateCommand.Parameters.AddWithValue("@Date", appointmentChanges.Date);
                    updateCommand.Parameters.AddWithValue("@DoctorId", appointmentChanges.DoctorId);
                    updateCommand.Parameters.AddWithValue("@Reason", appointmentChanges.Reason);
                    
                    updateCommand.Parameters.AddWithValue("@ExistingDate", existingAppointment.Date);
                    updateCommand.Parameters.AddWithValue("@ExistingDoctorId", existingAppointment.DoctorId);
                    updateCommand.Parameters.AddWithValue("@ExistingReason", existingAppointment.Reason);
                    return updateCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// It deletes an appointment from the data base.
        /// </summary>
        /// <param name="appointmentId">The appointment id to be deleted.</param>
        /// <returns>The number of deleted rows.</returns>
        public int Delete(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointmentId must not be negative.");
            }
            string updateStatement = "DELETE Appointments" +
            " WHERE appointment_id = @AppointmentId;";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    return updateCommand.ExecuteNonQuery();
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

        /// <summary>
        /// It verifies if an appoinment exists for the same patient and date.
        /// </summary>
        /// <param name="patientId">The appointment's patientId.</param>
        /// <param name="appointmentDate">The appointment's date time.</param>
        /// <returns>True if exists. False otherwise.</returns>
        public bool ExistsForPatientAndDate(int patientId, DateTime appointmentDate)
        {
            if (patientId < 0)
            {
                throw new ArgumentException("patientId must not be negative.");
            }
            if (appointmentDate == null)
            {
                throw new ArgumentNullException("appointmentDate");
            }
            string selectStatement =
            " SELECT appointment_id" +
            " FROM Appointments" +
            " WHERE patient_id = @PatientId" +
            " AND date = @AppointmentDate;";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientId", patientId);
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

        /// <summary>
        /// It searches appointments by the patient's id.
        /// </summary>
        /// <param name="patientId">The patients's id.</param>
        /// <returns>The list of found appointments.</returns>
        public List<AppointmentSearchResult> GetAppointmentsByPatientId(int patientId)
        {
            if (patientId < 0)
            {
                throw new ArgumentException("The patientId must not be negative");
            }
   
            string selectStatement =
            " SELECT a.appointment_id, a.date, a.reason, d.doctor_id, cpd.first_name AS doctor_first_name, " +
            " cpd.last_name AS doctor_last_name, cpd.phone_number AS doctor_phone_number, p.patient_id, cp.first_name, cp.last_name, cp.date_of_birth, cp.street1," +
            " cp.street2, cp.city, cp.state, cp.ssn" +
            " FROM Appointments a" +
            " INNER JOIN Patients p ON (a.patient_id = p.patient_id)" +
            " INNER JOIN Doctors d ON (a.doctor_id = d.doctor_id)" +
            " INNER JOIN ClinicPersons cp ON (p.clinic_person_id = cp.clinic_person_id)" +
            " INNER JOIN ClinicPersons cpd ON (d.clinic_person_id = cpd.clinic_person_id)" +
            " WHERE p.patient_id=@PatientId;";

            List<AppointmentSearchResult> AppointmentSearchResults = new List<AppointmentSearchResult>();
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientId", patientId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient()
                            {
                                PatientId = Int32.Parse(reader["patient_id"].ToString()),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                                Street1 = reader["street1"].ToString(),
                                Street2 = reader["street2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                SSN = reader["ssn"].ToString(),
                            };
                            Doctor doctor = new Doctor()
                            {
                                DoctorId = Int32.Parse(reader["doctor_id"].ToString()),
                                FirstName = reader["doctor_first_name"].ToString(),
                                LastName = reader["doctor_last_name"].ToString(),
                                Phone = reader["doctor_phone_number"].ToString(),
                            };
                            Appointment appointment = new Appointment()
                            {
                                AppointmentId = Int32.Parse(reader["appointment_id"].ToString()),
                                PatientId = Int32.Parse(reader["patient_id"].ToString()),
                                Patient = patient,
                                Date = DateTime.Parse(reader["date"].ToString()),
                                DoctorId = Int32.Parse(reader["doctor_id"].ToString()),
                                Doctor = doctor,
                                Reason = reader["reason"].ToString(),
                            };
                            AppointmentSearchResults.Add(new AppointmentSearchResult(appointment));
                        }
                    }
                }
            }
            return AppointmentSearchResults;
        }

        /// <summary>
        /// It returns an appointment by its ID.
        /// </summary>
        /// <param name="appointmentID">The ID of the appoinment to be retrieved.</param>
        /// <returns>The found appoinment.</returns>
        public Appointment GetAppointmentByAppointmentId(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointmentId must not be negative");
            }
            Appointment appointment = new Appointment();

            string selectStatement =
            " SELECT a.appointment_id, a.date, a.reason, d.doctor_id, cpd.first_name AS doctor_first_name, " +
            " cpd.last_name AS doctor_last_name, cpd.phone_number AS doctor_phone_number, p.patient_id, cp.first_name, cp.last_name, cp.date_of_birth, cp.street1," +
            " cp.street2, cp.city, cp.state, cp.ssn" +
            " FROM Appointments a" +
            " INNER JOIN Patients p ON (a.patient_id = p.patient_id)" +
            " INNER JOIN Doctors d ON (a.doctor_id = d.doctor_id)" +
            " INNER JOIN ClinicPersons cp ON (p.clinic_person_id = cp.clinic_person_id)" +
            " INNER JOIN ClinicPersons cpd ON (d.clinic_person_id = cpd.clinic_person_id)" +
            " WHERE a.appointment_id=@AppointmentId;";
            
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient()
                            {
                                PatientId = Int32.Parse(reader["patient_id"].ToString()),
                                FirstName = reader["first_name"].ToString(),
                                LastName = reader["last_name"].ToString(),
                                DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                                Street1 = reader["street1"].ToString(),
                                Street2 = reader["street2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                SSN = reader["ssn"].ToString(),
                            };
                            Doctor doctor = new Doctor()
                            {
                                DoctorId = Int32.Parse(reader["doctor_id"].ToString()),
                                FirstName = reader["doctor_first_name"].ToString(),
                                LastName = reader["doctor_last_name"].ToString(),
                                Phone = reader["doctor_phone_number"].ToString(),
                            };

                            appointment.AppointmentId = Int32.Parse(reader["appointment_id"].ToString());
                            appointment.PatientId = Int32.Parse(reader["patient_id"].ToString());
                            appointment.Patient = patient;
                            appointment.Date = DateTime.Parse(reader["date"].ToString());
                            appointment.DoctorId = Int32.Parse(reader["doctor_id"].ToString());
                            appointment.Doctor = doctor;
                            appointment.Reason = reader["reason"].ToString();                    
                        }
                    }
                }
            }
            return appointment;
        }
    }
}