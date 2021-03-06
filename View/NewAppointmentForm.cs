﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;

namespace SmartClinic.View
{
    /// <summary>
    /// It renders the for to create appointments for patients.
    /// </summary>
    public partial class NewAppointmentForm : Form
    {
        private readonly PatientController patientController; 
        private readonly DoctorController doctorController;
        private readonly AppointmentController appointmentController;

        private Patient selectedPatient;

        /// <summary>
        /// It builds and initializes the new appointment form.
        /// </summary>
        public NewAppointmentForm()
        {
            InitializeComponent();
            patientController = new PatientController();
            doctorController = new DoctorController();
            appointmentController = new AppointmentController();
        }

        private void NewAppointmentForm_Load(object sender, EventArgs e)
        {
            patientIdNumericUpdown.Text = "";
            patientIdNumericUpdown.Controls[0].Visible = false;
            PopulateDoctors();
        }

        private void PopulateDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            try
            {
                doctors.Add(new Doctor()
                {
                    DoctorId = -1,
                    FirstName = "-- Select a doctor --"
                });
                doctors.AddRange(doctorController.GetAll());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("The doctor list could not get loaded.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            doctorComboBox.DataSource = doctors;
        }

        private void SearchPatientsButton_Click(object sender, EventArgs e)
        {
            var firstName = patientFirstNameTextBox.Text;
            var lastName = patientLastNameTextBox.Text;
            var patientId = patientIdNumericUpdown.Text == "" ? 0 : (int) patientIdNumericUpdown.Value;
            DateTime? dateOfBirth = null;
            if (patiendDateOfBirthDateTimePicker.Checked)
            {
                dateOfBirth = patiendDateOfBirthDateTimePicker.Value;        
            }
            List<Patient> patients = new List<Patient>();
            try
            {
                patients.AddRange(patientController.SearchPatients(firstName, lastName, patientId, dateOfBirth));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            patientsDataGridView.DataSource = patients;
        }

        private void ClearSearchFieldsButton_Click(object sender, EventArgs e)
        {
            ClearSearchForm();
        }
        private void ClearSearchForm()
        {
            patientFirstNameTextBox.Text = "";
            patientLastNameTextBox.Text = "";
            patientIdNumericUpdown.Text = "";
            patiendDateOfBirthDateTimePicker.Checked = false;
            patientsDataGridView.DataSource = null;
        }

        private void PatientsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (patientsDataGridView.SelectedRows.Count > 0)
            {
                selectedPatient = (Patient)patientsDataGridView.SelectedRows[0].DataBoundItem;
                newAppoinmentGroupBox.Text = "New Appointment For " + selectedPatient.FirstName + " " + selectedPatient.LastName;
                newAppoinmentGroupBox.Enabled = true;
            } else
            {
                DisableNewAppointmentSection();
            }
        }

        private void DisableNewAppointmentSection()
        {
            selectedPatient = null;
            newAppoinmentGroupBox.Text = "New Appointment For -";
            newAppoinmentGroupBox.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            string dateString = appointmentDatePicker.Value.ToShortDateString();
            string timeString = appointmentTimePicker.Value.ToShortTimeString();
            Appointment newAppointment = new Appointment()
            {
                PatientId = selectedPatient.PatientId,
                Date = DateTime.Parse(dateString + " " + timeString),
                DoctorId = int.Parse(doctorComboBox.SelectedValue.ToString()),
                Reason = reasonForVisitTextBox.Text,
            };
            try
            {
                appointmentController.Create(newAppointment);
                MessageBox.Show("A new apointment has been created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSearchForm();
                ClearNewAppointmentForm();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("The appointment could not be created.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ClearNewAppointmentForm()
        {
            doctorComboBox.SelectedIndex = 0;
            reasonForVisitTextBox.Text = "";
        }
    }
}
