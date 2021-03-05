﻿using System;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;

namespace SmartClinic.View
{
    public partial class LoginForm : Form
    {
        private readonly NurseController nurseController;
        public LoginForm()
        {
            InitializeComponent();
            nurseController = new NurseController();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            Nurse nurse = nurseController.Login(username, password);
            if (nurse == null) {
                errorMessageLabel.Text = "Invalid credentials";
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
    }
}