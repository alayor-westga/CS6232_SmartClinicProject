using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;
using SmartClinic.View;

namespace SmartClinic.UserControls
{
    public partial class SearchPatientsUserControl : UserControl
    {
        private List<SelectionListener<Patient>> selectionListeners;
        private readonly PatientController patientController;
        public SearchPatientsUserControl()
        {
            InitializeComponent();
            patientController = new PatientController();
            selectionListeners = new List<SelectionListener<Patient>>();
        }

        public void AddSelectionListener(SelectionListener<Patient> selectionListener)
        {
            if (!selectionListeners.Contains(selectionListener))
            {
                selectionListeners.Add(selectionListener);
            }
        }

        private void SearchPatientsUserControl_Load(object sender, EventArgs e)
        {
            searchByDOBOnlyRadioButton.Checked = true;
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchByDOBOnlyRadioButton.Checked)
            {
                patientsDataGridView.DataSource = patientController.SearchByDOB(dobOnlyDatePicker.Value);
            } 
            else if (searchByNamesRadioButton.Checked)
            {
                patientsDataGridView.DataSource = patientController.SearchByName(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text
                );
            }
        }

        private void PatientsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (patientsDataGridView.SelectedRows.Count > 0)
            {
                foreach (SelectionListener<Patient> listener in selectionListeners)
                {
                    Patient patient = (Patient) patientsDataGridView.SelectedRows[0].DataBoundItem;
                    listener.OnSelect(patient);
                }
            }
           else
            {
                foreach (SelectionListener<Patient> listener in selectionListeners)
                {
                    listener.OnSelectionCleared();
                }
            }
        }
    }
}
