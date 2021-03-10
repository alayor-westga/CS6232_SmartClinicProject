using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartClinic.Controller;
using SmartClinic.Model;

namespace SmartClinic.View
{
    /// <summary>
    /// It renders the form to see the appointment details.
    /// </summary>
    public partial class AppointmentDetailsForm : Form
    {
        private Appointment appointment;
        private readonly DoctorController doctorController;

        /// <summary>
        /// It builds and initializes the appointment view details form.
        /// </summary>
        public AppointmentDetailsForm()
        {
            InitializeComponent();
            doctorController = new DoctorController();
        }

        public void ShowWithAppointment(Appointment appointment) 
        {
            this.appointment = appointment;
            ShowDialog();
        }

        private void AppointmentDetailsForm_Load(object sender, EventArgs e)
        {
            patientIdValueLabel.Text = appointment.PatientId.ToString();
            patientNameValueLabel.Text = appointment.Patient.FullName;
            patientDateOfBirthValueLabel.Text = appointment.Patient.DateOfBirth.ToShortDateString();
            appointmentDatePicker.Value = appointment.Date;
            appointmentTimePicker.Value = appointment.Date;
            PopulateDoctors();
            doctorComboBox.SelectedValue = appointment.DoctorId;
            reasonForVisitTextBox.Text = appointment.Reason;
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
    }
}
