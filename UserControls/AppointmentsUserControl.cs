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
    public partial class AppointmentsUserControl : UserControl, IRefreshable
    {
        private Patient selectedPatient;      
        private readonly AppointmentController appointmentController;

        /// <summary>
        /// It builds and initializes the appointment search form.
        /// </summary>
        public AppointmentsUserControl()
        {
            InitializeComponent();           
            appointmentController = new AppointmentController();
        }

        /// <summary>
        /// It refreshes the appointments gridview.
        /// </summary>
        override public void Refresh()
        {
            SearchAppointments();
        }

        private void SearchAppointments()
        {
            if (selectedPatient == null) 
            {
                return;
            }
            List<AppointmentSearchResult> appointments = new List<AppointmentSearchResult>();
            try
            {
                appointments.AddRange(appointmentController.GetAppointmentsByPatientId(selectedPatient.PatientId));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            appointmentsDataGridView.DataSource = appointments;
            searchMessageLabel.Text = appointments.Count > 0 ?
                appointments.Count + " Result(s) Returned" :
                "No Results Returned";
        }

        private void ClearSearchFieldsButton_Click(object sender, EventArgs e)
        {
            appointmentsDataGridView.DataSource = null;
        }

        private void AppointmentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (appointmentsDataGridView.SelectedRows.Count > 0)
            {
                viewAppointmentButton.Enabled = true;
            }
            else
            {
                viewAppointmentButton.Enabled = false;
            }
        }

        private void ViewAppointmentButton_Click(object sender, EventArgs e)
        {
            OpenAppoinmentDetailsDialog();
        }

        private void OpenAppoinmentDetailsDialog()
        {
            AppointmentSearchResult appointmentSearchResult = (AppointmentSearchResult)appointmentsDataGridView.SelectedRows[0].DataBoundItem;
            using (AppointmentDetailsForm appointmentDetailsForm = new AppointmentDetailsForm())
            {
                appointmentDetailsForm.ShowWithAppointment(appointmentSearchResult.Appointment);
            }
            SearchAppointments();
        }

        private void AppointmentsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            OpenAppoinmentDetailsDialog();
        }

        private void SearchPatientButton_Click(object sender, EventArgs e)
        {
            using (SearchPatientsForm searchPatientsForm = new SearchPatientsForm())
            {
                DialogResult result = searchPatientsForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (searchPatientsForm.SelectedPatient != null)
                    {
                        selectedPatient = searchPatientsForm.SelectedPatient;
                        ShowPatientInfo();
                        SearchAppointments();
                    }
                }
            }          
        }

        private void ShowPatientInfo()
        {
            patientIdValueLabel.Text = selectedPatient.PatientId.ToString();
            patientFullNameValueLabel.Text = selectedPatient.FullName;
            patientDateOfBirthValueLabel.Text = selectedPatient.DateOfBirth.ToShortDateString();
            patientAddressValueLabel.Text = selectedPatient.Address;
        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {
            using (NewPatientForm newPatientForm = new NewPatientForm())
            {
                DialogResult result = newPatientForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (newPatientForm.SelectedPatient != null)
                    {
                        selectedPatient = newPatientForm.SelectedPatient;
                        ShowPatientInfo();
                        SearchAppointments();
                    }
                }
            }          
        }
    }
}
