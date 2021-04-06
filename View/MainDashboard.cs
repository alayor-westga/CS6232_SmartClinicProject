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
            ShowNursesTab();
        }

        /// <summary>
        /// It sets the nurse property.
        /// </summary>
        private void ShowUserName()
        {
            User user = LoginController.GetUser();
            userNameLabel.Text = user.FullName + " (" + user.UserName + ")";
        }

        private void ShowNursesTab()
        {
            mainDashBoardTabControl.TabPages.Remove(nursesTabPage);
            User user = LoginController.GetUser();
            if (user.Role == UserRole.Admin)
            {
                mainDashBoardTabControl.TabPages.Add(nursesTabPage);
            }
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

        private void NewPatientButton_Click(object sender, EventArgs e)
        {
            using (NewPatientForm newPatientForm = new NewPatientForm())
            {
                newPatientForm.ShowDialog();
            }
        }

        private void NewNurseButton_Click(object sender, EventArgs e)
        {
            using (NewNurseForm newNurseForm = new NewNurseForm())
            {
                newNurseForm.ShowDialog();
            }
        }
    }
}
