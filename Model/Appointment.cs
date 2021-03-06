using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartClinic.Model
{
    /// <summary>
    /// The Appoinment model class.
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// The Id of the appointment.
        /// </summary>
        public int AppointmentId { get; set; }

        /// <summary>
        /// The patient id assigned to the appointment.
        /// </summary>
        public int PatientId { get; set; }

        /// <summary>
        /// The appointment date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The doctor id assigned to the appointment.
        /// </summary>
        public int DoctorId { get; set; }

        /// <summary>
        /// The appointment reason.
        /// </summary>
        public string Reason { get; set; }
    }
}
