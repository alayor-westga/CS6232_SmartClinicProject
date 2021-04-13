﻿using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartClinic.View
{
    public partial class LabTestDetailsForm : Form
    {
        private readonly LabTestController labTestController;
        private readonly PatientVisits visit;
        private LabTestResults oldResults;

        public LabTestDetailsForm(PatientVisits visit)
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            this.visit = visit;
        }

        private void ThisFormLoad_Load(object sender, EventArgs e)
        {
            this.LoadLabTestListBox();           
            this.datePerformedDateTimePicker.Checked = false;
            this.datePerformedDateTimePicker.Text = "";
            this.PopulateForm();
            this.PopulateDataGridView();
        }

        private void LoadLabTestListBox()
        {
            List<LabTest> allLabTests = new List<LabTest>();
            List<LabTest> labTestsNotSelected = new List<LabTest>();

            try
            {               
                allLabTests = this.labTestController.GetAllLabTests();
                foreach (LabTest labTest in allLabTests)
                {
                    if (this.labTestController.GetSingleLabTestResult(labTest.LabTestCode, this.visit.AppointmentID) == null)
                    {
                        labTestsNotSelected.Add(labTest);
                    }
                }
                if (labTestsNotSelected.Count == 0)
                {
                    this.orderTestButton.Enabled = false;              
                }
                this.labTestListBox.DataSource = labTestsNotSelected;
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.labTestListBox.ClearSelected();
        }

        private void PopulateForm()
        {
            this.patientIDDisplayLabel.Text = this.visit.PatientID.ToString();
            this.patientNameDisplayLabel.Text = this.visit.Patient.ToString();
            this.apptDateTimeDisplayLabel.Text = this.visit.VisitDate.ToString();
            this.appointmentIDLabel2.Text = this.visit.AppointmentID.ToString();
        }

        private void OrderTestButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish\nto order these tests?",
                        "Confirm Test Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            List<LabTestResults> orderedTests = new List<LabTestResults>();

            foreach (LabTest labTest in labTestListBox.SelectedItems)
            {
                LabTestResults labTestResult = new LabTestResults();
                labTestResult.LabTestCode = labTest.LabTestCode;
                labTestResult.AppointmentID = this.visit.AppointmentID;
                orderedTests.Add(labTestResult);
            }

            try
            {
                this.labTestController.AddOrderedTests(orderedTests);
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Tests have been successfully ordered.",
                        "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.PopulateDataGridView();
            this.LoadLabTestListBox();
        }

        private void DatePerformedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (((DateTimePicker)sender).ShowCheckBox == true)
            {
                if (((DateTimePicker)sender).Checked == false)
                {
                    ((DateTimePicker)sender).CustomFormat = " ";
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
                }
            }
            else
            {
                ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
            }
        }

        private void PopulateDataGridView()
        {
            try
            {
                this.labTestResultsDataGridView.DataSource = this.labTestController.GetTestsForAppointment(this.visit.AppointmentID);
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RowSelectionChanged_Click(object sender, EventArgs e)
        {
            this.oldResults = new LabTestResults();
            try
            {
                oldResults = this.labTestController.GetSingleLabTestResult(this.labTestResultsDataGridView.CurrentRow.Cells[0].Value.ToString(), 
                    this.visit.AppointmentID);
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.labTestCodeLabel2.Text = oldResults.LabTestCode;
            this.nameLabel1.Text = oldResults.LabTestName;

            try
            {
                this.datePerformedDateTimePicker.Checked = true;
                this.datePerformedDateTimePicker.Value = oldResults.DatePerformed;
            }
            catch (ArgumentOutOfRangeException)
            {
                this.datePerformedDateTimePicker.Text = "";
            }

            try
            {
                if ((bool)oldResults.IsNormal)
                {
                    this.isNormalComboBox.Text = "normal";
                }
                else if ((bool)!oldResults.IsNormal)
                {
                    this.isNormalComboBox.Text = "abnormal";
                }
            } 
            catch
            {
                this.isNormalComboBox.Text = "";
            }
            
            this.resultTextBox.Text = oldResults.Result;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(this.resultTextBox.Text) && !string.IsNullOrWhiteSpace(this.isNormalComboBox.Text) ||
                !string.IsNullOrWhiteSpace(this.resultTextBox.Text) && string.IsNullOrWhiteSpace(this.isNormalComboBox.Text)))
            {
                MessageBox.Show("'Result' and 'Normal / Abnormal' fields\nmust be entered at the same time",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LabTestResults newResults = new LabTestResults();
            newResults.AppointmentID = this.visit.AppointmentID;
            newResults.LabTestCode = this.labTestCodeLabel2.Text;

            if (this.GetFieldsWithValues() == "Date has value")
            {
                newResults.DatePerformed = (DateTime)this.datePerformedDateTimePicker.Value;

                try
                {
                    this.labTestController.UpdateLabTestResults(newResults, this.oldResults, "update date");
                }
                catch (ArgumentException argumentException)
                {
                    MessageBox.Show(argumentException.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (this.GetFieldsWithValues() == "Result has value")
            {
                if (this.isNormalComboBox.Text == "normal")
                {
                    newResults.IsNormal = true;
                }
                else
                {
                    newResults.IsNormal = false;
                }

                newResults.Result = this.resultTextBox.Text;

                try
                {
                    this.labTestController.UpdateLabTestResults(newResults, this.oldResults, "update result");
                }
                catch (ArgumentException argumentException)
                {
                    MessageBox.Show(argumentException.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (this.GetFieldsWithValues() == "Result and Date have values")
            {
                newResults.DatePerformed = (DateTime)this.datePerformedDateTimePicker.Value;

                if (this.isNormalComboBox.Text == "normal")
                {
                    newResults.IsNormal = true;
                }
                else
                {
                    newResults.IsNormal = false;
                }

                newResults.Result = this.resultTextBox.Text;

                try
                {
                    this.labTestController.UpdateLabTestResults(newResults, this.oldResults, "update result and date");
                }
                catch (ArgumentException argumentException)
                {
                    MessageBox.Show(argumentException.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (this.GetFieldsWithValues() == "No fields have values")
            {
                MessageBox.Show("There is nothing to save.",
                         "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Changes to this lab test have\nhave been successfully saved",
                                     "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private string GetFieldsWithValues()
        {
            if ((string.IsNullOrWhiteSpace(this.resultTextBox.Text) && !this.datePerformedDateTimePicker.Checked))
            {
                return "Result has value";
            }
            if ((!string.IsNullOrWhiteSpace(this.resultTextBox.Text) && this.datePerformedDateTimePicker.Checked))
            {
                return "Date has value";
            }
            if ((string.IsNullOrWhiteSpace(this.resultTextBox.Text) && this.datePerformedDateTimePicker.Checked))
            {
                return "Result and Date have values";
            }
            return "No fields have values";
        }
    }
}
