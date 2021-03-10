using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;
using SmartClinic.View;

namespace SmartClinic.UserControls
{
    /// <summary>
    /// It renders the form to search for appointments.
    /// </summary>
    public partial class AppointmentsUserControl : UserControl
    {
        private readonly AppointmentDetailsForm appointmentDetailsForm;
        private readonly AppointmentController appointmentController;

        /// <summary>
        /// It builds and initializes the appointment search form.
        /// </summary>
        public AppointmentsUserControl()
        {
            InitializeComponent();
            appointmentDetailsForm = new AppointmentDetailsForm();
            appointmentController = new AppointmentController();
        }

        private void SearchPatientsButton_Click(object sender, EventArgs e)
        {
            SearchAppointments();
        }

        private void SearchAppointments()
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

        private void ViewAppointmentButton_Click(object sender, EventArgs e)
        {
            openAppoinmentDetailsDialog();
        }

        private void openAppoinmentDetailsDialog()
        {
            AppointmentSearchResult appointmentSearchResult = (AppointmentSearchResult)appointmentsDataGridView.SelectedRows[0].DataBoundItem;
            appointmentDetailsForm.ShowWithAppointment(appointmentSearchResult.Appointment);
            SearchAppointments();
        }

        private void AppointmentsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            openAppoinmentDetailsDialog();
        }
    }
}
