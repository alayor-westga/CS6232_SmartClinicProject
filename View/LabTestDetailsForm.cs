using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartClinic.View
{
    /// <summary>
    /// This view class manages the user interface to order and update lab tests
    /// </summary>
    public partial class LabTestDetailsForm : Form
    {
        private readonly LabTestController labTestController;
        private readonly PatientVisits visit;
        private LabTestResults oldResults;
        private LabTestResults newResults;
        private readonly bool finalDiagnosisAdded;

        /// <summary>
        /// Constructor for class to initialize components and instance variables
        /// </summary>
        /// <param name="visit"></param>
        /// <param name="finalDiagnosisAdded"></param>
        public LabTestDetailsForm(PatientVisits visit, bool finalDiagnosisAdded)
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            this.visit = visit;          
            this.finalDiagnosisAdded = finalDiagnosisAdded;
        }

        private void ThisFormLoad_Load(object sender, EventArgs e)
        {
            this.LoadLabTestListBox();
            this.datePerformedDateTimePicker.Checked = false;
            this.datePerformedDateTimePicker.Text = "";
            this.PopulateHeader();
            this.PopulateDataGridView();
            this.PopulateSearchComboBoxes();
            this.DisableFormIfFinalDiagnosisEntered();
            if (this.labTestResultsDataGridView.Rows.Count == 0)
            {
                this.saveChangesButton.Enabled = false;
            }        
        }

        private void PopulateHeader()
        {
            this.patientIDDisplayLabel.Text = this.visit.PatientID.ToString();
            this.patientNameDisplayLabel.Text = this.visit.Patient.ToString();
            this.apptDateTimeDisplayLabel.Text = this.visit.VisitDate.ToString();
            this.appointmentIDLabel2.Text = this.visit.AppointmentID.ToString();
        }

        private void LoadLabTestListBox()
        {
            List<LabTest> allLabTests;
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

        private void PopulateSearchComboBoxes()
        {
            try
            {
                this.labTestCodeComboBox.DataSource = this.labTestController.GetAllLabTests();
                this.labTestNameComboBox.DataSource = this.labTestController.GetAllLabTests();
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.labTestCodeComboBox.SelectedIndex = -1;
            this.labTestNameComboBox.SelectedIndex = -1;
        }

        private void DisableFormIfFinalDiagnosisEntered()
        {
            if (this.finalDiagnosisAdded)
            {
                this.datePerformedDateTimePicker.Enabled = false;
                this.resultTextBox.ReadOnly = true;
                this.isNormalComboBox.Enabled = false;
                this.orderTestButton.Enabled = false;
                this.saveChangesButton.Enabled = false;
                this.labTestListBox.Enabled = false;
            }
        }

        private void OrderTestButton_Click(object sender, EventArgs e)
        {
            List<LabTestResults> orderedTests = new List<LabTestResults>();
            int selectedItemsCounter = 0;
            foreach (LabTest labTest in labTestListBox.SelectedItems)
            {
                LabTestResults labTestResult = new LabTestResults();
                labTestResult.LabTestCode = labTest.LabTestCode;
                labTestResult.AppointmentID = this.visit.AppointmentID;
                orderedTests.Add(labTestResult);
                selectedItemsCounter += 1;
            }

            if (selectedItemsCounter == 0)
            {
                MessageBox.Show("You have not selected any items",
                      "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you wish\nto order these tests?",
                        "Confirm Test Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
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
            this.PopulateDataGridView();
            this.LoadLabTestListBox();
            this.labTestCodeComboBox.SelectedIndex = -1;
            this.labTestNameComboBox.SelectedIndex = -1;

            MessageBox.Show("Tests have been successfully ordered.",
                        "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);        
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
                    //((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
                    ((DateTimePicker)sender).CustomFormat = "MM/dd/yyyy hh:mm tt";
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
                }
            }
            else
            {
                //((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
                ((DateTimePicker)sender).CustomFormat = "MM/dd/yyyy hh:mm tt";
                ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
            }
        }

        private void RowSelectionChanged_Click(object sender, EventArgs e)
        {
            this.GetDataForSelectedRow();
            this.labTestCodeLabel2.Text = oldResults.LabTestCode;
            this.nameLabel1.Text = oldResults.LabTestName;
            this.PopulateDateIsNormalResults();
        }

        private void PopulateDateIsNormalResults()
        {
            try
            {
                this.datePerformedDateTimePicker.Checked = true;
                this.datePerformedDateTimePicker.Value = (DateTime)oldResults.DatePerformed;
            }
            catch (InvalidOperationException)
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
                this.isNormalComboBox.Text = null;
            }
            this.resultTextBox.Text = oldResults.Result;
        }

        private void GetDataForSelectedRow() 
        {
            this.oldResults = new LabTestResults();
        
            try
            {
                Console.WriteLine(labTestResultsDataGridView.Rows.Count);
                if(this.labTestResultsDataGridView.Rows.Count != 0)
                {
                    oldResults = this.labTestController.GetSingleLabTestResult(this.labTestResultsDataGridView.CurrentRow.Cells[0].Value.ToString(), this.visit.AppointmentID);              
                    Console.WriteLine("current row in getdataforRow: " + this.labTestResultsDataGridView.CurrentRow.Cells[0].Value);
                }              
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateFormChanges())
            {             
                return;
            }
            if (!this.ValidateResultsAndIsNormalEnteredTogether())
            {             
                return;
            }

            if ((!string.IsNullOrWhiteSpace(this.resultTextBox.Text) && this.datePerformedDateTimePicker.Checked == false))
            {
                MessageBox.Show("Must select a 'Date Performed' before saving results.",
                       "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.AssignEnteredValuesToNewResults();
            if (!this.UpdateLabTestResults())
            {
                return;
            }
            this.PopulateDataGridView();        
        }
       
        private bool UpdateLabTestResults()
        {
            try
            {
                if (!this.labTestController.UpdateLabTestResults(this.oldResults, this.newResults))
                {
                    MessageBox.Show("This lab test information has been\nmodified since it has been retrieved."
                    + "\n\nThe form has been updated to reflect those changes.",
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.oldResults = this.labTestController.GetSingleLabTestResult(this.labTestCodeLabel2.Text, this.visit.AppointmentID);
                    this.PopulateDateIsNormalResults();
                    return false;
                }
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Changes to this lab test have\nhave been successfully saved",
                                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void AssignEnteredValuesToNewResults()
        {
            this.newResults = new LabTestResults
            {
                AppointmentID = this.visit.AppointmentID,
                LabTestCode = this.labTestCodeLabel2.Text
            };

            if (this.datePerformedDateTimePicker.Checked)
            {
                this.newResults.DatePerformed = (DateTime)this.datePerformedDateTimePicker.Value;
            }
            else
            {
                this.newResults.DatePerformed = null;
            }

            if (this.isNormalComboBox.Text == "normal")
            {
                this.newResults.IsNormal = true;
            }
            else if (this.isNormalComboBox.Text == "abnormal")
            {
                this.newResults.IsNormal = false;
            }
            else
            {
                this.newResults.IsNormal = null;
            }

            if (string.IsNullOrWhiteSpace(this.resultTextBox.Text))
            {
                this.newResults.Result = "";
            }
            else
            {
                this.newResults.Result = this.resultTextBox.Text;
            }
        }

        private bool ValidateResultsAndIsNormalEnteredTogether()
        {
            if ((string.IsNullOrWhiteSpace(this.resultTextBox.Text) && !string.IsNullOrWhiteSpace(this.isNormalComboBox.Text) ||
                !string.IsNullOrWhiteSpace(this.resultTextBox.Text) && string.IsNullOrWhiteSpace(this.isNormalComboBox.Text)))
            {
                MessageBox.Show("'Result' and 'Normal / Abnormal' fields\nmust be entered at the same time",
                      "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidateFormChanges()
        {
            bool formChanged = false;
            if (this.oldResults.DatePerformed != (DateTime)this.datePerformedDateTimePicker.Value) 
            {
                formChanged = true;
            }
            if (this.oldResults.Result != this.resultTextBox.Text)
            {
                formChanged = true;
            }
            if (this.oldResults.IsNormal == true && this.isNormalComboBox.Text != "normal")
            {
                formChanged = true;
            }
            if (this.oldResults.IsNormal == false && this.isNormalComboBox.Text != "abnormal")
            {
                formChanged = true;
            }
            if (this.oldResults.IsNormal == null && this.isNormalComboBox.Text != "")
            {
                formChanged = true;
            }
            if (this.oldResults == null && this.datePerformedDateTimePicker.Checked == true)
            {
                formChanged = true;
            }
            if ((this.oldResults.DatePerformed == (DateTime)this.datePerformedDateTimePicker.Value) && this.datePerformedDateTimePicker.Checked == false)
            {
                formChanged = true;
            }
            if (this.oldResults.DatePerformed == null && this.datePerformedDateTimePicker.Value == DateTime.Now && this.datePerformedDateTimePicker.Checked == false)
            {
                formChanged = true;
            }
            if (formChanged == false)
            {
                MessageBox.Show("No changes to the form have been detected.",
                      "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return formChanged;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }    

        private void LabTestCode_DropDownClosed(object sender, EventArgs e)
        {
            if (this.labTestCodeComboBox.SelectedIndex != -1)
            {
                this.labTestNameComboBox.SelectedIndex = -1;
            }
        }

        private void LabTestName_DropDownClosed(object sender, EventArgs e)
        {
            if (this.labTestNameComboBox.SelectedIndex != -1)
            {
                this.labTestCodeComboBox.SelectedIndex = -1;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(labTestCodeComboBox.Text))
            {
                List<LabTestResults> searchResultList = new List<LabTestResults>();
                try
                {
                    LabTestResults searchResult = this.labTestController.GetSingleLabTestResult(this.labTestCodeComboBox.SelectedValue.ToString(), this.visit.AppointmentID);
                    if (searchResult != null)
                    {
                        searchResultList.Add(searchResult);
                    }
                }
                catch (ArgumentException argumentException)
                {
                    MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                this.labTestResultsDataGridView.DataSource = searchResultList;
            }
            if (!string.IsNullOrWhiteSpace(labTestNameComboBox.Text))
            {
                List<LabTestResults> searchResultList = new List<LabTestResults>();
                try
                {
                    LabTestResults searchResult = this.labTestController.GetSingleLabTestResult(this.labTestNameComboBox.SelectedValue.ToString(), this.visit.AppointmentID);
                    if (searchResult != null)
                    {
                        searchResultList.Add(searchResult);
                    }
                }
                catch (ArgumentException argumentException)
                {
                    MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }               
                this.labTestResultsDataGridView.DataSource = searchResultList;
            }
        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            this.PopulateDataGridView();
            this.resultsLabel.Text = "";
            this.labTestCodeComboBox.SelectedIndex = -1;
            this.labTestNameComboBox.SelectedIndex = -1;
        }

        private void DataGridViewStateChanged_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.labTestResultsDataGridView.Rows.Count == 0)
            {
                this.saveChangesButton.Enabled = false;
                this.resultsLabel.Text = "No results";
                this.ResetForm();
            }
        }

        private void DataGridViewStateChanged_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (!this.finalDiagnosisAdded)
            {
                this.saveChangesButton.Enabled = true;
            }
            this.resultsLabel.Text = "";
        }

        private void ResetForm()
        {
            this.labTestCodeLabel2.Text = "";
            this.nameLabel1.Text = "";
            this.datePerformedDateTimePicker.Checked = false;
            this.isNormalComboBox.Text = "";
            this.resultTextBox.Text = "";
        }
    }
}
