
namespace SmartClinic.View
{
    partial class AppointmentDetailsForm
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
            this.components = new System.ComponentModel.Container();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.patientIdValueLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientNameValueLabel = new System.Windows.Forms.Label();
            this.patientDateOfBirthLabel = new System.Windows.Forms.Label();
            this.patientDateOfBirthValueLabel = new System.Windows.Forms.Label();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.appointmentTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentTimeLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reasonForVisitLabel = new System.Windows.Forms.Label();
            this.reasonForVisitTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.patientVisitDetailsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabel.Location = new System.Drawing.Point(12, 9);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(176, 37);
            this.patientIdLabel.TabIndex = 0;
            this.patientIdLabel.Text = "Patient ID:";
            // 
            // patientIdValueLabel
            // 
            this.patientIdValueLabel.AutoSize = true;
            this.patientIdValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdValueLabel.Location = new System.Drawing.Point(178, 9);
            this.patientIdValueLabel.Name = "patientIdValueLabel";
            this.patientIdValueLabel.Size = new System.Drawing.Size(0, 37);
            this.patientIdValueLabel.TabIndex = 1;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(271, 9);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(133, 37);
            this.patientNameLabel.TabIndex = 2;
            this.patientNameLabel.Text = "Patient:";
            // 
            // patientNameValueLabel
            // 
            this.patientNameValueLabel.AutoSize = true;
            this.patientNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameValueLabel.Location = new System.Drawing.Point(398, 9);
            this.patientNameValueLabel.Name = "patientNameValueLabel";
            this.patientNameValueLabel.Size = new System.Drawing.Size(0, 37);
            this.patientNameValueLabel.TabIndex = 3;
            // 
            // patientDateOfBirthLabel
            // 
            this.patientDateOfBirthLabel.AutoSize = true;
            this.patientDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthLabel.Location = new System.Drawing.Point(12, 61);
            this.patientDateOfBirthLabel.Name = "patientDateOfBirthLabel";
            this.patientDateOfBirthLabel.Size = new System.Drawing.Size(225, 37);
            this.patientDateOfBirthLabel.TabIndex = 4;
            this.patientDateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // patientDateOfBirthValueLabel
            // 
            this.patientDateOfBirthValueLabel.AutoSize = true;
            this.patientDateOfBirthValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthValueLabel.Location = new System.Drawing.Point(225, 61);
            this.patientDateOfBirthValueLabel.Name = "patientDateOfBirthValueLabel";
            this.patientDateOfBirthValueLabel.Size = new System.Drawing.Size(0, 37);
            this.patientDateOfBirthValueLabel.TabIndex = 5;
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateLabel.Location = new System.Drawing.Point(36, 121);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(274, 37);
            this.appointmentDateLabel.TabIndex = 6;
            this.appointmentDateLabel.Text = "Appointment Date";
            // 
            // appointmentTimePicker
            // 
            this.appointmentTimePicker.CustomFormat = "hh:mm tt";
            this.appointmentTimePicker.Enabled = false;
            this.appointmentTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentTimePicker.Location = new System.Drawing.Point(395, 161);
            this.appointmentTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.appointmentTimePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.appointmentTimePicker.Name = "appointmentTimePicker";
            this.appointmentTimePicker.ShowUpDown = true;
            this.appointmentTimePicker.Size = new System.Drawing.Size(241, 44);
            this.appointmentTimePicker.TabIndex = 22;
            this.appointmentTimePicker.Value = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.CustomFormat = "dd/MM/yyyy";
            this.appointmentDatePicker.Enabled = false;
            this.appointmentDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentDatePicker.Location = new System.Drawing.Point(29, 161);
            this.appointmentDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.appointmentDatePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(326, 44);
            this.appointmentDatePicker.TabIndex = 21;
            this.appointmentDatePicker.Value = new System.DateTime(2021, 3, 6, 17, 46, 11, 0);
            // 
            // appointmentTimeLabel
            // 
            this.appointmentTimeLabel.AutoSize = true;
            this.appointmentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTimeLabel.Location = new System.Drawing.Point(398, 121);
            this.appointmentTimeLabel.Name = "appointmentTimeLabel";
            this.appointmentTimeLabel.Size = new System.Drawing.Size(88, 37);
            this.appointmentTimeLabel.TabIndex = 23;
            this.appointmentTimeLabel.Text = "Time";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorLabel.Location = new System.Drawing.Point(36, 228);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(112, 37);
            this.doctorLabel.TabIndex = 24;
            this.doctorLabel.Text = "Doctor";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DataSource = this.doctorBindingSource;
            this.doctorComboBox.DisplayMember = "FullName";
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.Enabled = false;
            this.doctorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(29, 268);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(607, 45);
            this.doctorComboBox.TabIndex = 25;
            this.doctorComboBox.ValueMember = "DoctorId";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(SmartClinic.Model.Doctor);
            // 
            // reasonForVisitLabel
            // 
            this.reasonForVisitLabel.AutoSize = true;
            this.reasonForVisitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonForVisitLabel.Location = new System.Drawing.Point(36, 342);
            this.reasonForVisitLabel.Name = "reasonForVisitLabel";
            this.reasonForVisitLabel.Size = new System.Drawing.Size(254, 37);
            this.reasonForVisitLabel.TabIndex = 26;
            this.reasonForVisitLabel.Text = "Reason For Visit";
            // 
            // reasonForVisitTextBox
            // 
            this.reasonForVisitTextBox.Enabled = false;
            this.reasonForVisitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonForVisitTextBox.Location = new System.Drawing.Point(29, 382);
            this.reasonForVisitTextBox.MaxLength = 200;
            this.reasonForVisitTextBox.Multiline = true;
            this.reasonForVisitTextBox.Name = "reasonForVisitTextBox";
            this.reasonForVisitTextBox.Size = new System.Drawing.Size(607, 98);
            this.reasonForVisitTextBox.TabIndex = 27;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(201, 514);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(255, 47);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Save And Close";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(481, 514);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(155, 47);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // patientVisitDetailsButton
            // 
            this.patientVisitDetailsButton.AutoSize = true;
            this.patientVisitDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientVisitDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientVisitDetailsButton.Location = new System.Drawing.Point(29, 585);
            this.patientVisitDetailsButton.Name = "patientVisitDetailsButton";
            this.patientVisitDetailsButton.Size = new System.Drawing.Size(326, 47);
            this.patientVisitDetailsButton.TabIndex = 30;
            this.patientVisitDetailsButton.Text = "Patient Visit Details";
            this.patientVisitDetailsButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(395, 585);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(241, 47);
            this.cancelButton.TabIndex = 31;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(29, 514);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(141, 47);
            this.editButton.TabIndex = 32;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // AppointmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 652);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.patientVisitDetailsButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reasonForVisitTextBox);
            this.Controls.Add(this.reasonForVisitLabel);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.appointmentTimeLabel);
            this.Controls.Add(this.appointmentTimePicker);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.appointmentDateLabel);
            this.Controls.Add(this.patientDateOfBirthValueLabel);
            this.Controls.Add(this.patientDateOfBirthLabel);
            this.Controls.Add(this.patientNameValueLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.patientIdValueLabel);
            this.Controls.Add(this.patientIdLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Details";
            this.Load += new System.EventHandler(this.AppointmentDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.Label patientIdValueLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientNameValueLabel;
        private System.Windows.Forms.Label patientDateOfBirthLabel;
        private System.Windows.Forms.Label patientDateOfBirthValueLabel;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.DateTimePicker appointmentTimePicker;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.Label appointmentTimeLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Label reasonForVisitLabel;
        private System.Windows.Forms.TextBox reasonForVisitTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button patientVisitDetailsButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.BindingSource doctorBindingSource;
    }
}