using System;
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
            String username = this.userNameTextBox.Text;
            String password = this.passwordTextBox.Text;
            nurseController.Login(username, password);
        }
    }
}
