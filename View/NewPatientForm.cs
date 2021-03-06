﻿using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Windows.Forms;

namespace SmartClinic.View
{
    /// <summary>
    /// It shows the new patient form.
    /// </summary>
    public partial class NewPatientForm : Form, ClinicPersonAddedListener
    {
        private readonly PatientController patientController;

        /// <summary>
        /// It builds and initializes the new patient form.
        /// </summary>
        public NewPatientForm()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        /// <summary>
        /// It is the new created patient.
        /// </summary>
        public Patient SelectedPatient { get; set; }

        void ClinicPersonAddedListener.OnAdded(ClinicPerson clinicPerson)
        {
            Patient patient = (Patient)(clinicPerson);
            patient.PatientId = clinicPerson.DerivedClinicPersonID;
            SelectedPatient = patient;
            MessageBox.Show("The patient was successfully added to the database.",
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void NewPatientForm_Load(object sender, EventArgs e)
        {
            newClinicPersonUserControl1.SetClinicPerson(new Patient());
            newClinicPersonUserControl1.AddClinicPersonAddedListener(this);
        }
    }
}
