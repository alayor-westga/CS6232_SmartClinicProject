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
        /// It searches patients by their name, id, and date of birth.
        /// </summary>
        /// <param name="firstName">The patients's username.</param>
        /// <param name="lastName">The patients's lastName.</param>
        /// <param name="patientId">The patients's patientId.</param>
        /// <param name="dateOfBirth">The patients's dateOfBirth.</param>
        /// <returns>The list of found patients.</returns>
        public List<Patient> SearchPatients(string firstName, string lastName, int patientId, DateTime? dateOfBirth)
        {
            if (String.IsNullOrWhiteSpace(firstName) &&
                String.IsNullOrWhiteSpace(lastName) &&
                patientId <= 0 &&
                dateOfBirth == null)
            {
                throw new ArgumentException("At least one parameter must be neither null nor empty.");
            }
            return patientSource.SearchPatients(firstName, lastName, patientId, dateOfBirth);
        }

        public void addPatient(ClinicPerson newPatient)
        {
            if (newPatient == null)
            {
                throw new ArgumentNullException("ClinicPerson object cannot be null");
            }
            this.patientSource.addPatient(newPatient);
        }
    }
}