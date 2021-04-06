using System;
using SmartClinic.Controller;
using SmartClinic.Model;
using SmartClinic.View;
using System.Windows.Forms;

namespace SmartClinic.UserControls
{
    public partial class NursesUserControl : UserControl
    {
        public NursesUserControl()
        {
            InitializeComponent();
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
