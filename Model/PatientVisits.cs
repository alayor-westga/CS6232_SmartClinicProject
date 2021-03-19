using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    public class PatientVisits
    {
        //TODO: Add XML Comments
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public string Patient { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Reason { get; set; }
        public string Nurse { get; set; }
        public int NurseID { get; set; }
        public int DoctorID { get; set; }
        public string Doctor { get; set; }
        public string DoctorPhone { get; set; }
        public DateTime VisitDate { get; set; }
        public decimal Weight { get; set; }
        public int SystolicBP { get; set; }
        public int DiastolicBP { get; set; }
        public decimal BodyTemperature { get; set; }
        public int Pulse { get; set; }
        public string Symptoms { get; set; }
        public string InitialDiagnosis { get; set; }
        public string FinalDiagnosis { get; set; }
    }
}
