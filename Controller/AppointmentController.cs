using System;
using System.Collections.Generic;
using SmartClinic.DAL;
using SmartClinic.Model;

namespace SmartClinic.Controller
{
    /// <summary>
    /// Middleware between the AppointmentDAL and the View.
    /// </summary>
    public class AppointmentController
    {
        private readonly AppointmentDAL appointmentSource;
        private readonly VisitDAL visitSource;

        /// <summary>
        /// It creates a AppointmentController object.
        /// </summary>
        public AppointmentController()
        {
            appointmentSource = new AppointmentDAL();
            visitSource = new VisitDAL();
        }

        /// <summary>
        /// It creates a new appointment.
        /// </summary>
        /// <param name="newAppointment">The appointment to be inserted.</param>
        public void Create(Appointment newAppointment)
        {
            if (newAppointment == null)
            {
                throw new ArgumentNullException("newAppointment");
            }
            if (newAppointment.PatientId <= 0) 
            {
                throw new ArgumentException("The patient must be specified.");
            }
            if (newAppointment.DoctorId <= 0) 
            {
                throw new ArgumentException("The doctor must be specified.");
            }
            if (String.IsNullOrWhiteSpace(newAppointment.Reason)) 
            {
                throw new ArgumentException("The reason must not be empty.");
            }
            if (newAppointment.Date < DateTime.Now.AddMinutes(-1))
            {
                throw new ArgumentException("The appointment date cannot be in the past.");
            }
            if (appointmentSource.ExistsForDoctorAndDate(newAppointment.DoctorId, newAppointment.Date))
            {
                throw new ArgumentException("The doctor has an existing appointment at the specified time.");
            }
            if (appointmentSource.ExistsForPatientAndDate(newAppointment.PatientId, newAppointment.Date))
            {
                throw new ArgumentException("The patient has an existing appointment at the specified time.");
            }
            appointmentSource.Insert(newAppointment);
        }

        internal IEnumerable<PatientVisits> GetPatientVisitsByPatientId(int patientId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// It updates an appointment.
        /// </summary>
        /// <param name="existingAppointment">The existing appoinment.</param>
        /// <param name="appointmentChanges">The appointment to be updated.</param>
        public void Update(Appointment existingAppointment, Appointment appointmentChanges)
        {
            if (!HasAnyUpdateChanges(existingAppointment, appointmentChanges))
            {
                throw new ArgumentException("No changes have been detected.");
            }
            if (appointmentChanges.Date < DateTime.Now.AddMinutes(-1))
            {
                throw new ArgumentException("The appointment date cannot be in the past.");
            }
            if (appointmentSource.ExistsForDoctorAndDate(existingAppointment.DoctorId, appointmentChanges.Date))
            {
                throw new ArgumentException("The doctor has an existing appointment at the specified time.");
            }
            if (appointmentSource.ExistsForPatientAndDate(existingAppointment.PatientId, appointmentChanges.Date))
            {
                throw new ArgumentException("The patient has an existing appointment at the specified time.");
            }
            int updatedRows = appointmentSource.Update(existingAppointment, appointmentChanges);
            if (updatedRows < 1) 
            {
                throw new ArgumentException("The appointment couldn't get updated. It may have changed by other user.");
            }
        }

        /// <summary>
        /// It deletes an appointment from the data base.
        /// </summary>
        /// <param name="appointmentId">The appointment id to be deleted.</param>
        /// <returns>The number of deleted rows.</returns>
        public void Delete(int appointmentId)
        {
            if (appointmentId < 0)
            {
                throw new ArgumentException("The appointmentId must not be negative.");
            }
            if (visitSource.ExistsForAppointmentId(appointmentId))
            {
                throw new ArgumentException("There is an assigned visit to this appointment. Thus, it cannot be deleted.");
            }
            int deletedRows = appointmentSource.Delete(appointmentId);
            if (deletedRows < 1)
            { 
                throw new ArgumentException("The appointment couldn't get deleted.");
            }
        }

        private bool HasAnyUpdateChanges(Appointment existingAppointment, Appointment appointmentChanges)
        {
            return DateTime.Compare(existingAppointment.Date, appointmentChanges.Date) != 0
                || existingAppointment.DoctorId != appointmentChanges.DoctorId
                || existingAppointment.Reason != appointmentChanges.Reason;
        }

        /// <summary>
        /// It searches appointments by the patient's id.
        /// </summary>
        /// <param name="patientId">The patients's id.</param>
        /// <returns>The list of found appointments.</returns>
        public List<AppointmentSearchResult> GetAppointmentsByPatientId(int patientId)
        {
            if (patientId < 0)
            {
                throw new ArgumentException("The patientId must not be negative");
            }
            return appointmentSource.GetAppointmentsByPatientId(patientId);
        }

        /// <summary>
        /// It returns an appointment by its ID.
        /// </summary>
        /// <param name="appointmentID">The ID of the appoinment to be retrieved.</param>
        /// <returns>The found appoinment.</returns>
        public Appointment GetAppointmentByAppointmentId(int appointmentID)
        {
            if (appointmentID < 0)
            {
                throw new ArgumentException("The appointmentID must not be negative");
            }
            return this.appointmentSource.GetAppointmentByAppointmentId(appointmentID);
        }
    }
}