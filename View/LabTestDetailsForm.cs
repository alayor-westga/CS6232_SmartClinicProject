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
            this.datePerformedDateTimePicker.Text = String.Empty;
            this.labTestListBox.ClearSelected();
            this.PopulateForm();
        }

        private void PopulateForm()
        {
            this.patientIDDisplayLabel.Text = this.visit.PatientID.ToString();
            this.patientNameDisplayLabel.Text = this.visit.Patient.ToString();
            this.apptDateTimeDisplayLabel.Text = this.visit.VisitDate.ToString();
            this.appointmentIDLabel2.Text = this.visit.AppointmentID.ToString();
            this.labTestResultsDataGridView.DataSource = this.labTestController.GetAllLabTests(); //test code
           
        }

        private void orderTestButton_Click(object sender, EventArgs e)
        {

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


    }
}
