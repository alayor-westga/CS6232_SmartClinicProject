using System;
using System.Collections.Generic;
using SmartClinic.DAL;
using SmartClinic.Model;

namespace SmartClinic.Controller
{
    /// <summary>
    /// Middleware between the NurseDAL and the View.
    /// </summary>
    public class NurseController
    {
        private readonly NurseDAL nurseSource;

        /// <summary>
        /// It creates a NurseController object.
        /// </summary>
        public NurseController()
        {
            nurseSource = new NurseDAL();
        }

        /// <summary>
        /// It inserts a nurse into the DB.
        /// </summary>
        /// <param name="clinicPersonID">The clinic person id of the nurse.</param>
        /// <returns>The id of the new nurse.</returns>
        public int AddNurse(int clinicPersonID)
        {
            if (clinicPersonID < 0)
            {
                throw new ArgumentException("The clinicPersonID must not be negative");
            }
            return nurseSource.AddNurse(clinicPersonID);
        }

        /// <summary>
        /// It returns all the nurses in the system.
        /// </summary>
        /// <returns>The list of nurses.</returns>
        public List<Nurse> GetAllNurses()
        {
            return nurseSource.GetAllNurses();
        }
    }
}