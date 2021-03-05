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
        /// It verifies the nurse credentials and returns a nurse object.
        /// </summary>
        /// <param name="username">The nurse's username.</param>
        /// <param name="password">The nurse's password.</param>
        /// <returns>The nurse info if credentials are correct. Null otherwise.</returns>
        public Nurse Login(string username, string password)
        {
            if (String.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("username cannot be null or empty.");
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("password cannot be null or empty.");
            }
            return this.nurseSource.GetByUserNameAndPassword(username, password);
        }
    }
}