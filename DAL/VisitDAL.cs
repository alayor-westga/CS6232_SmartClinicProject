using System;
using System.Collections.Generic;
using SmartClinic.Model;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

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

        internal bool UpdatePatientVisitInformation(PatientVisits oldVisit, PatientVisits newVisit)
        {
            throw new NotImplementedException();
        }

        internal PatientVisits GetPatientVisitByAppointmentID(int appointmentID)
        {
            PatientVisits patientVisit = new PatientVisits();
            string selectStatement =

            "SELECT p.patient_id, a.appointment_id, cpp.first_name + ' ' + cpp.last_name as 'Patient', cpp.date_of_birth, " +
            "cpd.first_name + ' ' + cpd.last_name as 'Doctor', d.doctor_id, cpd.phone_number, cpn.first_name + ' ' + cpn.last_name as 'Nurse', " +
            "n.nurse_id, a.date, weight, systolic_bp, diastolic_bp, body_temp, pulse, symptoms, reason, initial_diagnosis, final_diagnosis " +

            "FROM Appointments a " +
            "JOIN Visits v on a.appointment_id = v.appointment_id " +
            "JOIN Patients p on a.patient_id = p.patient_id " +
            "JOIN Doctors d on d.doctor_id = a.doctor_id " +
            "JOIN Nurses n on n.nurse_id = v.nurse_id " +
            "JOIN ClinicPersons cpp on cpp.clinic_person_id = p.clinic_person_id " +
            "JOIN ClinicPersons cpd on cpd.clinic_person_id = d.clinic_person_id " +
            "JOIN ClinicPersons cpn on cpn.clinic_person_id = n.clinic_person_id " +
            "WHERE a.appointment_id = @AppointmentID";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentID", appointmentID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))

                    {
                        while (reader.Read())
                        {
                            patientVisit.AppointmentID = Int32.Parse(reader["appointment_id"].ToString());
                            patientVisit.PatientID = Int32.Parse(reader["patient_id"].ToString());
                            patientVisit.Patient = reader["Patient"].ToString();
                            patientVisit.DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString());
                            patientVisit.Doctor = reader["Doctor"].ToString();
                            patientVisit.DoctorID = Int32.Parse(reader["doctor_id"].ToString());
                            patientVisit.DoctorPhone = reader["phone_number"].ToString();
                            patientVisit.Nurse = reader["Nurse"].ToString();
                            patientVisit.NurseID = Int32.Parse(reader["nurse_id"].ToString());
                            patientVisit.VisitDate = DateTime.Parse(reader["date"].ToString());
                            patientVisit.Weight = reader.GetDecimal(reader.GetOrdinal("weight"));
                            patientVisit.SystolicBP = Int32.Parse(reader["systolic_bp"].ToString());
                            patientVisit.DiastolicBP = Int32.Parse(reader["diastolic_bp"].ToString());
                            patientVisit.BodyTemperature = reader.GetDecimal(reader.GetOrdinal("body_temp"));
                            patientVisit.Pulse = Int32.Parse(reader["pulse"].ToString());
                            patientVisit.Symptoms = reader["symptoms"].ToString();
                            patientVisit.Reason = reader["reason"].ToString();
                            patientVisit.InitialDiagnosis = reader["initial_diagnosis"].ToString();
                            patientVisit.FinalDiagnosis = reader["final_diagnosis"].ToString();
                        }
                    }
                }
                return patientVisit;
            }
        }

        public List<PatientVisits> GetPatientVisitsByPatientId(int patientID)
        {

            string selectStatement =
            "SELECT p.patient_id, a.appointment_id, cpp.first_name + ' ' + cpp.last_name as 'Patient', cpp.date_of_birth, " +
            "cpd.first_name + ' ' + cpd.last_name as 'Doctor', d.doctor_id, cpd.phone_number, cpn.first_name + ' ' + cpn.last_name as 'Nurse', " +
            "n.nurse_id, a.date, weight, systolic_bp, diastolic_bp, body_temp, pulse, symptoms, reason, initial_diagnosis, final_diagnosis " +

            "FROM Appointments a " +
            "JOIN Visits v on a.appointment_id = v.appointment_id " +
            "JOIN Patients p on a.patient_id = p.patient_id " +
            "JOIN Doctors d on d.doctor_id = a.doctor_id " +
            "JOIN Nurses n on n.nurse_id = v.nurse_id " +
            "JOIN ClinicPersons cpp on cpp.clinic_person_id = p.clinic_person_id " +
            "JOIN ClinicPersons cpd on cpd.clinic_person_id = d.clinic_person_id " +
            "JOIN ClinicPersons cpn on cpn.clinic_person_id = n.clinic_person_id " +
            "WHERE p.patient_id = @PatientID";

            List<PatientVisits> patientVisitList = new List<PatientVisits>();
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.AddWithValue("@PatientID", patientID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PatientVisits patientVisit = new PatientVisits()
                            {
                                AppointmentID = Int32.Parse(reader["appointment_id"].ToString()),
                                PatientID = Int32.Parse(reader["patient_id"].ToString()),
                                Patient = reader["Patient"].ToString(),
                                DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString()),
                                Doctor = reader["Doctor"].ToString(),
                                DoctorID = Int32.Parse(reader["doctor_id"].ToString()),
                                DoctorPhone = reader["phone_number"].ToString(),
                                Nurse = reader["Nurse"].ToString(),
                                NurseID = Int32.Parse(reader["nurse_id"].ToString()),
                                VisitDate = DateTime.Parse(reader["date"].ToString()),
                                Weight = reader.GetDecimal(reader.GetOrdinal("weight")),
                                SystolicBP = Int32.Parse(reader["systolic_bp"].ToString()),
                                DiastolicBP = Int32.Parse(reader["diastolic_bp"].ToString()),
                                BodyTemperature = reader.GetDecimal(reader.GetOrdinal("body_temp")),
                                Pulse = Int32.Parse(reader["pulse"].ToString()),
                                Symptoms = reader["symptoms"].ToString(),
                                Reason = reader["reason"].ToString(),
                                InitialDiagnosis = reader["initial_diagnosis"].ToString(),
                                FinalDiagnosis = reader["final_diagnosis"].ToString()
                            };
                            patientVisitList.Add(patientVisit);
                        }
                    }
                }
                return patientVisitList;
            }
        }

        public bool AppointmentHasNoAssociatedVisit(int appointmentID)
        {
            string selectStatement =

                "SELECT count(*) FROM Appointments WHERE appointment_id = @AppointmentID";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentID", appointmentID);

                    if ((Int32)selectCommand.ExecuteScalar() == 0)
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