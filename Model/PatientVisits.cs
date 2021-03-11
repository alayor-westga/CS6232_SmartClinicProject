using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    class PatientVisits
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public string Patient { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Reason { get; set; }
        public string Nurse { get; set; }
        public string Doctor { get; set; }
        public DateTime VisitDate { get; set; }
        public float Weight { get; set; }
        public int SystolicBP { get; set; }
        public int DiastolicBP { get; set; }
        public float BodyTemperature { get; set; }
        public int Pulse { get; set; }
        public string Symptoms { get; set; }
        public int InitialDiagnosis { get; set; }
        public string FinalDiagnosis { get; set; }
    }
}
