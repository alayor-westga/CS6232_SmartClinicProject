using System;
using System.Collections.Generic;
using SmartClinic.DAL;
using SmartClinic.Model;

namespace SmartClinic.Controller
{
    /// <summary>
    /// Middleware between the PatientDAL and the View.
    /// </summary>
    public class PatientController
    {
        private readonly PatientDAL patientSource;

        /// <summary>
        /// It creates a PatientController object.
        /// </summary>
        public PatientController()
        {
            patientSource = new PatientDAL();
        }

        internal ClinicPerson GetClinicPerson(int patientID)
        {
            return this.patientSource.GetClinicPerson(patientID);
        }

        /// <summary>
        /// It searches patients by their date of birth.
        /// </summary>
        /// <param name="dateOfBirth">The patients's date of birth.</param>
        /// <returns>The list of found patients.</returns>
        public List<Patient> SearchByDOB(DateTime dateOfBirth)
        {
            if (dateOfBirth == null)
            {
                throw new ArgumentNullException("dateOfBirth");
            }
            return patientSource.SearchByDOB(dateOfBirth);
        }

         /// <summary>
        /// It searches patients by their names.
        /// </summary>
        /// <param name="firstName">The patients's first name.</param>
        /// <param name="lastName">The patients's last name.</param>
        /// <returns>The list of found patients.</returns>
        public List<Patient> SearchByName(string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Please enter a name to search.");
            }
            return patientSource.SearchByName(firstName, lastName);
        }

        /// <summary>
        /// It searches patients by their date of birth and last name.
        /// </summary>
        /// <param name="dateOfBirth">The patients's date of birth.</param>
        /// <param name="lastName">The patients's last name.</param>
        /// <returns>The list of found patients.</returns>
        public List<Patient> SearchByDOBAndLastName(DateTime dateOfBirth, string lastName)
        {
            if (dateOfBirth == null)
            {
                throw new ArgumentNullException("dateOfBirth");
            }
            return patientSource.SearchByDOBAndLastName(dateOfBirth, lastName);
        }

        public bool PatientHasNoAppointments(int patientID)
        {
            return this.patientSource.PatientHasNoAppointments(patientID);
        }

        public bool PatientIsNotADoctor(int patientID)
        {
            return this.patientSource.PatientIsNotADoctor(patientID);
        }

        public int AddClinicPerson(ClinicPerson newPatient)
        {
            if (newPatient == null)
            {
                throw new ArgumentNullException("ClinicPerson object cannot be null");
            }
            return this.patientSource.AddClinicPerson(newPatient);
        }

        public void DeletePatient(int patientID)
        {
            this.patientSource.DeletePatient(patientID);
        }

        internal int AddPatient(int clinicPersonID)
        {
            return this.patientSource.AddPatient(clinicPersonID);
        }

        internal bool UpdatePatientInformation(ClinicPerson oldPatient, ClinicPerson newPatient)
        {
            return this.patientSource.UpdatePatientInformation(oldPatient, newPatient);
        }
    }
}