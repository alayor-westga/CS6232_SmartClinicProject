﻿using System;
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
        private readonly UpdatePatientForm updatePatientForm;
        public enum SearchFormMode
        { 
            OnlySearch,
            SearchAndEdit
        }
        private SearchFormMode formMode;
        public SearchPatientsUserControl()
        {
            InitializeComponent();
            formMode = SearchFormMode.OnlySearch;
            patientController = new PatientController();
            selectionListeners = new List<SelectionListener<Patient>>();
            updatePatientForm = new UpdatePatientForm();
        }

        public void ChangeFormMode(SearchFormMode formMode)
        {
            this.formMode = formMode;
            if (this.formMode == SearchFormMode.SearchAndEdit)
            {
                editPatientButton.Visible = true;
                deletePatientButton.Visible = true;
            }
            else
            {
                editPatientButton.Visible = false;
                deletePatientButton.Visible = false;
            }
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
                patientsDataGridView.DataSource = patientController.SearchByDOB(dobOnlyDatePicker.Value);
            } 
            else if (searchByNamesRadioButton.Checked)
            {
                patientsDataGridView.DataSource = patientController.SearchByName(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text
                );
            }
            else if (searchByDOBAndLastNameRadioButton.Checked)
            {
                patientsDataGridView.DataSource = patientController.SearchByDOBAndLastName(
                    dobCombinedDatePicker.Value,
                    lastNameCombinedTextBox.Text
                );
            }
            searchMessageLabel.Text = patientsDataGridView.Rows.Count > 0 ? 
                    patientsDataGridView.Rows.Count + " Result(s) Returned" : 
                    "No Results Returned";
        }

        private void PatientsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (patientsDataGridView.SelectedRows.Count > 0)
            {
                if (formMode == SearchFormMode.SearchAndEdit)
                {
                    editPatientButton.Enabled = true;
                    deletePatientButton.Enabled = true;
                }
                foreach (SelectionListener<Patient> listener in selectionListeners)
                {
                    Patient patient = (Patient) patientsDataGridView.SelectedRows[0].DataBoundItem;
                    listener.OnSelect(patient);
                }
            }
           else
            {
                editPatientButton.Enabled = false;
                deletePatientButton.Enabled = false;
                foreach (SelectionListener<Patient> listener in selectionListeners)
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
            patientsDataGridView.DataSource = null;
            searchMessageLabel.Text = "";
        }

        private void PatientsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (patientsDataGridView.SelectedRows.Count > 0)
            {
                if (formMode == SearchFormMode.SearchAndEdit)
                {
                    OpenUpdatePatientForm();
                }
                else
                {
                    foreach (SelectionListener<Patient> listener in selectionListeners)
                    {
                        Patient patient = (Patient)patientsDataGridView.SelectedRows[0].DataBoundItem;
                        listener.OnDoubleClickSelect(patient);
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
            Patient patient = (Patient)patientsDataGridView.SelectedRows[0].DataBoundItem;
            updatePatientForm.ShowForPatient(patient.PatientId);
        }
    }
}