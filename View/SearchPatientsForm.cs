using System;
using System.Windows.Forms;
using SmartClinic.Model;

namespace SmartClinic.View
{
    /// <summary>
    /// It shows the search patient form.
    /// </summary>
    public partial class SearchPatientsForm : Form, SelectionListener<Patient>
    {
        private Patient patient;

        /// <summary>
        /// It builds and initializes the search patient form.
        /// </summary>
        public SearchPatientsForm()
        {
            InitializeComponent();
            searchPatientsUserControl.AddSelectionListener(this);
            patient = null;
            Console.WriteLine("In SPF");

        }

        /// <summary>
        /// It sets and gets the selected patient from the grid view.
        /// </summary>
        public Patient SelectedPatient { get; set; }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            patient = null;
            Close();
        }

        void SelectionListener<Patient>.OnSelect(Patient selectedValue)
        {
            patient = selectedValue;
            selectPatientButton.Enabled = true;
        }

        void SelectionListener<Patient>.OnDoubleClickSelect(Patient selectedValue)
        {
            patient = selectedValue;
            SelectAndClose();
        }

        void SelectionListener<Patient>.OnSelectionCleared()
        {
            selectPatientButton.Enabled = false;
        }

        private void SelectPatientButton_Click(object sender, EventArgs e)
        {
            SelectAndClose();
        }

        private void SelectAndClose()
        {
            DialogResult = DialogResult.OK;
            SelectedPatient = patient;
            Close();
        }
    }
}
