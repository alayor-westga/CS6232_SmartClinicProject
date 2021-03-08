using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    class PatientVisits
    {
        public int AppointmentID { get; set; }
        public int NurseID { get; set; }
        public DateTime Date { get; set; }
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
