using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    public class LabTestResults
    {
        /// <summary>
        /// AppointmentID for LabTestResults
        /// </summary>
        public int AppointmentID { get; set; }
       
        /// <summary>
        /// LabTestCode for LabTestResults
        /// </summary>
        public string LabTestCode { get; set; }

        /// <summary>
        /// LabTestName for LabTestResults
        /// </summary>
        public string LabTestName { get; set; }
        /// <summary>
        /// DatePerformed for LabTestResults
        /// </summary>
        public DateTime DatePerformed { get; set; }

        /// <summary>
        /// Result for LabTestResults
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// IsNormal for LabTestResults
        /// </summary>
        public bool IsNormal { get; set; }

    }
}
