using SmartClinic.Controller;
using SmartClinic.Model;
using SmartClinic.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartClinic.UserControls
{
    public partial class PatientsUserControls : UserControl
    {
        private int rowIndexForDataGridView;
        private readonly PatientController patientController;
        public PatientsUserControls()
        {
            InitializeComponent();
            this.patientController = new PatientController();
            this.rowIndexForDataGridView = 0;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;

            DateTime? dateOfBirth = null;
            if (dobSearchPicker.Checked)
            {
                dateOfBirth = dobSearchPicker.Value;
            }
            List<Patient> patients = new List<Patient>();
            try
            {
                patients.AddRange(patientController.SearchPatients(firstName, lastName, dateOfBirth));
                this.searchMessageLabel.Text = patients.Count.ToString() + " result(s) returned";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            patientDataGridView.DataSource = patients;
        }

        private void SelectRow_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.viewOrEditPatientDetailsButton.PerformClick();
        }

        private void DeletePatientButton_Click(object sender, EventArgs e)
        {
            if (this.patientDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("There is no patient to delete.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int patientID = Int32.Parse(patientDataGridView.Rows[patientDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());

            DialogResult dialogResultVerifyClose = MessageBox.Show("Are you sure you want to delete this patient?\n" +
               "This cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResultVerifyClose == DialogResult.Yes)
            {
                if (this.patientController.PatientHasNoAppointments(patientID))
                {
                    //need try-catch
                    this.patientController.DeletePatient(patientID);
                    this.searchButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("This patient has associated appointments\nand cannot be deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.patientDataGridView.DataSource = null;
            this.dobSearchPicker.Value = DateTime.Now;
            this.dobSearchPicker.Checked = false;
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.searchMessageLabel.Text = "";
        }

        private void SearchTermsValueChanged(object sender, EventArgs e)
        {
            this.patientDataGridView.DataSource = null;
            this.searchMessageLabel.Text = "";
        }

        private void ViewOrEditPatientDetailsButton_Click(object sender, EventArgs e)
        {
            if (this.patientDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("There is no patient to select.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int patientID = Int32.Parse(this.patientDataGridView.Rows[patientDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            using (Form updateForm = new UpdatePatient(patientID))
            {
                DialogResult result = updateForm.ShowDialog();
                this.searchButton.PerformClick();

            }
        }

        private void PatientsTable_RighClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                this.patientDataGridView.Rows[e.RowIndex].Selected = true;
                this.rowIndexForDataGridView = e.RowIndex;
                this.patientDataGridView.CurrentCell = this.patientDataGridView.Rows[e.RowIndex].Cells[1];
                this.RightClickMenu.Show(this.patientDataGridView, e.Location);
                RightClickMenu.Show(Cursor.Position);
            }
        }

        private void ContextMenuForDataGridView_Click(object sender, MouseEventArgs e)
        {
            if (!this.patientDataGridView.Rows[this.rowIndexForDataGridView].IsNewRow)
            {
                this.deletePatientButton.PerformClick();
            }
        }
    }
}
