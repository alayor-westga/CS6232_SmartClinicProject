using System;
using SmartClinic.Controller;
using SmartClinic.Model;
using SmartClinic.View;
using System.Windows.Forms;

namespace SmartClinic.UserControls
{
    public partial class NursesUserControl : UserControl
    {
        private Nurse selectedNurse;
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

        private void NursesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (nursesDataGridView.SelectedRows.Count > 0)
            {
                selectedNurse = (Nurse) nursesDataGridView.SelectedRows[0].DataBoundItem;
                setCredentialsButton.Enabled = true;
                if (selectedNurse.HasCredentialsSet)
                {
                    setCredentialsButton.Text = "Update Access Credentials";
                }
                else
                {
                    setCredentialsButton.Text = "Set Access Credentials";
                }
            }
            else
            {
                setCredentialsButton.Enabled = false;
            }
        }

        private void SetCredentialsButton_Click(object sender, EventArgs e)
        {
            using (NurseAccessCredentialsForm nurseAccessCredentialsForm = new NurseAccessCredentialsForm())
            {
                nurseAccessCredentialsForm.ShowForNurse(selectedNurse);
            }
        }
    }
}
