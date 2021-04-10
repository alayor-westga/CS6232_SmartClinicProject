using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartClinic.Model;

namespace SmartClinic.Controller
{
    /// <summary>
    /// It represents an object that listens for new clinic persons added to the system.
    /// </summary>
    public interface ClinicPersonAddedListener
    {
        /// <summary>
        /// Called when a new clinic person has been added to the system.
        /// </summary>
        void OnAdded(ClinicPerson clinicPerson);
    }
}
