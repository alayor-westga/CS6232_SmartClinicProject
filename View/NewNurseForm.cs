using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Windows.Forms;

namespace SmartClinic.View
{
    public partial class NewNurseForm : Form, ClinicPersonAddedListener
    {
        private readonly NurseController nurseController;

        public NewNurseForm()
        {
            InitializeComponent();
            nurseController = new NurseController();
        }

        private void NewNurseForm_Load(object sender, EventArgs e)
        {
            newClinicPersonUserControl1.SetClinicPerson(new Nurse());
            newClinicPersonUserControl1.AddClinicPersonAddedListener(this);
        }

        void ClinicPersonAddedListener.OnAdded(ClinicPerson clinicPerson)
        {
            MessageBox.Show("The nurse was successfully added to the database.",
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
