using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;

namespace SmartClinic.View
{
    /// <summary>
    /// It renders the for to create appointments for patients.
    /// </summary>
    public partial class NewAppointmentForm : Form
    {
        private readonly PatientController patientController;

        /// <summary>
        /// It builds and initializes the new appointment form.
        /// </summary>
        public NewAppointmentForm()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        private void SearchPatientsButton_Click(object sender, EventArgs e)
        {
            List<Patient> patients = patientController.SearchPatients("B", null, 0, null);
            patientsDataGridView.DataSource = patients;
        }
    }
}
