
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
            this.patientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.patientFirstNameLabel = new System.Windows.Forms.Label();
            this.patientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.patientLastNameLabel = new System.Windows.Forms.Label();
            this.patientDateOfBirthLabel = new System.Windows.Forms.Label();
            this.patientDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clearSearchFieldsButton = new System.Windows.Forms.Button();
            this.searchPatientsButton = new System.Windows.Forms.Button();
            this.searchForAppointmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.resultsReturnedLabel = new System.Windows.Forms.Label();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentSearchResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchForAppointmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patientFirstNameTextBox
            // 
            this.patientFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFirstNameTextBox.Location = new System.Drawing.Point(212, 58);
            this.patientFirstNameTextBox.Name = "patientFirstNameTextBox";
            this.patientFirstNameTextBox.Size = new System.Drawing.Size(242, 44);
            this.patientFirstNameTextBox.TabIndex = 3;
            // 
            // patientFirstNameLabel
            // 
            this.patientFirstNameLabel.AutoSize = true;
            this.patientFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFirstNameLabel.Location = new System.Drawing.Point(31, 61);
            this.patientFirstNameLabel.Name = "patientFirstNameLabel";
            this.patientFirstNameLabel.Size = new System.Drawing.Size(175, 37);
            this.patientFirstNameLabel.TabIndex = 4;
            this.patientFirstNameLabel.Text = "First Name";
            // 
            // patientLastNameTextBox
            // 
            this.patientLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLastNameTextBox.Location = new System.Drawing.Point(212, 126);
            this.patientLastNameTextBox.Name = "patientLastNameTextBox";
            this.patientLastNameTextBox.Size = new System.Drawing.Size(242, 44);
            this.patientLastNameTextBox.TabIndex = 5;
            // 
            // patientLastNameLabel
            // 
            this.patientLastNameLabel.AutoSize = true;
            this.patientLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLastNameLabel.Location = new System.Drawing.Point(33, 129);
            this.patientLastNameLabel.Name = "patientLastNameLabel";
            this.patientLastNameLabel.Size = new System.Drawing.Size(173, 37);
            this.patientLastNameLabel.TabIndex = 6;
            this.patientLastNameLabel.Text = "Last Name";
            // 
            // patientDateOfBirthLabel
            // 
            this.patientDateOfBirthLabel.AutoSize = true;
            this.patientDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthLabel.Location = new System.Drawing.Point(11, 199);
            this.patientDateOfBirthLabel.Name = "patientDateOfBirthLabel";
            this.patientDateOfBirthLabel.Size = new System.Drawing.Size(195, 37);
            this.patientDateOfBirthLabel.TabIndex = 9;
            this.patientDateOfBirthLabel.Text = "Date of Birth";
            // 
            // patientDateOfBirthDateTimePicker
            // 
            this.patientDateOfBirthDateTimePicker.Checked = false;
            this.patientDateOfBirthDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.patientDateOfBirthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.patientDateOfBirthDateTimePicker.Location = new System.Drawing.Point(212, 196);
            this.patientDateOfBirthDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.patientDateOfBirthDateTimePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.patientDateOfBirthDateTimePicker.Name = "patientDateOfBirthDateTimePicker";
            this.patientDateOfBirthDateTimePicker.ShowCheckBox = true;
            this.patientDateOfBirthDateTimePicker.Size = new System.Drawing.Size(242, 44);
            this.patientDateOfBirthDateTimePicker.TabIndex = 10;
            this.patientDateOfBirthDateTimePicker.Value = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
            // 
            // clearSearchFieldsButton
            // 
            this.clearSearchFieldsButton.AutoSize = true;
            this.clearSearchFieldsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearchFieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchFieldsButton.Location = new System.Drawing.Point(259, 265);
            this.clearSearchFieldsButton.Name = "clearSearchFieldsButton";
            this.clearSearchFieldsButton.Size = new System.Drawing.Size(121, 47);
            this.clearSearchFieldsButton.TabIndex = 12;
            this.clearSearchFieldsButton.Text = "Clear";
            this.clearSearchFieldsButton.UseVisualStyleBackColor = true;
            this.clearSearchFieldsButton.Click += new System.EventHandler(this.ClearSearchFieldsButton_Click);
            // 
            // searchPatientsButton
            // 
            this.searchPatientsButton.AutoSize = true;
            this.searchPatientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPatientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientsButton.Location = new System.Drawing.Point(78, 265);
            this.searchPatientsButton.Name = "searchPatientsButton";
            this.searchPatientsButton.Size = new System.Drawing.Size(128, 47);
            this.searchPatientsButton.TabIndex = 11;
            this.searchPatientsButton.Text = "Search";
            this.searchPatientsButton.UseVisualStyleBackColor = true;
            this.searchPatientsButton.Click += new System.EventHandler(this.SearchPatientsButton_Click);
            // 
            // searchForAppointmentsGroupBox
            // 
            this.searchForAppointmentsGroupBox.Controls.Add(this.resultsReturnedLabel);
            this.searchForAppointmentsGroupBox.Controls.Add(this.clearSearchFieldsButton);
            this.searchForAppointmentsGroupBox.Controls.Add(this.patientFirstNameTextBox);
            this.searchForAppointmentsGroupBox.Controls.Add(this.searchPatientsButton);
            this.searchForAppointmentsGroupBox.Controls.Add(this.patientFirstNameLabel);
            this.searchForAppointmentsGroupBox.Controls.Add(this.patientDateOfBirthLabel);
            this.searchForAppointmentsGroupBox.Controls.Add(this.patientLastNameLabel);
            this.searchForAppointmentsGroupBox.Controls.Add(this.patientDateOfBirthDateTimePicker);
            this.searchForAppointmentsGroupBox.Controls.Add(this.patientLastNameTextBox);
            this.searchForAppointmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForAppointmentsGroupBox.Location = new System.Drawing.Point(12, 46);
            this.searchForAppointmentsGroupBox.Name = "searchForAppointmentsGroupBox";
            this.searchForAppointmentsGroupBox.Size = new System.Drawing.Size(496, 368);
            this.searchForAppointmentsGroupBox.TabIndex = 13;
            this.searchForAppointmentsGroupBox.TabStop = false;
            this.searchForAppointmentsGroupBox.Text = "Search for Appointments";
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
            this.appointmentsDataGridView.Location = new System.Drawing.Point(524, 20);
            this.appointmentsDataGridView.MultiSelect = false;
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.ReadOnly = true;
            this.appointmentsDataGridView.RowHeadersWidth = 82;
            this.appointmentsDataGridView.RowTemplate.Height = 33;
            this.appointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(914, 474);
            this.appointmentsDataGridView.TabIndex = 14;
            // 
            // resultsReturnedLabel
            // 
            this.resultsReturnedLabel.AutoSize = true;
            this.resultsReturnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsReturnedLabel.Location = new System.Drawing.Point(131, 325);
            this.resultsReturnedLabel.Name = "resultsReturnedLabel";
            this.resultsReturnedLabel.Size = new System.Drawing.Size(0, 31);
            this.resultsReturnedLabel.TabIndex = 13;
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
            // AppointmentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appointmentsDataGridView);
            this.Controls.Add(this.searchForAppointmentsGroupBox);
            this.Name = "AppointmentsUserControl";
            this.Size = new System.Drawing.Size(1456, 524);
            this.searchForAppointmentsGroupBox.ResumeLayout(false);
            this.searchForAppointmentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox patientFirstNameTextBox;
        private System.Windows.Forms.Label patientFirstNameLabel;
        private System.Windows.Forms.TextBox patientLastNameTextBox;
        private System.Windows.Forms.Label patientLastNameLabel;
        private System.Windows.Forms.Label patientDateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker patientDateOfBirthDateTimePicker;
        private System.Windows.Forms.Button clearSearchFieldsButton;
        private System.Windows.Forms.Button searchPatientsButton;
        private System.Windows.Forms.GroupBox searchForAppointmentsGroupBox;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentSearchResultBindingSource;
        private System.Windows.Forms.Label resultsReturnedLabel;
    }
}
