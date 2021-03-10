using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;

namespace SmartClinic.View
{
    public partial class SearchPatientsForm : Form, SelectionListener<Patient>
    {
        public SearchPatientsForm()
        {
            InitializeComponent();
        }

        public Patient SelectedPatient { get; set; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void SelectionListener<Patient>.OnSelect(Patient selectedValue)
        {
            SelectedPatient = selectedValue;
            selectPatientButton.Enabled = true;
        }

        void SelectionListener<Patient>.OnSelectionCleared()
        {
            selectPatientButton.Enabled = false;
        }

        private void SelectPatientButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
