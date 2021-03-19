using System;

namespace SmartClinic.Model
{
    /// <summary>
    /// The Appoinment model class.
    /// </summary>
    public class AppointmentSearchResult
    {
        private Appointment appointment;

        /// <summary>
        /// It initializes the appointment property.
        /// </summary>
        public AppointmentSearchResult(Appointment appointment)
        {
            this.appointment = appointment;
        }

        /// <summary>
        /// The appoinment source object.
        /// </summary>
        public Appointment Appointment { 
            get
            {
                return appointment;
            }
        }

        /// <summary>
        /// The appoinment's id.
        /// </summary>
        public int AppoinmentId { 
            get
            {
                return appointment.AppointmentId;
            }
        }

        /// <summary>
        /// The appointment's date time.
        /// </summary>
        public DateTime AppointmentDate { 
            get
            {
                return appointment.Date;
            }
        }

        /// <summary>
        /// The patient's date of birth.
        /// </summary>
        public DateTime PatientDateOfBirth { 
            get
            {
                return appointment.Patient.DateOfBirth;
            }
        }

        /// <summary>
        /// The patient's full name.
        /// </summary>
        public string PatientFullName { 
            get
            {
                return appointment.Patient.FullName;
            }
        }

        /// <summary>
        /// The patient's address.
        /// </summary>
        public string PatientAddress { 
            get
            {
                var patient = appointment.Patient; 
                return patient.Street1 + " " + patient.Street2 + " " + patient.City + " " + patient.State;
            }
        }

        /// <summary>
        /// The doctors's full name.
        /// </summary>
        public string DoctorFullName { 
            get
            {
                return appointment.Doctor.FullName;
            }
        }
    }
}
