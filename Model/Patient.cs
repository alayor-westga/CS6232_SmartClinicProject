using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    /// <summary>
    /// The Patient model class.
    /// </summary>
    public class Patient : ClinicPerson
    {
        /// <summary>
        /// The Id of the Patient.
        /// </summary>
        public int PatientId { get; set; }
    }
}
