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
        /// It returns all the nurses in the system.
        /// </summary>
        /// <returns>The list of nurses.</returns>
        public List<Nurse> GetAllNurses()
        {
            return nurseSource.GetAllNurses();
        }

        /// <summary>
        /// It updates the user name and password of the nurse.
        /// </summary>
        /// <param name="username">The new username.</param>
        /// <param name="password">The new password.</param>
        /// <param name="currentUserName">The current user name.</param>
        /// <param name="currentPassword">The current password.</param>
        /// <returns>True if the update was successful. False otherwise</returns>
        public bool SetUserNameAndPassword(
            int nurseId, 
            string username, 
            string password, 
            string currentUserName
            ) 
        {
            return nurseSource.SetUserNameAndPassword(
                nurseId, 
                username, 
                password, 
                currentUserName
            );
        }
    }
}