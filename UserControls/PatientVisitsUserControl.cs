using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;
using SmartClinic.View;

namespace SmartClinic.UserControls
{
    /// <summary>
    /// It renders the form to search show patient visits.
    /// </summary>
    public partial class PatientVisitsUserControl : UserControl
    {
        private Patient selectedPatient;   
        private readonly PatientVisitController patientVisitController;

        /// <summary>
        /// It builds and initializes the patient visits user control.
        /// </summary>
        public PatientVisitsUserControl()
        {
            InitializeComponent();
            patientVisitController = new PatientVisitController();
        }

        private void SearchAppointments()
        {
            List<PatientVisits> appointments = new List<PatientVisits>();
            try
            {
                appointments.AddRange(patientVisitController.GetPatientVisitsByPatientId(selectedPatient.PatientId));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            patientVisitsDataGridView.DataSource = appointments;
            searchMessageLabel.Text = appointments.Count > 0 ?
                appointments.Count + " Result(s) Returned" :
                "No Results Returned";
        }

        private void ClearSearchFieldsButton_Click(object sender, EventArgs e)
        {
            patientVisitsDataGridView.DataSource = null;
        }

        private void AppointmentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (patientVisitsDataGridView.SelectedRows.Count > 0)
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
            PatientVisits patientVisits = (PatientVisits)patientVisitsDataGridView.SelectedRows[0].DataBoundItem;
            using (PatientVisitDetailsForm patientVisitDetailsForm = new PatientVisitDetailsForm())
            {
                patientVisitDetailsForm.ShowForExistingPatientVisit(patientVisits);
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
                searchPatientsForm.ShowDialog();
                if (searchPatientsForm.SelectedPatient != null)
                {
                    selectedPatient = searchPatientsForm.SelectedPatient;
                    ShowPatientInfo();
                    SearchAppointments();
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
                    }
                }
            }           
        }
    }
}