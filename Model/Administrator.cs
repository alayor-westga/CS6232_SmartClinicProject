using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    /// <summary>
    /// The Administrator model class.
    /// </summary>
    public class Administrator : ClinicPerson
    {
        /// <summary>
        /// The Id of the administrator.
        /// </summary>
        public int AdministratorId { get; set; }
    }
}
