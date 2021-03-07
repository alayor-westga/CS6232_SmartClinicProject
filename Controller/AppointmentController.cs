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
            appointmentSource.Insert(newAppointment);
        }
    }
}