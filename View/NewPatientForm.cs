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
    public partial class NewPatientForm : Form
    {
        private readonly PatientController patientController;
        public NewPatientForm()
        {
            InitializeComponent();
            this.patientController = new PatientController();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClinicPerson newPatient = new ClinicPerson();
                newPatient.DateOfBirth = DateTime.Parse(this.dob.Text);
                newPatient.FirstName = this.firstNameTextBox.Text;
                newPatient.LastName = this.lastNameTextBox.Text;
                newPatient.Street1 = this.address1TextBox.Text;
                newPatient.Street2 = this.address2TextBox.Text;
                newPatient.City = this.cityTextBox.Text;
                newPatient.State = this.stateTextBox.Text;
                newPatient.ZipCode = Int32.Parse(this.zipCodeTextBox.Text);
                newPatient.Phone = Int32.Parse(this.phoneTextBox.Text);

                this.patientController.addPatient(newPatient);

                MessageBox.Show("The patient was successfully added to the database.",
                        "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException argumentException)
            {
                this.DisplayError(argumentException);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void DisplayError(Exception errorMessage)
        {
            MessageBox.Show(errorMessage.Message,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }


}
