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
    }
}