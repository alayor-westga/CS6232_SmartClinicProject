﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;
using SmartClinic.View;

namespace SmartClinic.UserControls
{
    /// <summary>
    /// It renders the form to create appointments.
    /// </summary>
    public partial class NewAppointmentUserControl : UserControl
    {
        private Patient selectedPatient;
        private readonly DoctorController doctorController;
        private readonly AppointmentController appointmentController;

        /// <summary>
        /// It builds and initializes the new appointment user control.
        /// </summary>        
        public NewAppointmentUserControl()
        {
            InitializeComponent();
            doctorController = new DoctorController();
            appointmentController = new AppointmentController();
        }

        private void NewAppointmentUserControl_Load(object sender, EventArgs e)
        {
            PopulateDoctors();
            Clear();
            appointmentDatePicker.Value = DateTime.Now;
            appointmentTimePicker.Value = DateTime.Parse("1970-01-01 09:00 AM");
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

        private void DisableNewAppointmentSection()
        {
            selectedPatient = null;
            newAppoinmentGroupBox.Text = "New Appointment For -";
            newAppoinmentGroupBox.Enabled = false;
            appointmentDatePicker.CustomFormat = " ---";
            appointmentTimePicker.CustomFormat = " ---";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            ClearPatientInfo();
            ClearNewAppointmentForm();
            DisableNewAppointmentSection();
        }

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            if (!ValidateAppointmentFields())
            {
                return;
            }
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
                Clear();
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

        private bool ValidateAppointmentFields()
        {
            bool isValid = true;
            if (appointmentDatePicker.Text.Equals(" ---"))
            {
                appointmentDateErrorLabel.Text = "This field is required.";
                isValid = false;
            }
            if (appointmentTimePicker.Text.Equals(" ---"))
            {
                appointmentTimeErrorLabel.Text = "This field is required.";
                isValid = false;
            }
            if (doctorComboBox.SelectedIndex == 0)
            {
                appointmentDoctorErrorLabel.Text = "This field is required.";
                isValid = false;
            }
            if (reasonForVisitTextBox.Text == "")
            {
                appointmentReasonErrorLabel.Text = "This field is required.";
                isValid = false;
            }
            return isValid;
        }

        private void ClearPatientInfo()
        {
            patientIdValueLabel.Text = "-";
            patientFullNameValueLabel.Text = "-";
            patientDateOfBirthValueLabel.Text = "-";
            patientAddressValueLabel.Text = "-";
        }

        private void ClearNewAppointmentForm()
        {
            doctorComboBox.SelectedIndex = 0;
            reasonForVisitTextBox.Text = "";
            appointmentDateErrorLabel.Text = "";
            appointmentTimeErrorLabel.Text = "";
            appointmentDoctorErrorLabel.Text = "";
            appointmentReasonErrorLabel.Text = "";
        }

        private void SearchPatientButton_Click(object sender, EventArgs e)
        {
            using (SearchPatientsForm searchPatientsForm = new SearchPatientsForm())
            {
                DialogResult result = searchPatientsForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (searchPatientsForm.SelectedPatient != null)
                    {
                        SetPatientAndEnableAddAppointment(searchPatientsForm.SelectedPatient);
                        ShowPatientInfo();
                    }
                }
            }           
        }

        private void AppointmentDatePicker_MouseDown(object sender, MouseEventArgs e)
        {
            appointmentDatePicker.CustomFormat = "MM/dd/yyyy";
            appointmentDateErrorLabel.Text = "";
        }

        private void AppointmentTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            appointmentTimePicker.CustomFormat = "hh:mm tt";
            appointmentTimeErrorLabel.Text = "";
        }

        private void DoctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            appointmentDoctorErrorLabel.Text = "";
        }

        private void ReasonForVisitTextBox_TextChanged(object sender, EventArgs e)
        {
            appointmentReasonErrorLabel.Text = "";
        }

        private void ShowPatientInfo()
        {
            patientIdValueLabel.Text = selectedPatient.PatientId.ToString();
            patientFullNameValueLabel.Text = selectedPatient.FullName;
            patientDateOfBirthValueLabel.Text = selectedPatient.DateOfBirth.ToShortDateString();
            patientAddressValueLabel.Text = selectedPatient.Address;
        }

        private void NewPatientButton_Click(object sender, EventArgs e)
        {
            using (NewPatientForm newPatientForm = new NewPatientForm())
            {
                DialogResult result = newPatientForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (newPatientForm.SelectedPatient != null)
                    {
                        SetPatientAndEnableAddAppointment(newPatientForm.SelectedPatient);
                    }
                }
            }          
        }

        private void SetPatientAndEnableAddAppointment(Patient patient)
        {
            selectedPatient = patient;
            ShowPatientInfo();
            newAppoinmentGroupBox.Text = "New Appointment For " + selectedPatient.FirstName + " " + selectedPatient.LastName;
            newAppoinmentGroupBox.Enabled = true;
        }
    }
}
