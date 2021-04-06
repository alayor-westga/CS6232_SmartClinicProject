using System;
using System.Collections.Generic;
using SmartClinic.DAL;
using SmartClinic.Model;

namespace SmartClinic.Controller
{
    /// <summary>
    /// Middleware between the ClinicPersonDAL and the View.
    /// </summary>
    public class ClinicPersonController
    {
        private readonly ClinicPersonDAL clinicPersonSource;

        /// <summary>
        /// It creates a ClinicPersonController object.
        /// </summary>
        public ClinicPersonController()
        {
            clinicPersonSource = new ClinicPersonDAL();
        }

        /// <summary>
        /// It adds a clinic person to the DB.
        /// </summary>
        /// <param name="newClinicPerson">The clinic person to be added.</param>
        /// <returns>The number of rows affected.</returns>
        public int AddClinicPerson(ClinicPerson newClinicPerson)
        {
            if (newClinicPerson == null)
            {
                throw new ArgumentNullException("newClinicPerson");
            }
            return this.clinicPersonSource.AddClinicPerson(newClinicPerson);
        }

        /// <summary>
        /// Checks if a ClinicPerson exists via UQ and NOT NULL key ssn
        /// </summary>
        /// <param name="ssn">ssn</param>
        /// <returns>true if ssn is not unique, false otherwise</returns>
        public bool SsnIsNotUnique(string ssn)
        {
            if (String.IsNullOrWhiteSpace(ssn))
            {
                throw new ArgumentNullException("ssn");
            }
            return this.clinicPersonSource.SsnIsNotUnique(ssn);
        }
    }
}