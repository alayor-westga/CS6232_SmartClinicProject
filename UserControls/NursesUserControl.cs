using System;
using SmartClinic.Controller;
using SmartClinic.Model;
using SmartClinic.View;
using System.Windows.Forms;

namespace SmartClinic.UserControls
{
    public partial class NursesUserControl : UserControl
    {
        private readonly NurseController nurseController;
        public NursesUserControl()
        {
            InitializeComponent();
            nurseController = new NurseController();
        }

        private void NewNurseButton_Click(object sender, EventArgs e)
        {
            using (NewNurseForm newNurseForm = new NewNurseForm())
            {
                newNurseForm.ShowDialog();
            }
        }

        private void NursesUserControl_Load(object sender, EventArgs e)
        {
            GetNurses();
        }

        private void GetNurses()
        {
            nursesDataGridView.DataSource = nurseController.GetAllNurses();
        }
    }
}
