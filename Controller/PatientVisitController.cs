using System;
using System.Collections.Generic;
using SmartClinic.DAL;
using SmartClinic.Model;

namespace SmartClinic.Controller
{
    /// <summary>
    /// Author: Mike Hamel
    /// Date: 3-17-21
    /// 
    /// Middleware between the AppointmentDAL and the View.
    /// </summary>
    public class PatientVisitController
    {
        private readonly VisitDAL visitSource;

        /// <summary>
        /// It creates a AppointmentController object.
        /// </summary>
        public PatientVisitController()
        {
            this.visitSource = new VisitDAL();
        }

        /// <summary>
        /// Gets all PatientVisits associated with the given patientID
        /// </summary>
        /// <param name="patientId">patientID</param>
        /// <returns>List of PatientVisits</returns>
        public List<PatientVisits> GetPatientVisitsByPatientId(int patientId)
        {
            if (patientId < 0)
            {
                throw new ArgumentException("The patientId must not be negative");
            }
            return this.visitSource.GetPatientVisitsByPatientId(patientId);
        }

        /// <summary>
        /// Gets the PatientVisit by it primary key, appointmentID
        /// </summary>
        /// <param name="appointmentID">appointmentID</param>
        /// <returns>a PatientVisits object</returns>
        public PatientVisits GetPatientVisitByAppointmentID(int appointmentID)
        {
            if (appointmentID < 0)
            {
                throw new ArgumentException("The appointmentID must not be negative");
            }
            return this.visitSource.GetPatientVisitByAppointmentID(appointmentID);
        }

        /// <summary>
        /// Updates a PatientVisit, providing the object hasn't changed in the db since retrieved
        /// by the user
        /// </summary>
        /// <param name="oldVisit">the original PatientVisit retrieved by the user</param>
        /// <param name="newVisit">the new PatientVisit information to be appended to the db</param>
        /// <returns></returns>
        public bool UpdatePatientVisitInformation(PatientVisits oldVisit, PatientVisits newVisit)
        {
            if (oldVisit == null)
            {
                throw new ArgumentNullException("oldVisit");
            }
            if (newVisit == null)
            {
                throw new ArgumentNullException("newVisit");
            }
            return this.visitSource.UpdatePatientVisitInformation(oldVisit, newVisit);
        }

        /// <summary>
        /// Checks if the given Appointment has an associated PatientVisit
        /// </summary>
        /// <param name="appointmentID">appointmentID</param>
        /// <returns>true if no associated PatientVisit with Appointment, false otherwise</returns>
        public bool AppointmentHasNoAssociatedVisit(int appointmentID)
        {
            if (appointmentID < 0)
            {
                throw new ArgumentException("The appointmentID must not be negative");
            }
            return this.visitSource.AppointmentHasNoAssociatedVisit(appointmentID);
        }

        /// <summary>
        /// Retrieves the required AppointmentInformation to create a new PatientVisit
        /// and populate a UI form
        /// </summary>
        /// <param name="appointmentId">appointmentID</param>
        /// <returns>a PatientVisits object</returns>
        public PatientVisits GetInfoToCreatNewPatientVisit(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointmentId must not be negative");
            }
            return this.visitSource.GetInfoToCreatNewPatientVisit(appointmentId);
        }

        /// <summary>
        /// Adds a PatientVisit to the db
        /// </summary>
        /// <param name="patientVisit">patientID</param>
        public void AddPatientVisit(PatientVisits patientVisit)
        {
            if (patientVisit == null)
            {
                throw new ArgumentNullException("patientVisit");
            }
            this.visitSource.AddPatientVisit(patientVisit);
        }
    }
}