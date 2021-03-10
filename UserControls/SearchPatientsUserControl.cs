using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;

namespace SmartClinic.UserControls
{
    public partial class SearchPatientsUserControl : UserControl
    {
        private readonly PatientController patientController;
        public SearchPatientsUserControl()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        public Patient SelectedPatient {
            get
            {
                return (Patient)patientsDataGridView.SelectedRows[0].DataBoundItem;
            }
        }

        private void SearchPatientsUserControl_Load(object sender, EventArgs e)
        {
            var patients = patientController.SearchPatients("a", "", 0, null);
            patientsDataGridView.DataSource = patients;
        }
    }
}
