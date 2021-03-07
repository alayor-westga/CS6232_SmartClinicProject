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

        /// <summary>
        /// It creates a AppointmentController object.
        /// </summary>
        public AppointmentController()
        {
            appointmentSource = new AppointmentDAL();
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
            if (appointmentSource.ExistsForDoctorAndDate(newAppointment.DoctorId, newAppointment.Date))
            {
                throw new ArgumentException("The doctor has an existing appointment at the specified time.");
            }
            appointmentSource.Insert(newAppointment);
        }

        /// <summary>
        /// It searches appointments by the patient's name and date of birth.
        /// </summary>
        /// <param name="firstName">The patients's username.</param>
        /// <param name="lastName">The patients's lastName.</param>
        /// <param name="dateOfBirth">The patients's dateOfBirth.</param>
        /// <returns>The list of found appointments.</returns>
        public List<AppointmentSearchResult> SearchAppointments(string firstName, string lastName, DateTime? dateOfBirth)
        {
            if (String.IsNullOrWhiteSpace(firstName) &&
                String.IsNullOrWhiteSpace(lastName) &&
                dateOfBirth == null)
            {
                throw new ArgumentException("At least one parameter must be neither null nor empty.");
            }
            return appointmentSource.SearchAppointments(firstName, lastName, dateOfBirth);
        }
    }
}