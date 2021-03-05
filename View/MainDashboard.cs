using System;
using System.Windows.Forms;
using SmartClinic.Model;

namespace SmartClinic.View
{
    /// <summary>
    /// It renders the main dashboard for logged-in users.
    /// </summary>
    public partial class MainDashboard : Form
    {
        private readonly Form loginForm;
        private Nurse nurse;
        /// <summary>
        /// It builds and initializes the main dashboard.
        /// </summary>
        public MainDashboard(Form loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        /// <summary>
        /// It sets the nurse property.
        /// </summary>
        public void SetNurse(Nurse nurse)
        {
            this.nurse = nurse;
            personNameLabel.Text = nurse.FirstName + " " + nurse.LastName;
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
    }
}
