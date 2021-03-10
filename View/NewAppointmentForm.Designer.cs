
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
            this.components = new System.ComponentModel.Container();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.searchForPatientsGroupBox = new System.Windows.Forms.GroupBox();
            this.patientFullNameValueLabel = new System.Windows.Forms.Label();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.newAppoinmentGroupBox = new System.Windows.Forms.GroupBox();
            this.appointmentReasonErrorLabel = new System.Windows.Forms.Label();
            this.appointmentDoctorErrorLabel = new System.Windows.Forms.Label();
            this.appointmentTimeErrorLabel = new System.Windows.Forms.Label();
            this.appointmentDateErrorLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.reasonForVisitLabel = new System.Windows.Forms.Label();
            this.reasonForVisitTextBox = new System.Windows.Forms.TextBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorLabel = new System.Windows.Forms.Label();
            this.appointmentTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.searchForPatientsGroupBox.SuspendLayout();
            this.newAppoinmentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(SmartClinic.Model.Patient);
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateLabel.Location = new System.Drawing.Point(60, 48);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(274, 37);
            this.appointmentDateLabel.TabIndex = 17;
            this.appointmentDateLabel.Text = "Appointment Date";
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Checked = false;
            this.appointmentDatePicker.CustomFormat = " ---";
            this.appointmentDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentDatePicker.Location = new System.Drawing.Point(49, 88);
            this.appointmentDatePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.appointmentDatePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(298, 44);
            this.appointmentDatePicker.TabIndex = 18;
            this.appointmentDatePicker.Value = new System.DateTime(2021, 3, 6, 17, 46, 11, 0);
            this.appointmentDatePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppointmentDatePicker_MouseDown);
            // 
            // searchForPatientsGroupBox
            // 
            this.searchForPatientsGroupBox.Controls.Add(this.patientFullNameValueLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.searchPatientButton);
            this.searchForPatientsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForPatientsGroupBox.Location = new System.Drawing.Point(6, 12);
            this.searchForPatientsGroupBox.Name = "searchForPatientsGroupBox";
            this.searchForPatientsGroupBox.Size = new System.Drawing.Size(1202, 452);
            this.searchForPatientsGroupBox.TabIndex = 19;
            this.searchForPatientsGroupBox.TabStop = false;
            this.searchForPatientsGroupBox.Text = "Search for Patients";
            // 
            // patientFullNameValueLabel
            // 
            this.patientFullNameValueLabel.AutoSize = true;
            this.patientFullNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFullNameValueLabel.Location = new System.Drawing.Point(373, 34);
            this.patientFullNameValueLabel.Name = "patientFullNameValueLabel";
            this.patientFullNameValueLabel.Size = new System.Drawing.Size(164, 37);
            this.patientFullNameValueLabel.TabIndex = 31;
            this.patientFullNameValueLabel.Text = "Full Name";
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.AutoSize = true;
            this.searchPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientButton.Location = new System.Drawing.Point(29, 84);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(250, 47);
            this.searchPatientButton.TabIndex = 15;
            this.searchPatientButton.Text = "Search Patient";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            this.searchPatientButton.Click += new System.EventHandler(this.SearchPatientButton_Click);
            // 
            // newAppoinmentGroupBox
            // 
            this.newAppoinmentGroupBox.Controls.Add(this.appointmentReasonErrorLabel);
            this.newAppoinmentGroupBox.Controls.Add(this.appointmentDoctorErrorLabel);
            this.newAppoinmentGroupBox.Controls.Add(this.appointmentTimeErrorLabel);
            this.newAppoinmentGroupBox.Controls.Add(this.appointmentDateErrorLabel);
            this.newAppoinmentGroupBox.Controls.Add(this.cancelButton);
            this.newAppoinmentGroupBox.Controls.Add(this.addAppointmentButton);
            this.newAppoinmentGroupBox.Controls.Add(this.reasonForVisitLabel);
            this.newAppoinmentGroupBox.Controls.Add(this.reasonForVisitTextBox);
            this.newAppoinmentGroupBox.Controls.Add(this.doctorComboBox);
            this.newAppoinmentGroupBox.Controls.Add(this.doctorLabel);
            this.newAppoinmentGroupBox.Controls.Add(this.appointmentTimePicker);
            this.newAppoinmentGroupBox.Controls.Add(this.appointmentTimeLabel);
            this.newAppoinmentGroupBox.Controls.Add(this.appointmentDatePicker);
            this.newAppoinmentGroupBox.Controls.Add(this.appointmentDateLabel);
            this.newAppoinmentGroupBox.Enabled = false;
            this.newAppoinmentGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAppoinmentGroupBox.Location = new System.Drawing.Point(6, 492);
            this.newAppoinmentGroupBox.Name = "newAppoinmentGroupBox";
            this.newAppoinmentGroupBox.Size = new System.Drawing.Size(1202, 392);
            this.newAppoinmentGroupBox.TabIndex = 20;
            this.newAppoinmentGroupBox.TabStop = false;
            this.newAppoinmentGroupBox.Text = "New Appointment For -";
            // 
            // appointmentReasonErrorLabel
            // 
            this.appointmentReasonErrorLabel.AutoSize = true;
            this.appointmentReasonErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentReasonErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.appointmentReasonErrorLabel.Location = new System.Drawing.Point(821, 298);
            this.appointmentReasonErrorLabel.Name = "appointmentReasonErrorLabel";
            this.appointmentReasonErrorLabel.Size = new System.Drawing.Size(0, 25);
            this.appointmentReasonErrorLabel.TabIndex = 30;
            // 
            // appointmentDoctorErrorLabel
            // 
            this.appointmentDoctorErrorLabel.AutoSize = true;
            this.appointmentDoctorErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDoctorErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.appointmentDoctorErrorLabel.Location = new System.Drawing.Point(877, 133);
            this.appointmentDoctorErrorLabel.Name = "appointmentDoctorErrorLabel";
            this.appointmentDoctorErrorLabel.Size = new System.Drawing.Size(0, 25);
            this.appointmentDoctorErrorLabel.TabIndex = 29;
            // 
            // appointmentTimeErrorLabel
            // 
            this.appointmentTimeErrorLabel.AutoSize = true;
            this.appointmentTimeErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTimeErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.appointmentTimeErrorLabel.Location = new System.Drawing.Point(372, 135);
            this.appointmentTimeErrorLabel.Name = "appointmentTimeErrorLabel";
            this.appointmentTimeErrorLabel.Size = new System.Drawing.Size(0, 25);
            this.appointmentTimeErrorLabel.TabIndex = 28;
            // 
            // appointmentDateErrorLabel
            // 
            this.appointmentDateErrorLabel.AutoSize = true;
            this.appointmentDateErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.appointmentDateErrorLabel.Location = new System.Drawing.Point(122, 133);
            this.appointmentDateErrorLabel.Name = "appointmentDateErrorLabel";
            this.appointmentDateErrorLabel.Size = new System.Drawing.Size(0, 25);
            this.appointmentDateErrorLabel.TabIndex = 27;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(650, 326);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(290, 47);
            this.cancelButton.TabIndex = 26;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.AutoSize = true;
            this.addAppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentButton.Location = new System.Drawing.Point(175, 326);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(290, 47);
            this.addAppointmentButton.TabIndex = 25;
            this.addAppointmentButton.Text = "Add Appointment";
            this.addAppointmentButton.UseVisualStyleBackColor = true;
            this.addAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // reasonForVisitLabel
            // 
            this.reasonForVisitLabel.AutoSize = true;
            this.reasonForVisitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonForVisitLabel.Location = new System.Drawing.Point(70, 156);
            this.reasonForVisitLabel.Name = "reasonForVisitLabel";
            this.reasonForVisitLabel.Size = new System.Drawing.Size(254, 37);
            this.reasonForVisitLabel.TabIndex = 24;
            this.reasonForVisitLabel.Text = "Reason For Visit";
            // 
            // reasonForVisitTextBox
            // 
            this.reasonForVisitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonForVisitTextBox.Location = new System.Drawing.Point(49, 196);
            this.reasonForVisitTextBox.MaxLength = 200;
            this.reasonForVisitTextBox.Multiline = true;
            this.reasonForVisitTextBox.Name = "reasonForVisitTextBox";
            this.reasonForVisitTextBox.Size = new System.Drawing.Size(1076, 98);
            this.reasonForVisitTextBox.TabIndex = 23;
            this.reasonForVisitTextBox.TextChanged += new System.EventHandler(this.ReasonForVisitTextBox_TextChanged);
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DataSource = this.doctorBindingSource;
            this.doctorComboBox.DisplayMember = "FullName";
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(590, 88);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(535, 45);
            this.doctorComboBox.TabIndex = 22;
            this.doctorComboBox.ValueMember = "DoctorId";
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.DoctorComboBox_SelectedIndexChanged);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(SmartClinic.Model.Doctor);
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorLabel.Location = new System.Drawing.Point(793, 48);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(112, 37);
            this.doctorLabel.TabIndex = 21;
            this.doctorLabel.Text = "Doctor";
            // 
            // appointmentTimePicker
            // 
            this.appointmentTimePicker.Checked = false;
            this.appointmentTimePicker.CustomFormat = " ---";
            this.appointmentTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.appointmentTimePicker.Location = new System.Drawing.Point(380, 88);
            this.appointmentTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.appointmentTimePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.appointmentTimePicker.Name = "appointmentTimePicker";
            this.appointmentTimePicker.ShowUpDown = true;
            this.appointmentTimePicker.Size = new System.Drawing.Size(180, 44);
            this.appointmentTimePicker.TabIndex = 20;
            this.appointmentTimePicker.Value = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
            this.appointmentTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppointmentTimePicker_MouseDown);
            // 
            // appointmentTimeLabel
            // 
            this.appointmentTimeLabel.AutoSize = true;
            this.appointmentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentTimeLabel.Location = new System.Drawing.Point(425, 48);
            this.appointmentTimeLabel.Name = "appointmentTimeLabel";
            this.appointmentTimeLabel.Size = new System.Drawing.Size(88, 37);
            this.appointmentTimeLabel.TabIndex = 19;
            this.appointmentTimeLabel.Text = "Time";
            // 
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 896);
            this.Controls.Add(this.searchForPatientsGroupBox);
            this.Controls.Add(this.newAppoinmentGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Appointment";
            this.Load += new System.EventHandler(this.NewAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.searchForPatientsGroupBox.ResumeLayout(false);
            this.searchForPatientsGroupBox.PerformLayout();
            this.newAppoinmentGroupBox.ResumeLayout(false);
            this.newAppoinmentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.GroupBox searchForPatientsGroupBox;
        private System.Windows.Forms.GroupBox newAppoinmentGroupBox;
        private System.Windows.Forms.Label appointmentTimeLabel;
        private System.Windows.Forms.DateTimePicker appointmentTimePicker;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Label reasonForVisitLabel;
        private System.Windows.Forms.TextBox reasonForVisitTextBox;
        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label appointmentDateErrorLabel;
        private System.Windows.Forms.Label appointmentTimeErrorLabel;
        private System.Windows.Forms.Label appointmentDoctorErrorLabel;
        private System.Windows.Forms.Label appointmentReasonErrorLabel;
        private System.Windows.Forms.Button searchPatientButton;
        private System.Windows.Forms.Label patientFullNameValueLabel;
    }
}