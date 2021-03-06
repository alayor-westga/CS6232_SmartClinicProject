
namespace SmartClinic.View
{
    partial class NewAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchForPatientsLabel = new System.Windows.Forms.Label();
            this.patientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.patientFirstNameLabel = new System.Windows.Forms.Label();
            this.patientLastNameLabel = new System.Windows.Forms.Label();
            this.patientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.patiendIdTextBox = new System.Windows.Forms.TextBox();
            this.patientDateOfBirthLabel = new System.Windows.Forms.Label();
            this.patiendDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchPatientsButton = new System.Windows.Forms.Button();
            this.clearSearchFieldsButton = new System.Windows.Forms.Button();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchForPatientsLabel
            // 
            this.searchForPatientsLabel.AutoSize = true;
            this.searchForPatientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForPatientsLabel.Location = new System.Drawing.Point(33, 19);
            this.searchForPatientsLabel.Name = "searchForPatientsLabel";
            this.searchForPatientsLabel.Size = new System.Drawing.Size(289, 37);
            this.searchForPatientsLabel.TabIndex = 0;
            this.searchForPatientsLabel.Text = "Search for Patients";
            // 
            // patientFirstNameTextBox
            // 
            this.patientFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFirstNameTextBox.Location = new System.Drawing.Point(195, 83);
            this.patientFirstNameTextBox.Name = "patientFirstNameTextBox";
            this.patientFirstNameTextBox.Size = new System.Drawing.Size(218, 44);
            this.patientFirstNameTextBox.TabIndex = 1;
            // 
            // patientFirstNameLabel
            // 
            this.patientFirstNameLabel.AutoSize = true;
            this.patientFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFirstNameLabel.Location = new System.Drawing.Point(14, 86);
            this.patientFirstNameLabel.Name = "patientFirstNameLabel";
            this.patientFirstNameLabel.Size = new System.Drawing.Size(175, 37);
            this.patientFirstNameLabel.TabIndex = 2;
            this.patientFirstNameLabel.Text = "First Name";
            // 
            // patientLastNameLabel
            // 
            this.patientLastNameLabel.AutoSize = true;
            this.patientLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLastNameLabel.Location = new System.Drawing.Point(469, 86);
            this.patientLastNameLabel.Name = "patientLastNameLabel";
            this.patientLastNameLabel.Size = new System.Drawing.Size(173, 37);
            this.patientLastNameLabel.TabIndex = 4;
            this.patientLastNameLabel.Text = "Last Name";
            // 
            // patientLastNameTextBox
            // 
            this.patientLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLastNameTextBox.Location = new System.Drawing.Point(648, 83);
            this.patientLastNameTextBox.Name = "patientLastNameTextBox";
            this.patientLastNameTextBox.Size = new System.Drawing.Size(218, 44);
            this.patientLastNameTextBox.TabIndex = 3;
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabel.Location = new System.Drawing.Point(33, 149);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(156, 37);
            this.patientIdLabel.TabIndex = 6;
            this.patientIdLabel.Text = "Patient ID";
            // 
            // patiendIdTextBox
            // 
            this.patiendIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patiendIdTextBox.Location = new System.Drawing.Point(195, 146);
            this.patiendIdTextBox.Name = "patiendIdTextBox";
            this.patiendIdTextBox.Size = new System.Drawing.Size(218, 44);
            this.patiendIdTextBox.TabIndex = 5;
            // 
            // patientDateOfBirthLabel
            // 
            this.patientDateOfBirthLabel.AutoSize = true;
            this.patientDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthLabel.Location = new System.Drawing.Point(447, 149);
            this.patientDateOfBirthLabel.Name = "patientDateOfBirthLabel";
            this.patientDateOfBirthLabel.Size = new System.Drawing.Size(195, 37);
            this.patientDateOfBirthLabel.TabIndex = 7;
            this.patientDateOfBirthLabel.Text = "Date of Birth";
            // 
            // patiendDateOfBirthDateTimePicker
            // 
            this.patiendDateOfBirthDateTimePicker.CustomFormat = "yyyy/mm/dd";
            this.patiendDateOfBirthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patiendDateOfBirthDateTimePicker.Location = new System.Drawing.Point(648, 143);
            this.patiendDateOfBirthDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.patiendDateOfBirthDateTimePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.patiendDateOfBirthDateTimePicker.Name = "patiendDateOfBirthDateTimePicker";
            this.patiendDateOfBirthDateTimePicker.Size = new System.Drawing.Size(218, 44);
            this.patiendDateOfBirthDateTimePicker.TabIndex = 8;
            this.patiendDateOfBirthDateTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // searchPatientsButton
            // 
            this.searchPatientsButton.AutoSize = true;
            this.searchPatientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientsButton.Location = new System.Drawing.Point(909, 83);
            this.searchPatientsButton.Name = "searchPatientsButton";
            this.searchPatientsButton.Size = new System.Drawing.Size(128, 47);
            this.searchPatientsButton.TabIndex = 9;
            this.searchPatientsButton.Text = "Search";
            this.searchPatientsButton.UseVisualStyleBackColor = true;
            // 
            // clearSearchFieldsButton
            // 
            this.clearSearchFieldsButton.AutoSize = true;
            this.clearSearchFieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchFieldsButton.Location = new System.Drawing.Point(1054, 83);
            this.clearSearchFieldsButton.Name = "clearSearchFieldsButton";
            this.clearSearchFieldsButton.Size = new System.Drawing.Size(121, 47);
            this.clearSearchFieldsButton.TabIndex = 10;
            this.clearSearchFieldsButton.Text = "Clear";
            this.clearSearchFieldsButton.UseVisualStyleBackColor = true;
            // 
            // newPatientButton
            // 
            this.newPatientButton.AutoSize = true;
            this.newPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientButton.Location = new System.Drawing.Point(909, 146);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(266, 47);
            this.newPatientButton.TabIndex = 11;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            // 
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 864);
            this.Controls.Add(this.newPatientButton);
            this.Controls.Add(this.clearSearchFieldsButton);
            this.Controls.Add(this.searchPatientsButton);
            this.Controls.Add(this.patiendDateOfBirthDateTimePicker);
            this.Controls.Add(this.patientDateOfBirthLabel);
            this.Controls.Add(this.patientIdLabel);
            this.Controls.Add(this.patiendIdTextBox);
            this.Controls.Add(this.patientLastNameLabel);
            this.Controls.Add(this.patientLastNameTextBox);
            this.Controls.Add(this.patientFirstNameLabel);
            this.Controls.Add(this.patientFirstNameTextBox);
            this.Controls.Add(this.searchForPatientsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchForPatientsLabel;
        private System.Windows.Forms.TextBox patientFirstNameTextBox;
        private System.Windows.Forms.Label patientFirstNameLabel;
        private System.Windows.Forms.Label patientLastNameLabel;
        private System.Windows.Forms.TextBox patientLastNameTextBox;
        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.TextBox patiendIdTextBox;
        private System.Windows.Forms.Label patientDateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker patiendDateOfBirthDateTimePicker;
        private System.Windows.Forms.Button searchPatientsButton;
        private System.Windows.Forms.Button clearSearchFieldsButton;
        private System.Windows.Forms.Button newPatientButton;
    }
}