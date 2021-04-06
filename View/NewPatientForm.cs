using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartClinic.View
{
    /// <summary>
    /// It shows the new patient form.
    /// </summary>
    public partial class NewPatientForm : Form
    {
        /// <summary>
        /// It builds and initializes the new patient form.
        /// </summary>
        public NewPatientForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// It is the new created patient.
        /// </summary>
        public Patient SelectedPatient { 
            get
            {
                return (Patient) newClinicPersonUserControl1.SelectedClinicPerson;
            }
        }
    }
}
