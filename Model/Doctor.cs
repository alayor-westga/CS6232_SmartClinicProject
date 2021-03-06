using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    /// <summary>
    /// The Doctor model class.
    /// </summary>
    public class Doctor : ClinicPerson
    {
        /// <summary>
        /// The Id of the Doctor.
        /// </summary>
        public int DoctorId { get; set; }
    }
}
