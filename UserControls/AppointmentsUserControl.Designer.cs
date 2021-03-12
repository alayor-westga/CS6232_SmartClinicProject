
namespace SmartClinic.UserControls
{
    partial class AppointmentsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentSearchResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewAppointmentButton = new System.Windows.Forms.Button();
            this.searchForPatientsGroupBox = new System.Windows.Forms.GroupBox();
            this.patientDateOfBirthValueLabel = new System.Windows.Forms.Label();
            this.patientAddressValueLabel = new System.Windows.Forms.Label();
            this.patientAddressLabel = new System.Windows.Forms.Label();
            this.patientDateOfBirthLabel = new System.Windows.Forms.Label();
            this.patientIdValueLabel = new System.Windows.Forms.Label();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.patientFullNameValueLabel = new System.Windows.Forms.Label();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.appointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.newPatientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).BeginInit();
            this.searchForPatientsGroupBox.SuspendLayout();
            this.appointmentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.AllowUserToAddRows = false;
            this.appointmentsDataGridView.AllowUserToDeleteRows = false;
            this.appointmentsDataGridView.AutoGenerateColumns = false;
            this.appointmentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentDateDataGridViewTextBoxColumn,
            this.patientFullNameDataGridViewTextBoxColumn,
            this.patientDateOfBirthDataGridViewTextBoxColumn,
            this.patientAddressDataGridViewTextBoxColumn,
            this.doctorFullNameDataGridViewTextBoxColumn});
            this.appointmentsDataGridView.DataSource = this.appointmentSearchResultBindingSource;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(19, 66);
            this.appointmentsDataGridView.MultiSelect = false;
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.ReadOnly = true;
            this.appointmentsDataGridView.RowHeadersWidth = 82;
            this.appointmentsDataGridView.RowTemplate.Height = 33;
            this.appointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(1160, 340);
            this.appointmentsDataGridView.TabIndex = 14;
            this.appointmentsDataGridView.SelectionChanged += new System.EventHandler(this.AppointmentsDataGridView_SelectionChanged);
            this.appointmentsDataGridView.DoubleClick += new System.EventHandler(this.AppointmentsDataGridView_DoubleClick);
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            this.appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "AppointmentDate";
            this.appointmentDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.appointmentDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            this.appointmentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientFullNameDataGridViewTextBoxColumn
            // 
            this.patientFullNameDataGridViewTextBoxColumn.DataPropertyName = "PatientFullName";
            this.patientFullNameDataGridViewTextBoxColumn.HeaderText = "Patient";
            this.patientFullNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.patientFullNameDataGridViewTextBoxColumn.Name = "patientFullNameDataGridViewTextBoxColumn";
            this.patientFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientDateOfBirthDataGridViewTextBoxColumn
            // 
            this.patientDateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "PatientDateOfBirth";
            this.patientDateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.patientDateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.patientDateOfBirthDataGridViewTextBoxColumn.Name = "patientDateOfBirthDataGridViewTextBoxColumn";
            this.patientDateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientAddressDataGridViewTextBoxColumn
            // 
            this.patientAddressDataGridViewTextBoxColumn.DataPropertyName = "PatientAddress";
            this.patientAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.patientAddressDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.patientAddressDataGridViewTextBoxColumn.Name = "patientAddressDataGridViewTextBoxColumn";
            this.patientAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorFullNameDataGridViewTextBoxColumn
            // 
            this.doctorFullNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorFullName";
            this.doctorFullNameDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorFullNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.doctorFullNameDataGridViewTextBoxColumn.Name = "doctorFullNameDataGridViewTextBoxColumn";
            this.doctorFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentSearchResultBindingSource
            // 
            this.appointmentSearchResultBindingSource.DataSource = typeof(SmartClinic.Model.AppointmentSearchResult);
            // 
            // viewAppointmentButton
            // 
            this.viewAppointmentButton.AutoSize = true;
            this.viewAppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAppointmentButton.Enabled = false;
            this.viewAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAppointmentButton.Location = new System.Drawing.Point(938, 429);
            this.viewAppointmentButton.Name = "viewAppointmentButton";
            this.viewAppointmentButton.Size = new System.Drawing.Size(241, 47);
            this.viewAppointmentButton.TabIndex = 14;
            this.viewAppointmentButton.Text = "View / Edit";
            this.viewAppointmentButton.UseVisualStyleBackColor = true;
            this.viewAppointmentButton.Click += new System.EventHandler(this.ViewAppointmentButton_Click);
            // 
            // searchForPatientsGroupBox
            // 
            this.searchForPatientsGroupBox.Controls.Add(this.newPatientButton);
            this.searchForPatientsGroupBox.Controls.Add(this.patientDateOfBirthValueLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.patientAddressValueLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.patientAddressLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.patientDateOfBirthLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.patientIdValueLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.patientIdLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.patientNameLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.patientFullNameValueLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.searchPatientButton);
            this.searchForPatientsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForPatientsGroupBox.Location = new System.Drawing.Point(12, 22);
            this.searchForPatientsGroupBox.Name = "searchForPatientsGroupBox";
            this.searchForPatientsGroupBox.Size = new System.Drawing.Size(1202, 226);
            this.searchForPatientsGroupBox.TabIndex = 20;
            this.searchForPatientsGroupBox.TabStop = false;
            this.searchForPatientsGroupBox.Text = "Search for a patient";
            // 
            // patientDateOfBirthValueLabel
            // 
            this.patientDateOfBirthValueLabel.AutoSize = true;
            this.patientDateOfBirthValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthValueLabel.Location = new System.Drawing.Point(931, 89);
            this.patientDateOfBirthValueLabel.Name = "patientDateOfBirthValueLabel";
            this.patientDateOfBirthValueLabel.Size = new System.Drawing.Size(27, 37);
            this.patientDateOfBirthValueLabel.TabIndex = 36;
            this.patientDateOfBirthValueLabel.Text = "-";
            // 
            // patientAddressValueLabel
            // 
            this.patientAddressValueLabel.AutoSize = true;
            this.patientAddressValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAddressValueLabel.Location = new System.Drawing.Point(453, 149);
            this.patientAddressValueLabel.Name = "patientAddressValueLabel";
            this.patientAddressValueLabel.Size = new System.Drawing.Size(27, 37);
            this.patientAddressValueLabel.TabIndex = 38;
            this.patientAddressValueLabel.Text = "-";
            // 
            // patientAddressLabel
            // 
            this.patientAddressLabel.AutoSize = true;
            this.patientAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAddressLabel.Location = new System.Drawing.Point(317, 149);
            this.patientAddressLabel.Name = "patientAddressLabel";
            this.patientAddressLabel.Size = new System.Drawing.Size(144, 37);
            this.patientAddressLabel.TabIndex = 37;
            this.patientAddressLabel.Text = "Address:";
            // 
            // patientDateOfBirthLabel
            // 
            this.patientDateOfBirthLabel.AutoSize = true;
            this.patientDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthLabel.Location = new System.Drawing.Point(733, 89);
            this.patientDateOfBirthLabel.Name = "patientDateOfBirthLabel";
            this.patientDateOfBirthLabel.Size = new System.Drawing.Size(204, 37);
            this.patientDateOfBirthLabel.TabIndex = 35;
            this.patientDateOfBirthLabel.Text = "Date of Birth:";
            // 
            // patientIdValueLabel
            // 
            this.patientIdValueLabel.AutoSize = true;
            this.patientIdValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdValueLabel.Location = new System.Drawing.Point(370, 34);
            this.patientIdValueLabel.Name = "patientIdValueLabel";
            this.patientIdValueLabel.Size = new System.Drawing.Size(27, 37);
            this.patientIdValueLabel.TabIndex = 34;
            this.patientIdValueLabel.Text = "-";
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabel.Location = new System.Drawing.Point(317, 34);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(57, 37);
            this.patientIdLabel.TabIndex = 33;
            this.patientIdLabel.Text = "ID:";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(317, 89);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(112, 37);
            this.patientNameLabel.TabIndex = 32;
            this.patientNameLabel.Text = "Name:";
            // 
            // patientFullNameValueLabel
            // 
            this.patientFullNameValueLabel.AutoSize = true;
            this.patientFullNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFullNameValueLabel.Location = new System.Drawing.Point(425, 89);
            this.patientFullNameValueLabel.Name = "patientFullNameValueLabel";
            this.patientFullNameValueLabel.Size = new System.Drawing.Size(27, 37);
            this.patientFullNameValueLabel.TabIndex = 31;
            this.patientFullNameValueLabel.Text = "-";
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.AutoSize = true;
            this.searchPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientButton.Location = new System.Drawing.Point(31, 68);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(250, 47);
            this.searchPatientButton.TabIndex = 15;
            this.searchPatientButton.Text = "Search Patient";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            this.searchPatientButton.Click += new System.EventHandler(this.SearchPatientButton_Click);
            // 
            // appointmentsGroupBox
            // 
            this.appointmentsGroupBox.Controls.Add(this.searchMessageLabel);
            this.appointmentsGroupBox.Controls.Add(this.viewAppointmentButton);
            this.appointmentsGroupBox.Controls.Add(this.appointmentsDataGridView);
            this.appointmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsGroupBox.Location = new System.Drawing.Point(12, 278);
            this.appointmentsGroupBox.Name = "appointmentsGroupBox";
            this.appointmentsGroupBox.Size = new System.Drawing.Size(1202, 495);
            this.appointmentsGroupBox.TabIndex = 21;
            this.appointmentsGroupBox.TabStop = false;
            this.appointmentsGroupBox.Text = "Appointments";
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.searchMessageLabel.Location = new System.Drawing.Point(885, 20);
            this.searchMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(268, 29);
            this.searchMessageLabel.TabIndex = 26;
            // 
            // newPatientButton
            // 
            this.newPatientButton.AutoSize = true;
            this.newPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientButton.Location = new System.Drawing.Point(31, 139);
            this.newPatientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(250, 47);
            this.newPatientButton.TabIndex = 39;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.NewPatientButton_Click);
            // 
            // AppointmentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchForPatientsGroupBox);
            this.Controls.Add(this.appointmentsGroupBox);
            this.Name = "AppointmentsUserControl";
            this.Size = new System.Drawing.Size(1236, 790);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).EndInit();
            this.searchForPatientsGroupBox.ResumeLayout(false);
            this.searchForPatientsGroupBox.PerformLayout();
            this.appointmentsGroupBox.ResumeLayout(false);
            this.appointmentsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentSearchResultBindingSource;
        private System.Windows.Forms.Button viewAppointmentButton;
        private System.Windows.Forms.GroupBox searchForPatientsGroupBox;
        private System.Windows.Forms.Label patientDateOfBirthValueLabel;
        private System.Windows.Forms.Label patientAddressValueLabel;
        private System.Windows.Forms.Label patientAddressLabel;
        private System.Windows.Forms.Label patientDateOfBirthLabel;
        private System.Windows.Forms.Label patientIdValueLabel;
        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label patientFullNameValueLabel;
        private System.Windows.Forms.Button searchPatientButton;
        private System.Windows.Forms.GroupBox appointmentsGroupBox;
        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.Button newPatientButton;
    }
}
