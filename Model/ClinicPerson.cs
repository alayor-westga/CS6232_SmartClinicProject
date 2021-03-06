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

        /// <summary>
        /// The date of birth of the clinic person.
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        
        /// <summary>
        /// The gender of the clinic person.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// The street 1 of the clinic person.
        /// </summary>
        public string Street1 { get; set; }

        /// <summary>
        /// The street 2 of the clinic person.
        /// </summary>
        public string Street2 { get; set; }
        
        /// <summary>
        /// The city of the clinic person.
        /// </summary>
        public string City { get; set; }
        
        /// <summary>
        /// The state of the clinic person.
        /// </summary>
        public string State { get; set; }
        
        /// <summary>
        /// The zip code of the clinic person.
        /// </summary>
        public string ZipCode { get; set; }
        
        /// <summary>
        /// The phone of the clinic person.
        /// </summary>
        public string Phone { get; set; }
    }
}
