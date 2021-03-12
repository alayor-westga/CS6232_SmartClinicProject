
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
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reasonForVisitLabel = new System.Windows.Forms.Label();
            this.reasonForVisitTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.patientVisitDetailsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.patientGroupBox = new System.Windows.Forms.GroupBox();
            this.patientSSNValueLabel = new System.Windows.Forms.Label();
            this.patientSSNLabel = new System.Windows.Forms.Label();
            this.doctorGroupBox = new System.Windows.Forms.GroupBox();
            this.doctorPhoneNumberValueLabel = new System.Windows.Forms.Label();
            this.doctorPhoneNumberLabel = new System.Windows.Forms.Label();
            this.doctorIdLabel = new System.Windows.Forms.Label();
            this.doctorIdValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.patientGroupBox.SuspendLayout();
            this.doctorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabel.Location = new System.Drawing.Point(18, 49);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(57, 37);
            this.patientIdLabel.TabIndex = 0;
            this.patientIdLabel.Text = "ID:";
            // 
            // patientIdValueLabel
            // 
            this.patientIdValueLabel.AutoSize = true;
            this.patientIdValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdValueLabel.Location = new System.Drawing.Point(73, 49);
            this.patientIdValueLabel.Name = "patientIdValueLabel";
            this.patientIdValueLabel.Size = new System.Drawing.Size(27, 37);
            this.patientIdValueLabel.TabIndex = 1;
            this.patientIdValueLabel.Text = "-";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(18, 103);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(112, 37);
            this.patientNameLabel.TabIndex = 2;
            this.patientNameLabel.Text = "Name:";
            // 
            // patientNameValueLabel
            // 
            this.patientNameValueLabel.AutoSize = true;
            this.patientNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameValueLabel.Location = new System.Drawing.Point(124, 103);
            this.patientNameValueLabel.Name = "patientNameValueLabel";
            this.patientNameValueLabel.Size = new System.Drawing.Size(27, 37);
            this.patientNameValueLabel.TabIndex = 3;
            this.patientNameValueLabel.Text = "-";
            // 
            // patientDateOfBirthLabel
            // 
            this.patientDateOfBirthLabel.AutoSize = true;
            this.patientDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthLabel.Location = new System.Drawing.Point(202, 49);
            this.patientDateOfBirthLabel.Name = "patientDateOfBirthLabel";
            this.patientDateOfBirthLabel.Size = new System.Drawing.Size(95, 37);
            this.patientDateOfBirthLabel.TabIndex = 4;
            this.patientDateOfBirthLabel.Text = "DOB:";
            // 
            // patientDateOfBirthValueLabel
            // 
            this.patientDateOfBirthValueLabel.AutoSize = true;
            this.patientDateOfBirthValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthValueLabel.Location = new System.Drawing.Point(292, 49);
            this.patientDateOfBirthValueLabel.Name = "patientDateOfBirthValueLabel";
            this.patientDateOfBirthValueLabel.Size = new System.Drawing.Size(27, 37);
            this.patientDateOfBirthValueLabel.TabIndex = 5;
            this.patientDateOfBirthValueLabel.Text = "-";
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateLabel.Location = new System.Drawing.Point(78, 19);
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
            this.appointmentTimePicker.Location = new System.Drawing.Point(419, 59);
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
            this.appointmentDatePicker.CustomFormat = "MM/dd/yyyy";
            this.appointmentDatePicker.Enabled = false;
            this.appointmentDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentDatePicker.Location = new System.Drawing.Point(53, 59);
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
            this.appointmentTimeLabel.Location = new System.Drawing.Point(496, 19);
            this.appointmentTimeLabel.Name = "appointmentTimeLabel";
            this.appointmentTimeLabel.Size = new System.Drawing.Size(88, 37);
            this.appointmentTimeLabel.TabIndex = 23;
            this.appointmentTimeLabel.Text = "Time";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DataSource = this.doctorBindingSource;
            this.doctorComboBox.DisplayMember = "FullName";
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.Enabled = false;
            this.doctorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(12, 48);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(643, 45);
            this.doctorComboBox.TabIndex = 25;
            this.doctorComboBox.ValueMember = "DoctorId";
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.DoctorComboBox_SelectedIndexChanged);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(SmartClinic.Model.Doctor);
            // 
            // reasonForVisitLabel
            // 
            this.reasonForVisitLabel.AutoSize = true;
            this.reasonForVisitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonForVisitLabel.Location = new System.Drawing.Point(20, 505);
            this.reasonForVisitLabel.Name = "reasonForVisitLabel";
            this.reasonForVisitLabel.Size = new System.Drawing.Size(254, 37);
            this.reasonForVisitLabel.TabIndex = 26;
            this.reasonForVisitLabel.Text = "Reason For Visit";
            // 
            // reasonForVisitTextBox
            // 
            this.reasonForVisitTextBox.Enabled = false;
            this.reasonForVisitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonForVisitTextBox.Location = new System.Drawing.Point(15, 544);
            this.reasonForVisitTextBox.MaxLength = 200;
            this.reasonForVisitTextBox.Multiline = true;
            this.reasonForVisitTextBox.Name = "reasonForVisitTextBox";
            this.reasonForVisitTextBox.Size = new System.Drawing.Size(682, 98);
            this.reasonForVisitTextBox.TabIndex = 27;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(223, 676);
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
            this.deleteButton.Location = new System.Drawing.Point(503, 676);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(155, 47);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // patientVisitDetailsButton
            // 
            this.patientVisitDetailsButton.AutoSize = true;
            this.patientVisitDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientVisitDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientVisitDetailsButton.Location = new System.Drawing.Point(51, 747);
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
            this.cancelButton.Location = new System.Drawing.Point(417, 747);
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
            this.editButton.Location = new System.Drawing.Point(51, 676);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(141, 47);
            this.editButton.TabIndex = 32;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // patientGroupBox
            // 
            this.patientGroupBox.Controls.Add(this.patientSSNValueLabel);
            this.patientGroupBox.Controls.Add(this.patientSSNLabel);
            this.patientGroupBox.Controls.Add(this.patientDateOfBirthLabel);
            this.patientGroupBox.Controls.Add(this.patientIdLabel);
            this.patientGroupBox.Controls.Add(this.patientIdValueLabel);
            this.patientGroupBox.Controls.Add(this.patientNameLabel);
            this.patientGroupBox.Controls.Add(this.patientNameValueLabel);
            this.patientGroupBox.Controls.Add(this.patientDateOfBirthValueLabel);
            this.patientGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientGroupBox.Location = new System.Drawing.Point(15, 124);
            this.patientGroupBox.Name = "patientGroupBox";
            this.patientGroupBox.Size = new System.Drawing.Size(682, 168);
            this.patientGroupBox.TabIndex = 33;
            this.patientGroupBox.TabStop = false;
            this.patientGroupBox.Text = "Patient";
            // 
            // patientSSNValueLabel
            // 
            this.patientSSNValueLabel.AutoSize = true;
            this.patientSSNValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSSNValueLabel.Location = new System.Drawing.Point(529, 49);
            this.patientSSNValueLabel.Name = "patientSSNValueLabel";
            this.patientSSNValueLabel.Size = new System.Drawing.Size(27, 37);
            this.patientSSNValueLabel.TabIndex = 7;
            this.patientSSNValueLabel.Text = "-";
            // 
            // patientSSNLabel
            // 
            this.patientSSNLabel.AutoSize = true;
            this.patientSSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSSNLabel.Location = new System.Drawing.Point(446, 49);
            this.patientSSNLabel.Name = "patientSSNLabel";
            this.patientSSNLabel.Size = new System.Drawing.Size(92, 37);
            this.patientSSNLabel.TabIndex = 6;
            this.patientSSNLabel.Text = "SSN:";
            // 
            // doctorGroupBox
            // 
            this.doctorGroupBox.Controls.Add(this.doctorIdValueLabel);
            this.doctorGroupBox.Controls.Add(this.doctorIdLabel);
            this.doctorGroupBox.Controls.Add(this.doctorPhoneNumberValueLabel);
            this.doctorGroupBox.Controls.Add(this.doctorPhoneNumberLabel);
            this.doctorGroupBox.Controls.Add(this.doctorComboBox);
            this.doctorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorGroupBox.Location = new System.Drawing.Point(15, 312);
            this.doctorGroupBox.Name = "doctorGroupBox";
            this.doctorGroupBox.Size = new System.Drawing.Size(682, 165);
            this.doctorGroupBox.TabIndex = 34;
            this.doctorGroupBox.TabStop = false;
            this.doctorGroupBox.Text = "Doctor";
            // 
            // doctorPhoneNumberValueLabel
            // 
            this.doctorPhoneNumberValueLabel.AutoSize = true;
            this.doctorPhoneNumberValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorPhoneNumberValueLabel.Location = new System.Drawing.Point(341, 112);
            this.doctorPhoneNumberValueLabel.Name = "doctorPhoneNumberValueLabel";
            this.doctorPhoneNumberValueLabel.Size = new System.Drawing.Size(23, 31);
            this.doctorPhoneNumberValueLabel.TabIndex = 26;
            this.doctorPhoneNumberValueLabel.Text = "-";
            // 
            // doctorPhoneNumberLabel
            // 
            this.doctorPhoneNumberLabel.AutoSize = true;
            this.doctorPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorPhoneNumberLabel.Location = new System.Drawing.Point(229, 112);
            this.doctorPhoneNumberLabel.Name = "doctorPhoneNumberLabel";
            this.doctorPhoneNumberLabel.Size = new System.Drawing.Size(122, 31);
            this.doctorPhoneNumberLabel.TabIndex = 8;
            this.doctorPhoneNumberLabel.Text = "Phone #:";
            // 
            // doctorIdLabel
            // 
            this.doctorIdLabel.AutoSize = true;
            this.doctorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorIdLabel.Location = new System.Drawing.Point(19, 112);
            this.doctorIdLabel.Name = "doctorIdLabel";
            this.doctorIdLabel.Size = new System.Drawing.Size(50, 31);
            this.doctorIdLabel.TabIndex = 27;
            this.doctorIdLabel.Text = "ID:";
            // 
            // doctorIdValueLabel
            // 
            this.doctorIdValueLabel.AutoSize = true;
            this.doctorIdValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorIdValueLabel.Location = new System.Drawing.Point(64, 112);
            this.doctorIdValueLabel.Name = "doctorIdValueLabel";
            this.doctorIdValueLabel.Size = new System.Drawing.Size(23, 31);
            this.doctorIdValueLabel.TabIndex = 28;
            this.doctorIdValueLabel.Text = "-";
            // 
            // AppointmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 816);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.patientVisitDetailsButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.reasonForVisitTextBox);
            this.Controls.Add(this.reasonForVisitLabel);
            this.Controls.Add(this.appointmentTimeLabel);
            this.Controls.Add(this.appointmentTimePicker);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.appointmentDateLabel);
            this.Controls.Add(this.patientGroupBox);
            this.Controls.Add(this.doctorGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Details";
            this.Load += new System.EventHandler(this.AppointmentDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.patientGroupBox.ResumeLayout(false);
            this.patientGroupBox.PerformLayout();
            this.doctorGroupBox.ResumeLayout(false);
            this.doctorGroupBox.PerformLayout();
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
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Label reasonForVisitLabel;
        private System.Windows.Forms.TextBox reasonForVisitTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button patientVisitDetailsButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.GroupBox patientGroupBox;
        private System.Windows.Forms.Label patientSSNValueLabel;
        private System.Windows.Forms.Label patientSSNLabel;
        private System.Windows.Forms.GroupBox doctorGroupBox;
        private System.Windows.Forms.Label doctorPhoneNumberValueLabel;
        private System.Windows.Forms.Label doctorPhoneNumberLabel;
        private System.Windows.Forms.Label doctorIdValueLabel;
        private System.Windows.Forms.Label doctorIdLabel;
    }
}