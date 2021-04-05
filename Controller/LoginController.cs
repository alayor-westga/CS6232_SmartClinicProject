using System;
using System.Collections.Generic;
using SmartClinic.DAL;
using SmartClinic.Model;

namespace SmartClinic.Controller
{
    /// <summary>
    /// It provides authentication functionality for system users.
    /// </summary>
    public class LoginController
    {
        private readonly NurseDAL nurseSource;
        private static Nurse nurse;

        /// <summary>
        /// It creates a LoginController object.
        /// </summary>
        public LoginController()
        {
            nurseSource = new NurseDAL();
        }

        public static Nurse GetNurse()
        {
            return LoginController.nurse;
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
            nurse = this.nurseSource.GetByUserNameAndPassword(username, password);
            return nurse;
        }
    }
}