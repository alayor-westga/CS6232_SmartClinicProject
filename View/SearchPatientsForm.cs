using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;

namespace SmartClinic.View
{
    public partial class SearchPatientsForm : Form
    {
        public SearchPatientsForm()
        {
            InitializeComponent();
        }

        public Patient SelectedPatient { get; set; }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectPatientButton_Click(object sender, EventArgs e)
        {
            SelectedPatient = searchPatientsUserControl.SelectedPatient;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
