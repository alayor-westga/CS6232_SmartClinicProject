using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void SearchByDOBOnlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EnableSearchByDOBOnly();
            DisableNamesSearch();
            DisableDOBLastNameSearch();
        }

        private void SearchByNamesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisableSearchByDOBOnly();
            EnableNamesSearch();
            DisableDOBLastNameSearch();
        }

        private void SearchByDOBAndLastNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisableSearchByDOBOnly();
            DisableNamesSearch();
            EnableDOBLastNameSearch();
        }

        private void EnableSearchByDOBOnly()
        {
            dobOnlyLabel.ForeColor = SystemColors.ControlText;
            dobOnlyDatePicker.Enabled = true;
        }

        private void DisableSearchByDOBOnly()
        {
            dobOnlyLabel.ForeColor = SystemColors.ControlDark;
            dobOnlyDatePicker.Enabled = false;
        }

        private void EnableNamesSearch()
        {
            firstNameLabel.ForeColor = SystemColors.ControlText;
            firstNameTextBox.Enabled = true;
            lastNameLabel.ForeColor = SystemColors.ControlText;
            lastNameTextBox.Enabled = true;
        }

        private void DisableNamesSearch()
        {
            firstNameLabel.ForeColor = SystemColors.ControlDark;
            firstNameTextBox.Enabled = false;
            lastNameLabel.ForeColor = SystemColors.ControlDark;
            lastNameTextBox.Enabled = false;
        }

        private void EnableDOBLastNameSearch()
        {
            dobCombinedLabel.ForeColor = SystemColors.ControlText;
            dobCombinedDatePicker.Enabled = true;
            lastNameCombinedLabel.ForeColor = SystemColors.ControlText;
            lastNameCombinedTextBox.Enabled = true;
        }

        private void DisableDOBLastNameSearch()
        {
            dobCombinedLabel.ForeColor = SystemColors.ControlDark;
            dobCombinedDatePicker.Enabled = false;
            lastNameCombinedLabel.ForeColor = SystemColors.ControlDark;
            lastNameCombinedTextBox.Enabled = false;
        }
    }
}
