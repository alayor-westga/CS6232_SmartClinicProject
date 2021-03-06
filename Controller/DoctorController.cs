using System;
using System.Collections.Generic;
using SmartClinic.DAL;
using SmartClinic.Model;

namespace SmartClinic.Controller
{
    /// <summary>
    /// Middleware between the DoctorDAL and the View.
    /// </summary>
    public class DoctorController
    {
        private readonly DoctorDAL doctorSource;

        /// <summary>
        /// It creates a DoctorController object.
        /// </summary>
        public DoctorController()
        {
            doctorSource = new DoctorDAL();
        }

        /// <summary>
        /// It returns all the doctors.
        /// </summary>
        /// <returns>All the doctors.</returns>
        public List<Doctor> GetAll()
        {
            return doctorSource.GetAll();
        }
    }
}