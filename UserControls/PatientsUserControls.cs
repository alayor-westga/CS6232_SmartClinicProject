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

namespace SmartClinic.UserControls
{
    public partial class PatientsUserControls : UserControl
    {
        private readonly PatientController patientController;
        public PatientsUserControls()
        {
            InitializeComponent();
            this.patientController = new PatientController();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
      
            DateTime? dateOfBirth = null;
            if (dobSearchPicker.Checked)
            {
                dateOfBirth = dobSearchPicker.Value;
            }
            List<Patient> patients = new List<Patient>();
            try
            {
                patients.AddRange(patientController.SearchPatients(firstName, lastName, dateOfBirth));
                this.searchMessageLabel.Text = patients.Count.ToString() + " result(s) returned";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            patientDataGridView.DataSource = patients;
        }

        private void SelectRow_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("it worked");
        }
    }
}
