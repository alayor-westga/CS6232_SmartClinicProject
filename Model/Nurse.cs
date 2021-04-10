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
        /// The user name of the nurse.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// It determines if the nurse has set their system access credentials.
        /// </summary>
        public bool HasCredentialsSet { get; set; }
    }
}
