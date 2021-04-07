using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Windows.Forms;

namespace SmartClinic.View
{
    public partial class NurseAccessCredentialsForm : Form
    {
        private Nurse nurse;
        public NurseAccessCredentialsForm()
        {
            InitializeComponent();
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
            usernameTextBox.Text = nurse.UserName;
            ShowDialog();
        }

    }
}
