using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    public class ClinicPerson
    {
        /// <summary>
        /// The first name of the clinic person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the clinic person.
        /// </summary>
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int Phone { get; set; }


    }
}
