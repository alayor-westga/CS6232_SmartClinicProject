
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
            this.doctorIdValueLabel = new System.Windows.Forms.Label();
            this.doctorIdLabel = new System.Windows.Forms.Label();
            this.doctorPhoneNumberValueLabel = new System.Windows.Forms.Label();
            this.doctorPhoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.patientGroupBox.SuspendLayout();
            this.doctorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabel.Location = new System.Drawing.Point(12, 31);
            this.patientIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(37, 25);
            this.patientIdLabel.TabIndex = 0;
            this.patientIdLabel.Text = "ID:";
            // 
            // patientIdValueLabel
            // 
            this.patientIdValueLabel.AutoSize = true;
            this.patientIdValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdValueLabel.Location = new System.Drawing.Point(49, 31);
            this.patientIdValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientIdValueLabel.Name = "patientIdValueLabel";
            this.patientIdValueLabel.Size = new System.Drawing.Size(19, 25);
            this.patientIdValueLabel.TabIndex = 1;
            this.patientIdValueLabel.Text = "-";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(12, 66);
            this.patientNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(70, 25);
            this.patientNameLabel.TabIndex = 2;
            this.patientNameLabel.Text = "Name:";
            // 
            // patientNameValueLabel
            // 
            this.patientNameValueLabel.AutoSize = true;
            this.patientNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameValueLabel.Location = new System.Drawing.Point(83, 66);
            this.patientNameValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientNameValueLabel.Name = "patientNameValueLabel";
            this.patientNameValueLabel.Size = new System.Drawing.Size(19, 25);
            this.patientNameValueLabel.TabIndex = 3;
            this.patientNameValueLabel.Text = "-";
            // 
            // patientDateOfBirthLabel
            // 
            this.patientDateOfBirthLabel.AutoSize = true;
            this.patientDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthLabel.Location = new System.Drawing.Point(135, 31);
            this.patientDateOfBirthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientDateOfBirthLabel.Name = "patientDateOfBirthLabel";
            this.patientDateOfBirthLabel.Size = new System.Drawing.Size(61, 25);
            this.patientDateOfBirthLabel.TabIndex = 4;
            this.patientDateOfBirthLabel.Text = "DOB:";
            // 
            // patientDateOfBirthValueLabel
            // 
            this.patientDateOfBirthValueLabel.AutoSize = true;
            this.patientDateOfBirthValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthValueLabel.Location = new System.Drawing.Point(195, 31);
            this.patientDateOfBirthValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientDateOfBirthValueLabel.Name = "patientDateOfBirthValueLabel";
            this.patientDateOfBirthValueLabel.Size = new System.Drawing.Size(19, 25);
            this.patientDateOfBirthValueLabel.TabIndex = 5;
            this.patientDateOfBirthValueLabel.Text = "-";
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateLabel.Location = new System.Drawing.Point(52, 12);
            this.appointmentDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(168, 25);
            this.appointmentDateLabel.TabIndex = 6;
            this.appointmentDateLabel.Text = "Appointment Date";
            // 
            // appointmentTimePicker
            // 
            this.appointmentTimePicker.CustomFormat = "hh:mm tt";
            this.appointmentTimePicker.Enabled = false;
            this.appointmentTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentTimePicker.Location = new System.Drawing.Point(279, 38);
            this.appointmentTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointmentTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.appointmentTimePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.appointmentTimePicker.Name = "appointmentTimePicker";
            this.appointmentTimePicker.ShowUpDown = true;
            this.appointmentTimePicker.Size = new System.Drawing.Size(162, 30);
            this.appointmentTimePicker.TabIndex = 22;
            this.appointmentTimePicker.Value = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.CustomFormat = "MM/dd/yyyy";
            this.appointmentDatePicker.Enabled = false;
            this.appointmentDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentDatePicker.Location = new System.Drawing.Point(35, 38);
            this.appointmentDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointmentDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.appointmentDatePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(219, 30);
            this.appointmentDatePicker.TabIndex = 21;
            this.appointmentDatePicker.Value = new System.DateTime(2021, 3, 6, 17, 46, 11, 0);
            // 
            // appointmentTimeLabel
            // 
            this.appointmentTimeLabel.AutoSize = true;
            this.appointmentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTimeLabel.Location = new System.Drawing.Point(331, 12);
            this.appointmentTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appointmentTimeLabel.Name = "appointmentTimeLabel";
            this.appointmentTimeLabel.Size = new System.Drawing.Size(56, 25);
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
            this.doctorComboBox.Location = new System.Drawing.Point(8, 31);
            this.doctorComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(430, 33);
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
            this.reasonForVisitLabel.Location = new System.Drawing.Point(13, 323);
            this.reasonForVisitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reasonForVisitLabel.Name = "reasonForVisitLabel";
            this.reasonForVisitLabel.Size = new System.Drawing.Size(155, 25);
            this.reasonForVisitLabel.TabIndex = 26;
            this.reasonForVisitLabel.Text = "Reason For Visit";
            // 
            // reasonForVisitTextBox
            // 
            this.reasonForVisitTextBox.Enabled = false;
            this.reasonForVisitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonForVisitTextBox.Location = new System.Drawing.Point(10, 348);
            this.reasonForVisitTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reasonForVisitTextBox.MaxLength = 200;
            this.reasonForVisitTextBox.Multiline = true;
            this.reasonForVisitTextBox.Name = "reasonForVisitTextBox";
            this.reasonForVisitTextBox.Size = new System.Drawing.Size(456, 64);
            this.reasonForVisitTextBox.TabIndex = 27;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(149, 433);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(170, 35);
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
            this.deleteButton.Location = new System.Drawing.Point(335, 433);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 35);
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
            this.patientVisitDetailsButton.Location = new System.Drawing.Point(34, 478);
            this.patientVisitDetailsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientVisitDetailsButton.Name = "patientVisitDetailsButton";
            this.patientVisitDetailsButton.Size = new System.Drawing.Size(217, 35);
            this.patientVisitDetailsButton.TabIndex = 30;
            this.patientVisitDetailsButton.Text = "Patient Visit Details";
            this.patientVisitDetailsButton.UseVisualStyleBackColor = true;
            this.patientVisitDetailsButton.Click += new System.EventHandler(this.PatientVisitDetailsButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(278, 478);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(161, 35);
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
            this.editButton.Location = new System.Drawing.Point(34, 433);
            this.editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(94, 35);
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
            this.patientGroupBox.Location = new System.Drawing.Point(10, 79);
            this.patientGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientGroupBox.Name = "patientGroupBox";
            this.patientGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientGroupBox.Size = new System.Drawing.Size(455, 108);
            this.patientGroupBox.TabIndex = 33;
            this.patientGroupBox.TabStop = false;
            this.patientGroupBox.Text = "Patient";
            // 
            // patientSSNValueLabel
            // 
            this.patientSSNValueLabel.AutoSize = true;
            this.patientSSNValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSSNValueLabel.Location = new System.Drawing.Point(353, 31);
            this.patientSSNValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientSSNValueLabel.Name = "patientSSNValueLabel";
            this.patientSSNValueLabel.Size = new System.Drawing.Size(19, 25);
            this.patientSSNValueLabel.TabIndex = 7;
            this.patientSSNValueLabel.Text = "-";
            // 
            // patientSSNLabel
            // 
            this.patientSSNLabel.AutoSize = true;
            this.patientSSNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSSNLabel.Location = new System.Drawing.Point(297, 31);
            this.patientSSNLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientSSNLabel.Name = "patientSSNLabel";
            this.patientSSNLabel.Size = new System.Drawing.Size(60, 25);
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
            this.doctorGroupBox.Location = new System.Drawing.Point(10, 200);
            this.doctorGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctorGroupBox.Name = "doctorGroupBox";
            this.doctorGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctorGroupBox.Size = new System.Drawing.Size(455, 106);
            this.doctorGroupBox.TabIndex = 34;
            this.doctorGroupBox.TabStop = false;
            this.doctorGroupBox.Text = "Doctor";
            // 
            // doctorIdValueLabel
            // 
            this.doctorIdValueLabel.AutoSize = true;
            this.doctorIdValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorIdValueLabel.Location = new System.Drawing.Point(43, 72);
            this.doctorIdValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorIdValueLabel.Name = "doctorIdValueLabel";
            this.doctorIdValueLabel.Size = new System.Drawing.Size(15, 20);
            this.doctorIdValueLabel.TabIndex = 28;
            this.doctorIdValueLabel.Text = "-";
            // 
            // doctorIdLabel
            // 
            this.doctorIdLabel.AutoSize = true;
            this.doctorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorIdLabel.Location = new System.Drawing.Point(13, 72);
            this.doctorIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorIdLabel.Name = "doctorIdLabel";
            this.doctorIdLabel.Size = new System.Drawing.Size(31, 20);
            this.doctorIdLabel.TabIndex = 27;
            this.doctorIdLabel.Text = "ID:";
            // 
            // doctorPhoneNumberValueLabel
            // 
            this.doctorPhoneNumberValueLabel.AutoSize = true;
            this.doctorPhoneNumberValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorPhoneNumberValueLabel.Location = new System.Drawing.Point(227, 72);
            this.doctorPhoneNumberValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorPhoneNumberValueLabel.Name = "doctorPhoneNumberValueLabel";
            this.doctorPhoneNumberValueLabel.Size = new System.Drawing.Size(15, 20);
            this.doctorPhoneNumberValueLabel.TabIndex = 26;
            this.doctorPhoneNumberValueLabel.Text = "-";
            // 
            // doctorPhoneNumberLabel
            // 
            this.doctorPhoneNumberLabel.AutoSize = true;
            this.doctorPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorPhoneNumberLabel.Location = new System.Drawing.Point(153, 72);
            this.doctorPhoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorPhoneNumberLabel.Name = "doctorPhoneNumberLabel";
            this.doctorPhoneNumberLabel.Size = new System.Drawing.Size(75, 20);
            this.doctorPhoneNumberLabel.TabIndex = 8;
            this.doctorPhoneNumberLabel.Text = "Phone #:";
            // 
            // AppointmentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 522);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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