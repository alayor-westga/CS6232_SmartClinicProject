using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    public class PatientVisits
    {
        /// <summary>
        /// The appointmentID for the patien visit
        /// </summary>
        public int AppointmentID { get; set; }

        /// <summary>
        /// The PatienID associated with the patient visit
        /// </summary>
        public int PatientID { get; set; }

        /// <summary>
        /// The Patient name associated with the patient visit
        /// </summary>
        public string Patient { get; set; }

        /// <summary>
        /// the date of birth associated with the patient visit
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// the reason associated with the patient visit
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// The nurse associated with the patient visit
        /// </summary>
        public string Nurse { get; set; }

        /// <summary>
        /// The nurseID associated with the patient visit
        /// </summary>
        public int NurseID { get; set; }

        /// <summary>
        /// The DoctorID associated with the patient visit
        /// </summary>
        public int DoctorID { get; set; }

        /// <summary>
        /// The doctor associated with the patient visit
        /// </summary>
        public string Doctor { get; set; }

        /// <summary>
        /// The PatientPhone associated with the patient visit
        /// </summary>
        public string PatientPhone { get; set; }

        /// <summary>
        /// The visitDate associated with the patient visit
        /// </summary>
        public DateTime VisitDate { get; set; }

        /// <summary>
        /// The weight associated with the patient visit
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// The systolicBP associated with the patient visit
        /// </summary>
        public int SystolicBP { get; set; }

        /// <summary>
        /// The diastolicBP associated with the patient visit
        /// </summary>
        public int DiastolicBP { get; set; }

        /// <summary>
        /// The bodyTemp associated with the patient visit
        /// </summary>
        public decimal BodyTemperature { get; set; }

        /// <summary>
        /// The pulse associated with the patient visit
        /// </summary>
        public int Pulse { get; set; }

        /// <summary>
        /// The symptoms associated with the patient visit
        /// </summary>
        public string Symptoms { get; set; }

        /// <summary>
        /// The initial diagnosis associated with the patient visit
        /// </summary>
        public string InitialDiagnosis { get; set; }

        /// <summary>
        /// The final diagnosis associated with the patient visit
        /// </summary>
        public string FinalDiagnosis { get; set; }
    }
}
