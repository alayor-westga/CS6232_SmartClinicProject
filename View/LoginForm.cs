using System;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;

namespace SmartClinic.View
{
    /// <summary>
    /// It renders the login form.
    /// </summary>
    public partial class LoginForm : Form
    {
        //private readonly MainDashboard mainDashboard;
        private readonly NurseController nurseController;
        private static Nurse nurse;

        /// <summary>
        /// It builds and initializes the login form.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            nurseController = new NurseController();
            //mainDashboard = new MainDashboard(this);
            Console.WriteLine("LoginForm");

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            nurse = nurseController.Login(username, password);
            if (nurse == null) {
                errorMessageLabel.Text = "Invalid credentials";
            } else {
                using (MainDashboard mainDashboard = new MainDashboard(this))
                {
                    mainDashboard.SetNurse(nurse);
                    Hide();
                    mainDashboard.ShowDialog();
                }            
            }
        }

        private bool ValidateFields()
        {
            var isValid = true;
            if (userNameTextBox.Text.Length == 0)
            {
                isValid = false;
                userNameErrorLabel.Text = "This field is required";
            }
            if (passwordTextBox.Text.Length == 0)
            {
                isValid = false;
                passwordErrorLabel.Text = "This field is required";
            }
            return isValid;
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
            userNameErrorLabel.Text = "";
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            errorMessageLabel.Text = "";
            passwordErrorLabel.Text = "";
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public static Nurse GetNurse()
        {
            return LoginForm.nurse;
        }
    }
}
