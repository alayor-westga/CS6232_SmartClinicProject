using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    /// <summary>
    /// The Nurse model class.
    /// </summary>
    public class Nurse : ClinicPerson
    {
        /// <summary>
        /// The Id of the nurse.
        /// </summary>
        public int NurseId { get; set; }

        /// <summary>
        /// The User Name of the nurse.
        /// </summary>
        public string UserName { get; set; }
    }
}
