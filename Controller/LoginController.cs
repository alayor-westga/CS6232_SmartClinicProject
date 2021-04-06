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
        private readonly AdministratorDAL adminSource;
        private static User user;

        /// <summary>
        /// It creates a LoginController object.
        /// </summary>
        public LoginController()
        {
            nurseSource = new NurseDAL();
            adminSource = new AdministratorDAL();
        }

        public static User GetUser()
        {
            return LoginController.user;
        }

        /// <summary>
        /// It verifies the user credentials and returns a user object.
        /// </summary>
        /// <param name="username">The user's username.</param>
        /// <param name="password">The user's password.</param>
        /// <param name="role">The user's role.</param>
        /// <returns>The user info if credentials are correct. Null otherwise.</returns>
        public User Login(string username, string password, UserRole role)
        {
            if (String.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("username cannot be null or empty.");
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("password cannot be null or empty.");
            }
            if (role == UserRole.Nurse)
            { 
                return LoginAsNurse(username, password);
            } 
            else if (role == UserRole.Admin)
            {
                return LoginAsAdmin(username, password);
            }
            throw new Exception("Unknown role " + role.ToString());
        }

        private User LoginAsNurse(string username, string password)
        {
            Nurse nurse = this.nurseSource.GetByUserNameAndPassword(username, password);
            if (nurse == null)
            {
                return null;
            }
            user = new User()
            {
                UserId = nurse.NurseId,
                UserName = username,
                FullName = nurse.FullName,
                Role = UserRole.Nurse
            };
            return user;
        }

        private User LoginAsAdmin(string username, string password)
        {
            Administrator admin = this.adminSource.GetByUserNameAndPassword(username, password);
            if (admin == null)
            {
                return null;
            }
            user = new User()
            {
                UserId = admin.AdministratorId,
                UserName = username,
                FullName = admin.FullName,
                Role = UserRole.Admin
            };
            return user;
        }
    }
}