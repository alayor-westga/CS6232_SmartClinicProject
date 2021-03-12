using System;
using System.Collections.Generic;
using SmartClinic.DAL;
using SmartClinic.Model;

namespace SmartClinic.Controller
{
    /// <summary>
    /// Middleware between the AppointmentDAL and the View.
    /// </summary>
    public class PatientVisitController
    {
        private readonly AppointmentDAL appointmentSource;
        private readonly VisitDAL visitSource;

        /// <summary>
        /// It creates a AppointmentController object.
        /// </summary>
        public PatientVisitController()
        {
            this.visitSource = new VisitDAL();
        }

        public List<PatientVisits> GetPatientVisitsByPatientId(int patientId)
        {
            return this.visitSource.GetPatientVisitsByPatientId(patientId);
        }

        public PatientVisits GetPatientVisitByAppointmentID(int appointmentID)
        {
            return this.visitSource.GetPatientVisitByAppointmentID(appointmentID);
        }

        public bool UpdatePatientVisitInformation(PatientVisits oldVisit, PatientVisits newVisit)
        {
            return this.visitSource.UpdatePatientVisitInformation(oldVisit, newVisit);
        }

        public bool AppointmentHasNoAssociatedVisit(int appointmentID)
        {
            return this.visitSource.AppointmentHasNoAssociatedVisit(appointmentID);
        }
    }
}