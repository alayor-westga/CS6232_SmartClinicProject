using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;

namespace SmartClinic.View
{
    public partial class SearchPatientsForm : Form, SelectionListener<Patient>
    {
        private Patient patient;
        public SearchPatientsForm()
        {
            InitializeComponent();
            searchPatientsUserControl.AddSelectionListener(this);
            patient = null;
        }

        public Patient SelectedPatient { get; set; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            patient = null;
            Close();
        }

        void SelectionListener<Patient>.OnSelect(Patient selectedValue)
        {
            patient = selectedValue;
            selectPatientButton.Enabled = true;
        }

        void SelectionListener<Patient>.OnDoubleClickSelect(Patient selectedValue)
        {
            patient = selectedValue;
            SelectAndClose();
        }

        void SelectionListener<Patient>.OnSelectionCleared()
        {
            selectPatientButton.Enabled = false;
        }

        private void SelectPatientButton_Click(object sender, EventArgs e)
        {
            SelectAndClose();
        }

        private void SelectAndClose()
        {
            DialogResult = DialogResult.OK;
            SelectedPatient = patient;
            Close();
        }
    }
}
