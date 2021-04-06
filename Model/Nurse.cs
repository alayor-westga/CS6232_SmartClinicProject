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

         public Nurse() {}
    
        /// <summary>
        /// It creates a new nurse cloning the info from the clinic person.
        /// </summary>
        /// <param name="nurseId">The id of the new nurse.</param>
        /// <param name="clinicPerson">The clinc info of the new nurse.</param>
        public Nurse(int nurseId, ClinicPerson clinicPerson)
        {
            nurseId = nurseId;
            DateOfBirth = clinicPerson.DateOfBirth;
            Gender = clinicPerson.Gender;
            FirstName = clinicPerson.FirstName;
            LastName = clinicPerson.LastName;
            Street1 = clinicPerson.Street1;
            Street2 = clinicPerson.Street2;
            City = clinicPerson.City;
            State = clinicPerson.State;
            ZipCode = clinicPerson.ZipCode;
            Phone = clinicPerson.Phone;
            SSN = clinicPerson.SSN;
        }
    }
}
