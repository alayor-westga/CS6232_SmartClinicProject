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
    /// 
    /// Author: Mike Hamel
    /// Author: Alonso Ortega
    /// Date: 3-17-21
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

        /// <summary>
        /// Adds a new Patient Visit to the Visit table
        /// </summary>
        /// <param name="newPatientVisit">a PatientVisits object</param>
        public void AddPatientVisit(PatientVisits newPatientVisit)
        {
            string insertStatement =
          "INSERT Visits " +
            "(appointment_id, nurse_id, weight, systolic_bp, diastolic_bp, body_temp, pulse, symptoms, initial_diagnosis, final_diagnosis) " +
          "VALUES (@AppointmentID, @NurseID, @Weight, @SystolicBP, @DiastolicBP, @BodyTemp, @Pulse, @Symptoms, @InitialDiagnosis, @FinalDiagnosis)";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@AppointmentID", newPatientVisit.AppointmentID);
                    insertCommand.Parameters.AddWithValue("@NurseID", newPatientVisit.NurseID);
                    insertCommand.Parameters.AddWithValue("@Weight", newPatientVisit.Weight);
                    insertCommand.Parameters.AddWithValue("@SystolicBP", newPatientVisit.SystolicBP);
                    insertCommand.Parameters.AddWithValue("@DiastolicBP", newPatientVisit.DiastolicBP);
                    insertCommand.Parameters.AddWithValue("@BodyTemp", newPatientVisit.BodyTemperature);
                    insertCommand.Parameters.AddWithValue("@Pulse", newPatientVisit.Pulse);
                    insertCommand.Parameters.AddWithValue("@Symptoms", newPatientVisit.Symptoms);
                    insertCommand.Parameters.AddWithValue("@InitialDiagnosis", newPatientVisit.InitialDiagnosis);
                    insertCommand.Parameters.AddWithValue("@FinalDiagnosis", newPatientVisit.FinalDiagnosis);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Retrieves the required information from the Appointments table to create a 
        /// new Patient Visit
        /// </summary>
        /// <param name="appointmentId">appointmentID from an existing Appointment</param>
        /// <returns>a new PatientVisits object</returns>
        public PatientVisits GetInfoToCreatNewPatientVisit(int appointmentId)
        {

            PatientVisits newPatientVisit = new PatientVisits();
            string selectStatement =

                "SELECT p.patient_id, a.appointment_id, cpp.first_name + ' ' + cpp.last_name as 'Patient', cpp.date_of_birth, " +
                    "cpd.first_name + ' ' + cpd.last_name as 'Doctor', d.doctor_id, cpd.phone_number, a.date " +
                "FROM Appointments a " +
                    "JOIN Patients p on a.patient_id = p.patient_id " +
                    "JOIN Doctors d on d.doctor_id = a.doctor_id " +
                    "JOIN ClinicPersons cpp on cpp.clinic_person_id = p.clinic_person_id " +
                    "JOIN ClinicPersons cpd on cpd.clinic_person_id = d.clinic_person_id " +
                "WHERE a.appointment_id = @AppointmentID";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentID", appointmentId);

                    using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))

                    {
                        while (reader.Read())
                        {
                            newPatientVisit.AppointmentID = Int32.Parse(reader["appointment_id"].ToString());
                            newPatientVisit.PatientID = Int32.Parse(reader["patient_id"].ToString());
                            newPatientVisit.Patient = reader["Patient"].ToString();
                            newPatientVisit.DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString());
                            newPatientVisit.Doctor = reader["Doctor"].ToString();
                            newPatientVisit.DoctorID = Int32.Parse(reader["doctor_id"].ToString());
                            newPatientVisit.DoctorPhone = reader["phone_number"].ToString();                          
                            newPatientVisit.VisitDate= DateTime.Parse(reader["date"].ToString());                          
                        }
                    }
                }
                return newPatientVisit;
            }
        }

        /// <summary>
        /// Updates an existing PatientVisit
        /// </summary>
        /// <param name="oldVisit">the original PatientVisit pulled from the db</param>
        /// <param name="newVisit">the updated PatientVisit information the user entered, to be
        /// appended to the db</param>
        /// <returns>true if the update was successful, false otherwise; a false return means
        /// the information in the db has changed since it was retrieved by the user now 
        /// trying to append it</returns>
        public bool UpdatePatientVisitInformation(PatientVisits oldVisit, PatientVisits newVisit)
        {
            string updateStatement =
               "UPDATE Visits SET " +
                    "nurse_id = @NewNurseID, " +
                    "weight = @NewWeight, " +
                    "systolic_bp = @NewSystolicBP, " +
                    "diastolic_bp = @NewDiastolicBP, " +
                    "body_temp = @NewBodyTemp, " +
                    "pulse = @NewPulse, " +
                    "symptoms = @NewSymptoms, " +
                    "initial_diagnosis = @NewInitialDiagnosis, " +
                    "final_diagnosis = @NewFinalDiagnosis " +
                "WHERE appointment_id = @OldAppointmentID " +
                    "AND nurse_id = @OldNurseID " +
                    "AND weight = @OldWeight " +
                    "AND systolic_bp = @OldSystolicBP " +
                    "AND diastolic_bp = @OldDiastolicBP " +
                    "AND body_temp = @OldBodyTemp " +
                    "AND pulse = @OldPulse " +
                    "AND symptoms = @OldSymptoms " +
                    "AND initial_diagnosis = @OldInitialDiagnosis ";
            updateStatement += oldVisit.FinalDiagnosis == null ? "AND final_diagnosis IS NULL;" : "AND final_diagnosis = @OldFinalDiagnosis;";

            using (SqlConnection connection = SmartClinicDBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@NewNurseID", newVisit.NurseID);
                    updateCommand.Parameters.AddWithValue("@NewWeight", newVisit.Weight);
                    updateCommand.Parameters.AddWithValue("@NewSystolicBP", newVisit.SystolicBP);
                    updateCommand.Parameters.AddWithValue("@NewDiastolicBP", newVisit.DiastolicBP);
                    updateCommand.Parameters.AddWithValue("@NewBodyTemp", newVisit.BodyTemperature);
                    updateCommand.Parameters.AddWithValue("@NewPulse", newVisit.Pulse);
                    updateCommand.Parameters.AddWithValue("@NewSymptoms", newVisit.Symptoms);
                    updateCommand.Parameters.AddWithValue("@NewInitialDiagnosis", newVisit.InitialDiagnosis);
                    updateCommand.Parameters.AddWithValue("@NewFinalDiagnosis", newVisit.FinalDiagnosis);

                    updateCommand.Parameters.AddWithValue("@OldAppointmentID", oldVisit.AppointmentID);
                    updateCommand.Parameters.AddWithValue("@OldNurseID", oldVisit.NurseID);
                    updateCommand.Parameters.AddWithValue("@OldWeight", oldVisit.Weight);
                    updateCommand.Parameters.AddWithValue("@OldSystolicBP", oldVisit.SystolicBP);
                    updateCommand.Parameters.AddWithValue("@OldDiastolicBP", oldVisit.DiastolicBP);
                    updateCommand.Parameters.AddWithValue("@OldBodyTemp", oldVisit.BodyTemperature);
                    updateCommand.Parameters.AddWithValue("@OldPulse", oldVisit.Pulse);
                    updateCommand.Parameters.AddWithValue("@OldSymptoms", oldVisit.Symptoms);
                    updateCommand.Parameters.AddWithValue("@OldInitialDiagnosis", oldVisit.InitialDiagnosis);
                    if (oldVisit.FinalDiagnosis != null) 
                    {
                        updateCommand.Parameters.AddWithValue("@OldFinalDiagnosis", oldVisit.FinalDiagnosis);
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
        /// Will return a PatientVisit object based on the given appointmentID (primary key)
        /// </summary>
        /// <param name="appointmentID">appointmentID</param>
        /// <returns>a PatientVisit object</returns>
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
            "WHERE v.appointment_id = @AppointmentID";

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
                            patientVisit.AppointmentID = int.Parse(reader["appointment_id"].ToString());
                            patientVisit.PatientID = int.Parse(reader["patient_id"].ToString());
                            patientVisit.Patient = reader["Patient"].ToString();
                            patientVisit.DateOfBirth = DateTime.Parse(reader["date_of_birth"].ToString());
                            patientVisit.Doctor = reader["Doctor"].ToString();
                            patientVisit.DoctorID = int.Parse(reader["doctor_id"].ToString());
                            patientVisit.DoctorPhone = reader["phone_number"].ToString();
                            patientVisit.Nurse = reader["Nurse"].ToString();
                            patientVisit.NurseID = int.Parse(reader["nurse_id"].ToString());
                            patientVisit.VisitDate = DateTime.Parse(reader["date"].ToString());
                            patientVisit.Weight = reader.GetDecimal(reader.GetOrdinal("weight"));
                            patientVisit.SystolicBP = int.Parse(reader["systolic_bp"].ToString());
                            patientVisit.DiastolicBP = int.Parse(reader["diastolic_bp"].ToString());
                            patientVisit.BodyTemperature = reader.GetDecimal(reader.GetOrdinal("body_temp"));
                            patientVisit.Pulse = int.Parse(reader["pulse"].ToString());
                            patientVisit.Symptoms = reader["symptoms"].ToString();
                            patientVisit.Reason = reader["reason"].ToString();
                            patientVisit.InitialDiagnosis = reader["initial_diagnosis"].ToString();
                            patientVisit.FinalDiagnosis = reader["final_diagnosis"] == DBNull.Value ? null : (string) reader["final_diagnosis"];
                        }
                    }
                }
                return patientVisit;
            }
        }

        /// <summary>
        /// Retrieves all PatientVisits that are associated with a patientID - may be 0 to many
        /// </summary>
        /// <param name="patientID">patientID</param>
        /// <returns>List of PatientVisit objects</returns>
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

        /// <summary>
        /// Will check if there is a PatientVisit associated with the given appointmentID
        /// </summary>
        /// <param name="appointmentID">appointmentID</param>
        /// <returns>true if there is an associated PatientVisit with an Appointment, false otherwise </returns>
        public bool AppointmentHasNoAssociatedVisit(int appointmentID)
        {
            string selectStatement =

                "SELECT count(*) FROM Visits WHERE appointment_id = @AppointmentID";

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