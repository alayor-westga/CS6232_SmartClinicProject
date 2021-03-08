using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;

namespace SmartClinic.UserControls
{
    /// <summary>
    /// It renders the form to search for appointments.
    /// </summary>
    public partial class AppointmentsUserControl : UserControl
    {
        private readonly AppointmentController appointmentController;

        /// <summary>
        /// It builds and initializes the appointment search form.
        /// </summary>
        public AppointmentsUserControl()
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
        }

        private void SearchPatientsButton_Click(object sender, EventArgs e)
        {
            var firstName = patientFirstNameTextBox.Text;
            var lastName = patientLastNameTextBox.Text;
            DateTime? dateOfBirth = null;
            if (patientDateOfBirthDateTimePicker.Checked)
            {
                dateOfBirth = patientDateOfBirthDateTimePicker.Value;        
            }
            List<AppointmentSearchResult> appointments = new List<AppointmentSearchResult>();
            try
            {
                appointments.AddRange(appointmentController.SearchAppointments(firstName, lastName, dateOfBirth));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (appointments.Count > 0)
            {
                resultsReturnedLabel.Text = appointments.Count + " Result(s) Returned";
            }
            else
            {
                resultsReturnedLabel.Text = "";
            }
            appointmentsDataGridView.DataSource = appointments;
        }

        private void ClearSearchFieldsButton_Click(object sender, EventArgs e)
        {
            patientFirstNameTextBox.Text = "";
            patientLastNameTextBox.Text = "";
            patientDateOfBirthDateTimePicker.Checked = false;
            resultsReturnedLabel.Text = "";
            appointmentsDataGridView.DataSource = null;
        }

        private void AppointmentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (appointmentsDataGridView.SelectedRows.Count > 0)
            {
                viewAppointmentButton.Enabled = true;
                deleteAppointmentButton.Enabled = true;
            }
            else
            {
                viewAppointmentButton.Enabled = false;
                deleteAppointmentButton.Enabled = false;
            }
        }
    }
}
