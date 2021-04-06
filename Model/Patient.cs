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

        public Patient() {}
    
        /// <summary>
        /// It creates a new patient cloning the info from the clinic person.
        /// </summary>
        /// <param name="patientId">The id of the new patient.</param>
        /// <param name="clinicPerson">The clinc info of the new patient.</param>
        public Patient(int patientId, ClinicPerson clinicPerson)
        {
            PatientId = patientId;
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
