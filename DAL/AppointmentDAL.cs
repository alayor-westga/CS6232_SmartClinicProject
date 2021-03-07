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

        /// <summary>
        /// It searches appointments by the patient's name and date of birth.
        /// </summary>
        /// <param name="firstName">The patients's username.</param>
        /// <param name="lastName">The patients's lastName.</param>
        /// <param name="dateOfBirth">The patients's dateOfBirth.</param>
        /// <returns>The list of found appointments.</returns>
        public List<Appointment> SearchAppointments(string firstName, string lastName, DateTime? dateOfBirth)
        {
            if (String.IsNullOrWhiteSpace(firstName) &&
                String.IsNullOrWhiteSpace(lastName) &&
                dateOfBirth == null)
            {
                throw new ArgumentException("At least one parameter must be neither null nor empty.");
            }
            string selectStatement =
            " SELECT a.appointment_id, a.date, a.reason, d.doctor_id, cpd.first_name AS doctor_first_name, " +
            " cpd.last_name AS doctor_last_name, p.patient_id, cp.first_name, cp.last_name, cp.date_of_birth, cp.street1," +
            " cp.street2, cp.city, cp.state" +
            " FROM Appointments a" +
            " INNER JOIN Patients p ON (a.patient_id = p.patient_id)" +
            " INNER JOIN Doctors d ON (a.doctor_id = d.doctor_id)" +
            " INNER JOIN ClinicPersons cp ON (p.clinic_person_id = cp.clinic_person_id)" +
            " INNER JOIN ClinicPersons cpd ON (d.clinic_person_id = cpd.clinic_person_id)" +
            " WHERE 1=2";
            if (!String.IsNullOrWhiteSpace(firstName))
            {
                selectStatement += " OR cp.first_name LIKE @FirstName";
            }
            if (!String.IsNullOrWhiteSpace(lastName))
            {
                selectStatement += " OR cp.last_name LIKE @LastName";
            }
            if (dateOfBirth != null)
            {
                selectStatement += " OR cp.date_of_birth = @DateOfBirth";
            }
            selectStatement += ";";

            List<Appointment> appointmentList = new List<Appointment>();
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (!String.IsNullOrWhiteSpace(firstName))
                    {
                        selectCommand.Parameters.AddWithValue("@FirstName", '%' + firstName + '%');
                    }
                    if (!String.IsNullOrWhiteSpace(lastName))
                    {
                        selectCommand.Parameters.AddWithValue("@LastName", '%' + lastName + '%');
                    }
                    if (dateOfBirth != null)
                    {
                        selectCommand.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.GetValueOrDefault().Date);
                    }
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
                            };
                            Doctor doctor = new Doctor()
                            {
                                DoctorId = Int32.Parse(reader["doctor_id"].ToString()),
                                FirstName = reader["doctor_first_name"].ToString(),
                                LastName = reader["doctor_last_name"].ToString(),
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
                            appointmentList.Add(appointment);
                        }
                    }
                }
            }
            return appointmentList;
        }
    }
}