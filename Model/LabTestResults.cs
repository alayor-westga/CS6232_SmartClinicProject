﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    class LabTestResults
    {
        /// <summary>
        /// AppointmentID for LabTestResults
        /// </summary>
        public int AppointmentID { get; set; }
       
        /// <summary>
        /// LabTestCode for LabTestResults
        /// </summary>
        public int LabTestCode { get; set; }

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
