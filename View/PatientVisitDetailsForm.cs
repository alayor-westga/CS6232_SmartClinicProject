

using SmartClinic.Controller;
using SmartClinic.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartClinic.View
{
    public partial class PatientVisitDetailsForm : Form
    {
        private int appointmentID;
        private PatientVisits visit;
        private readonly AppointmentController appointmentController;
        public PatientVisitDetailsForm()
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
            this.visit = new PatientVisits();
        }

        public void ShowForPatientVisit(int appointmentID)
        {

            this.appointmentID = appointmentID;
            GetVisitFromDB();
            PopulateForm();
            ShowDialog();
        }

        private void GetVisitFromDB()
        {
            this.visit = this.appointmentController.GetVisitFromDB(this.appointmentID);
        }

        private void PopulateForm()
        {
            this.apptIDTextBox.Text = this.visit.AppointmentID.ToString();
            this.patientIDTextBox.Text = this.visit.PatientID.ToString();
            //this.patientNameTextBox.Text = this.visit.Patient.ToString();
            //this.doctorTextBox.Text = this.visit.Doctor.ToString();
            //this.nurseTextBox.Text = this.visit.Nurse.ToString();
            //this.appointmentDateTextBox.Text = this.visit.VisitDate.ToString();



           
            MakeAllFieldsReadOnly();
        }

        private void MakeAllFieldsReadOnly()
        {
            
            //firstNameTextBox.ReadOnly = true;
            
        }

        private void EditPatientButton_Click(object sender, EventArgs e)
        {
            
            //lastNameTextBox.ReadOnly = false;
            //dateTimePickerForDOB.Enabled = true;
            
        }

        internal void ShowWithAppointment(PatientVisits patientVisits)
        {
            throw new NotImplementedException();
        }


        /*
private void SaveChangesAndCloseButton_Click(object sender, EventArgs e)
{
  this.ClearErrorMessages();
  if (!this.ValidateFields()) return;

  //ClinicPerson updatedPatient = new ClinicPerson();
  //updatedPatient.DateOfBirth = this.dateTimePickerForDOB.Value.Date;


  try
  {
      if (!this.appointmentController.UpdatePatientVisitInformation(this.patient, updatedPatient))
      {
          MessageBox.Show("This patient's information has been\nmodified since it has been retrieved."
          + "\n\nThe form has been updated to reflect those changes.",
              "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
          this.GetPatientFromDB();
          this.PopulateForm();
          return;
      }
      MessageBox.Show("The changes were successfully amended to the database.",
              "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

  }
  catch (ArgumentException argumentException)
  {
      MessageBox.Show(argumentException.Message,
              "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
  }
  this.Close();
}

private void CancelButton_Click(object sender, EventArgs e)
{
  this.Close();
}

private void DeleteButton_Click(object sender, EventArgs e)
{
  DialogResult dialogResultVerifyClose = MessageBox.Show("Are you sure you want to delete this patient?\n" +
     "This cannot be undone.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

  if (dialogResultVerifyClose == DialogResult.Yes)
  {
      if (this.patientController.PatientHasNoAppointments(patientId))
      {
          //need try-catch
          this.patientController.DeletePatient(patientId);
          this.Close();
      }
      else
      {
          MessageBox.Show("This patient has associated appointments\nand cannot be deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
  }
}
private void ClearErrorMessages()
{
  //dobErrorLabel.Text = "";

}


private bool ValidateFields()
{
  string requiredField = "This field is required";
  var isValid = true;
  if (firstNameTextBox.Text.Length == 0)
  {
      isValid = false;
      firstNameErrorLabel.Text = requiredField;
  }
  if (lastNameTextBox.Text.Length == 0)
  {
      isValid = false;
      lastNameErrorLabel.Text = requiredField;
  }
  if (dob.Text.Length == 0)
  {
      isValid = false;
      dobErrorLabel.Text = requiredField;
  }
  if (!(genderTextBox.Text == "M" || genderTextBox.Text == "F" || genderTextBox.Text == "X"))
  {
      isValid = false;
      genderErrorLabel.Text = "Accepts 'M', 'F' or 'X'";
  }
  if (address1TextBox.Text.Length == 0)
  {
      isValid = false;
      address1ErrorLabel.Text = requiredField;
  }
  if (cityTextBox.Text.Length == 0)
  {
      isValid = false;
      cityErrorLabel.Text = requiredField;
  }
  Regex stateRegex = new Regex("[A-Z]{2}");
  if (!stateRegex.IsMatch(stateTextBox.Text))
  {
      isValid = false;
      stateErrorLabel.Text = "2 letter state code requried";
  }
  if (stateTextBox.Text.Length != 2)
  {
      isValid = false;
      stateErrorLabel.Text = "2 letter state code required";
  }
  if (stateTextBox.Text.Length == 0)
  {
      isValid = false;
      stateErrorLabel.Text = requiredField;
  }
  if (zipCodeTextBox.Text.Length == 0)
  {
      isValid = false;
      zipCodeErrorLabel.Text = requiredField;
  }
  Regex phoneRegex = new Regex("[0-9]{10}");
  if (!phoneRegex.IsMatch(phoneTextBox.Text))
  {
      isValid = false;
      phoneErrorLabel.Text = "only 10 numbers permitted";
  }
  if (phoneTextBox.Text.Length != 10)
  {
      isValid = false;
      phoneErrorLabel.Text = "10 digits required";
  }
  if (phoneTextBox.Text.Length == 0)
  {
      isValid = false;
      phoneErrorLabel.Text = requiredField;
  }
  if (ssnTextBox.Text.Length != 9)
  {
      isValid = false;
      ssnErrorLabel.Text = "9 digits required";
  }
  if (ssnTextBox.Text.Length == 0)
  {
      isValid = false;
      ssnErrorLabel.Text = requiredField;
  }
  return isValid;
}
*/

    }
}

