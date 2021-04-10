using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Windows.Forms;

namespace SmartClinic.View
{
    public partial class NurseAccessCredentialsForm : Form
    {
        private readonly NurseController nurseController;
        private Nurse nurse;
        public NurseAccessCredentialsForm()
        {
            InitializeComponent();
            nurseController = new NurseController();
        }


        /// <summary>
        /// It renders the form for nurse.
        /// <param name="nurse">The nurse to be updated.</param>
        /// </summary>
        public void ShowForNurse(Nurse nurse)
        {
            this.nurse = nurse;
            nurseIdValueLabel.Text = nurse.NurseId.ToString();
            nurseNameValueLabel.Text = nurse.FullName;
            userNameTextBox.Text = nurse.UserName;
            ShowDialog();
        }

        private void SetCredentialsButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) 
            {
                return;
            }
            try
            {
                bool result = nurseController.SetUserNameAndPassword(
                    nurse.NurseId,
                    userNameTextBox.Text,
                    passwordTextBox.Text,
                    nurse.UserName
                );
                if (result)
                {
                    MessageBox.Show("The credentials has been updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("The credentials could not be updated.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show(argumentException.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("The credentials could not be updated.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool ValidateFields()
        {
            bool isValid = true;
            if (String.IsNullOrWhiteSpace(userNameTextBox.Text))
            {
                isValid = false;
                userNameErrorLabel.Text = "this field is required";
            }
            if (String.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                isValid = false;
                passwordErrorLabel.Text = "this field is required";
            }
            if (String.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                isValid = false;
                confirmPasswordErrorLabel.Text = "this field is required";
            }
            if (!String.Equals(passwordTextBox.Text, confirmPasswordTextBox.Text))
            {
                isValid = false;
                passwordErrorLabel.Text = "passwords do not match";
                confirmPasswordErrorLabel.Text = "passwords do not match";
            }
            return isValid;
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            userNameErrorLabel.Text = "";
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordErrorLabel.Text = "";
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmPasswordErrorLabel.Text = "";
        }
    }
}
