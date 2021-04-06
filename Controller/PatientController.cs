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

        /// <summary>
        /// It retrieves a ClinicPerson by the patient ID.
        /// <param name="patientID">The patient's ID.</param>
        /// <returns>The clinic person info of the patient.</returns>
        /// </summary>
        public ClinicPerson GetClinicPerson(int patientID)
        {
            if (patientID < 0)
            {
                throw new ArgumentException("The patientID must not be negative");
            }
            return patientSource.GetClinicPerson(patientID);
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

        /// <summary>
        /// It evaluates id the patient has no appointments.
        /// </summary>
        /// <param name="patientID">The patients ID to check appointments.</param>
        /// <returns>True if the patient has appointments. False otherwise</returns>
        public bool PatientHasNoAppointments(int patientID)
        {
            if (patientID < 0)
            {
                throw new ArgumentException("The patientID must not be negative");
            }
            return patientSource.PatientHasNoAppointments(patientID);
        }

        /// <summary>
        /// It removes a patient from the DB.
        /// </summary>
        /// <param name="patientID">The patient to be removed.</param>
        public void DeletePatient(int patientID)
        {
            if (patientID < 0)
            {
                throw new ArgumentException("The patientID must not be negative");
            }
            patientSource.DeletePatient(patientID);
        }

        /// <summary>
        /// It adds a patient to the DB.
        /// </summary>
        /// <param name="clinicPersonID">The clinic person id of the patient.</param>
        /// <returns>The number of rows affected.</returns>
        public int AddPatient(int clinicPersonID)
        {
            if (clinicPersonID < 0)
            {
                throw new ArgumentException("The clinicPersonID must not be negative");
            }
            return patientSource.AddPatient(clinicPersonID);
        }

        /// <summary>
        /// It updates a patient in the DB.
        /// </summary>
        /// <param name="oldPatient">The old patient info.</param>
        /// <param name="newPatient">The new patient info.</param>
        /// <returns>True if the update was successful. False otherwise</returns>
        public bool UpdatePatientInformation(ClinicPerson oldPatient, ClinicPerson newPatient)
        {
            if (oldPatient == null)
            {
                throw new ArgumentNullException("oldPatient");
            }
            if (newPatient == null)
            {
                throw new ArgumentNullException("newPatient");
            }
            return patientSource.UpdatePatientInformation(oldPatient, newPatient);
        }
    }
}