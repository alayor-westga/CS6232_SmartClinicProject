using System;
using System.Windows.Forms;
using SmartClinic.Model;
using SmartClinic.UserControls;
using SmartClinic.Controller;

namespace SmartClinic.View
{
    /// <summary>
    /// It renders the main dashboard for logged-in users.
    /// </summary>
    public partial class MainDashboard : Form
    {
        private readonly Form loginForm;

        /// <summary>
        /// It builds and initializes the main dashboard.
        /// </summary>
        public MainDashboard(Form loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            searchPatientsUserControl1.ChangeFormMode(SearchPatientsUserControl.SearchFormMode.SearchAndEdit);
            ShowUserName();
        }

        /// <summary>
        /// It sets the nurse property.
        /// </summary>
        private void ShowUserName()
        {
            Nurse nurse = LoginController.GetNurse();
            userNameLabel.Text = nurse.FullName + " (" + nurse.UserName + ")";
        }

        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            loginForm.Show();
        }

        private void NewAppointmentButton_Click(object sender, EventArgs e)
        {
            using (NewAppointmentForm newAppointmentForm = new NewAppointmentForm())
            {
                newAppointmentForm.ShowDialog();
            }
           
        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {
            using (NewPatientForm newPatientForm = new NewPatientForm())
            {
                newPatientForm.ShowDialog();
            }
        }
    }
}
