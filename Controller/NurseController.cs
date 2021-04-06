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
        /// <param name="username">The username of the nurse.</param>
        /// <param name="password">The password of the nurse.</param>
        /// <returns>The id of the new nurse.</returns>
        public int AddNurse(int clinicPersonID, string username, string password)
        {
            if (clinicPersonID < 0)
            {
                throw new ArgumentException("The clinicPersonID must not be negative");
            }
            if (username == null)
            {
                throw new ArgumentNullException("username");
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            return nurseSource.AddNurse(clinicPersonID, username, password);
        }
    }
}