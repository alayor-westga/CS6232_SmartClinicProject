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

        public List<PatientVisits> GetPatientVisitsByPatientId(int patientID)
        {

            string selectStatement =
            "SELECT p.patient_id, a.appointment_id, cpp.first_name + ' ' + cpp.last_name as 'Patient', p.date_of_birth " +
            "cpd.first_name + ' ' + cpd.last_name as 'Doctor', d.doctor_id, d.phone_number, n.first_name + ' ' + n.last_name as 'Nurse' " +
            "n.nurse_id, a.date, weight, systolic_bp, diastolic_by, body_temp, pulse, symptoms, reason, initial_diagnosis, final_diagnosis " +

            "FROM Appointments a " +
            "JOIN Visits v on a.appointment_id = v.appointment_id " +
            "JOIN Patients p on a.patient_id = p.patient_id " +
            "JOIN Doctors d on d.doctor_id = a.doctor_id " +
            "JOIN Nurses n on n.nurse_id = v.nurse_id " +
            "JOIN ClinicPersons cpp on cpp.clinic_person_id = p.clinic_person_id " +
            "JOIN ClinicPersons cpd on cpd.clinic_person_id = d.clinic_person_id " +
            "JOIN ClinicPersons cpn on cpn.clinic_person_id = n.clinic_person_id " +
            "WHERE p.patient_id = @PatientID";

            return SelectManyPatientVisits(selectStatement, new Hashtable()
                {
                    {"@PatientID", patientID}
                }
            );
        }

        internal List<PatientVisits> SelectManyPatientVisits(string selectStatement, Hashtable parameters = null)
        {
            List<PatientVisits> patientVisitList = new List<PatientVisits>();
            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (parameters != null)
                    {
                        foreach (DictionaryEntry param in parameters)
                        {
                            selectCommand.Parameters.AddWithValue((String)param.Key, param.Value);
                        }
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PatientVisits patientVisit = new PatientVisits()
                            {
                                AppointmentID = Int32.Parse(reader["appointment_id"].ToString()),
                                PatientID = Int32.Parse(reader["patient_id"].ToString()),
                                Patient = reader["Patient"].ToString(),
                                DateOfBirth = DateTime.Parse(reader["p.date_of_birth"].ToString()),
                                Doctor = reader["Doctor"].ToString(),
                                DoctorPhone = reader["d.phone_number"].ToString(),
                                DoctorID = Int32.Parse(reader["doctor_id"].ToString()),
                                Nurse = reader["Nurse"].ToString(),
                                NurseID = Int32.Parse(reader["doctor_id"].ToString()),
                                VisitDate = DateTime.Parse(reader["a.date"].ToString()),
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
    }
}