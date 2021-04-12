using SmartClinic.Controller;
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

        public LabTestDetailsForm(PatientVisits visit)
        {
            InitializeComponent();
            this.labTestController = new LabTestController();
            this.visit = visit;

        }

        private void ThisFormLoad_Load(object sender, EventArgs e)
        {
            this.labTestListBox.DataSource = this.labTestController.GetAllLabTests();
            this.datePerformedDateTimePicker.Checked = false;
            this.datePerformedDateTimePicker.Text = "";
            this.labTestListBox.ClearSelected();
            this.PopulateForm();
            this.PopulateDataGridView();
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

            this.labTestCodeLabel2.Text = this.labTestResultsDataGridView.CurrentRow.Cells[0].Value.ToString();
            this.nameLabel1.Text = this.labTestResultsDataGridView.CurrentRow.Cells[0].Value.ToString();
            Console.WriteLine(labTestResultsDataGridView.CurrentRow.Cells[1].Value);
            try
            {
                this.datePerformedDateTimePicker.Checked = true;
                this.datePerformedDateTimePicker.Value = (DateTime)labTestResultsDataGridView.CurrentRow.Cells[1].Value;
            }
            catch (ArgumentOutOfRangeException)
            {
                this.datePerformedDateTimePicker.Text = "";
            }

            var senderGrid = (DataGridView)sender;
            senderGrid.EndEdit();
            var checkboxCell = (DataGridViewCheckBoxCell)senderGrid.CurrentRow.Cells[3];
            if ((bool)checkboxCell.Value)
            {
                this.isNormalComboBox.Text = "normal";
            }
            else if (!(bool)checkboxCell.Value && this.labTestResultsDataGridView.CurrentRow.Cells[2].Value.ToString() != "")
            {
                this.isNormalComboBox.Text = "abnormal";
            }
            else
            {
                this.isNormalComboBox.Text = "";
            }
            this.resultTextBox.Text = this.labTestResultsDataGridView.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
