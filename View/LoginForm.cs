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
        private readonly LoginController loginController;

        /// <summary>
        /// It builds and initializes the login form.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            try
            {
                Nurse nurse = loginController.Login(username, password);
                if (nurse == null)
                {
                    errorMessageLabel.Text = "Invalid credentials";
                }
                else
                {
                    using (MainDashboard mainDashboard = new MainDashboard(this))
                    {
                        Hide();
                        mainDashboard.ShowDialog();
                    }
                }
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
