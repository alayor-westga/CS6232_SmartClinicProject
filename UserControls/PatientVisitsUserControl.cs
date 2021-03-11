using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;
using SmartClinic.View;

namespace SmartClinic.UserControls
{
    public partial class PatientVisitsUserControl : UserControl
    {
        private List<SelectionListener<PatientVisits>> selectionListeners;
        private readonly PatientController patientController;
        private readonly PatientVisitDetailsForm patientVisitDetailsForm;
        public enum SearchFormMode
        {
            OnlySearch,
            SearchAndEdit
        }
        private SearchFormMode formMode;
        public PatientVisitsUserControl()
        {
            InitializeComponent();
            formMode = SearchFormMode.OnlySearch;
            patientController = new PatientController();
            selectionListeners = new List<SelectionListener<PatientVisits>>();
            this.patientVisitDetailsForm = new PatientVisitDetailsForm();
        }

        public void ChangeFormMode(SearchFormMode formMode)
        {
            this.formMode = formMode;
            if (this.formMode == SearchFormMode.SearchAndEdit)
            {
                viewOrEditPatientVisitDetailsButton.Visible = true;
            }
            else
            {
                viewOrEditPatientVisitDetailsButton.Visible = false;
            }
        }

        public void AddSelectionListener(SelectionListener<PatientVisits> selectionListener)
        {
            if (!selectionListeners.Contains(selectionListener))
            {
                selectionListeners.Add(selectionListener);
            }
        }

        private void SearchPatientsUserControl_Load(object sender, EventArgs e)
        {
            Clear();
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
                patientSearchResultDataGridView.DataSource = patientController.SearchPatientVisitsByDOB(dobOnlyDatePicker.Value);
                
            }
            else if (searchByNamesRadioButton.Checked)
            {
                

                patientSearchResultDataGridView.DataSource = patientController.SearchByName(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text
                );
            }
            else if (searchByDOBAndLastNameRadioButton.Checked)
            {
                

                patientSearchResultDataGridView.DataSource = patientController.SearchByDOBAndLastName(
                    dobCombinedDatePicker.Value,
                    lastNameCombinedTextBox.Text
                );
            }
            searchMessageLabel.Text = patientSearchResultDataGridView.Rows.Count > 0 ?
                    patientSearchResultDataGridView.Rows.Count + " Result(s) Returned" :
                    "No Results Returned";
        }

        private void PatientsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (patientSearchResultDataGridView.SelectedRows.Count > 0)
            {
                if (formMode == SearchFormMode.SearchAndEdit)
                {
                    viewOrEditPatientVisitDetailsButton.Enabled = true;
                }
                foreach (SelectionListener<PatientVisits> listener in selectionListeners)
                {
                    PatientVisits appointmentID = (PatientVisits)patientSearchResultDataGridView.SelectedRows[0].DataBoundItem;
                    listener.OnSelect(appointmentID);
                }
            }
            else
            {
                viewOrEditPatientVisitDetailsButton.Enabled = false;
                foreach (SelectionListener<PatientVisits> listener in selectionListeners)
                {
                    listener.OnSelectionCleared();
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            dobOnlyDatePicker.Value = DateTime.Now;
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dobCombinedDatePicker.Value = DateTime.Now;
            lastNameCombinedTextBox.Text = "";
            patientSearchResultDataGridView.DataSource = null;
        }

        private void PatientsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (patientSearchResultDataGridView.SelectedRows.Count > 0)
            {
                if (formMode == SearchFormMode.SearchAndEdit)
                {
                    OpenUpdatePatientForm();
                }
                else
                {
                    foreach (SelectionListener<PatientVisits> listener in selectionListeners)
                    {
                        PatientVisits patientVisit = (PatientVisits)patientSearchResultDataGridView.SelectedRows[0].DataBoundItem;
                        listener.OnDoubleClickSelect(patientVisit);
                    }
                }
            }
        }

        private void EditPatientButton_Click(object sender, EventArgs e)
        {
            OpenUpdatePatientForm();
        }

        private void OpenUpdatePatientForm()
        {
            //PatientVisits patientVisit = (PatientVisits)patientSearchResultDataGridView.SelectedRows[0].DataBoundItem;
            PatientVisits patientVisit = (PatientVisits)patientSearchResultDataGridView.SelectedRows[0].DataBoundItem;
            Console.WriteLine("PatientVisit: " + patientVisit.AppointmentID);
            patientVisitDetailsForm.ShowForPatientVisit(patientVisit.AppointmentID);
        }
    }
}
