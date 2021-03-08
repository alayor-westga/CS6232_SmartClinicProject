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

        public List<Patient> SearchPatients(string firstName, string lastName, DateTime? dateOfBirth)
        {
            if (String.IsNullOrWhiteSpace(firstName) &&
                String.IsNullOrWhiteSpace(lastName) &&
                dateOfBirth == null)
            {
                throw new ArgumentException("At least one parameter must be neither null nor empty.");
            }
            return patientSource.SearchPatients(firstName, lastName, dateOfBirth);
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