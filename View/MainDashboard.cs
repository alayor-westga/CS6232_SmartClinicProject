﻿using System;
using System.Windows.Forms;
using SmartClinic.Model;
using SmartClinic.UserControls;

namespace SmartClinic.View
{
    /// <summary>
    /// It renders the main dashboard for logged-in users.
    /// </summary>
    public partial class MainDashboard : Form
    {
        private readonly Form loginForm;
        private readonly Form newAppointmentForm;
        private readonly Form newPatientForm;
        private Nurse nurse;

        /// <summary>
        /// It builds and initializes the main dashboard.
        /// </summary>
        public MainDashboard(Form loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            newAppointmentForm = new NewAppointmentForm();
            newPatientForm = new NewPatientForm();
            searchPatientsUserControl1.ChangeFormMode(SearchPatientsUserControl.SearchFormMode.SearchAndEdit);
            Console.WriteLine("MainDashboard");

        }

        /// <summary>
        /// It sets the nurse property.
        /// </summary>
        public void SetNurse(Nurse nurse)
        {
            this.nurse = nurse;
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
            newAppointmentForm.ShowDialog();
        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {
            newPatientForm.ShowDialog();
        }
    }
}
