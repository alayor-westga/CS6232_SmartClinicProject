
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
            this.patientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.patientFirstNameLabel = new System.Windows.Forms.Label();
            this.patientLastNameLabel = new System.Windows.Forms.Label();
            this.patientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.patientDateOfBirthLabel = new System.Windows.Forms.Label();
            this.patiendDateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchPatientsButton = new System.Windows.Forms.Button();
            this.clearSearchFieldsButton = new System.Windows.Forms.Button();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIdNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchForPatientsGroupBox = new System.Windows.Forms.GroupBox();
            this.newAppoinmentGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIdNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.searchForPatientsGroupBox.SuspendLayout();
            this.newAppoinmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientFirstNameTextBox
            // 
            this.patientFirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFirstNameTextBox.Location = new System.Drawing.Point(189, 61);
            this.patientFirstNameTextBox.Name = "patientFirstNameTextBox";
            this.patientFirstNameTextBox.Size = new System.Drawing.Size(242, 44);
            this.patientFirstNameTextBox.TabIndex = 1;
            // 
            // patientFirstNameLabel
            // 
            this.patientFirstNameLabel.AutoSize = true;
            this.patientFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFirstNameLabel.Location = new System.Drawing.Point(8, 64);
            this.patientFirstNameLabel.Name = "patientFirstNameLabel";
            this.patientFirstNameLabel.Size = new System.Drawing.Size(175, 37);
            this.patientFirstNameLabel.TabIndex = 2;
            this.patientFirstNameLabel.Text = "First Name";
            // 
            // patientLastNameLabel
            // 
            this.patientLastNameLabel.AutoSize = true;
            this.patientLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLastNameLabel.Location = new System.Drawing.Point(471, 64);
            this.patientLastNameLabel.Name = "patientLastNameLabel";
            this.patientLastNameLabel.Size = new System.Drawing.Size(173, 37);
            this.patientLastNameLabel.TabIndex = 4;
            this.patientLastNameLabel.Text = "Last Name";
            // 
            // patientLastNameTextBox
            // 
            this.patientLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLastNameTextBox.Location = new System.Drawing.Point(650, 61);
            this.patientLastNameTextBox.Name = "patientLastNameTextBox";
            this.patientLastNameTextBox.Size = new System.Drawing.Size(242, 44);
            this.patientLastNameTextBox.TabIndex = 3;
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdLabel.Location = new System.Drawing.Point(27, 127);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(156, 37);
            this.patientIdLabel.TabIndex = 6;
            this.patientIdLabel.Text = "Patient ID";
            // 
            // patientDateOfBirthLabel
            // 
            this.patientDateOfBirthLabel.AutoSize = true;
            this.patientDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthLabel.Location = new System.Drawing.Point(449, 127);
            this.patientDateOfBirthLabel.Name = "patientDateOfBirthLabel";
            this.patientDateOfBirthLabel.Size = new System.Drawing.Size(195, 37);
            this.patientDateOfBirthLabel.TabIndex = 7;
            this.patientDateOfBirthLabel.Text = "Date of Birth";
            // 
            // patiendDateOfBirthDateTimePicker
            // 
            this.patiendDateOfBirthDateTimePicker.Checked = false;
            this.patiendDateOfBirthDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.patiendDateOfBirthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patiendDateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.patiendDateOfBirthDateTimePicker.Location = new System.Drawing.Point(650, 124);
            this.patiendDateOfBirthDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.patiendDateOfBirthDateTimePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.patiendDateOfBirthDateTimePicker.Name = "patiendDateOfBirthDateTimePicker";
            this.patiendDateOfBirthDateTimePicker.ShowCheckBox = true;
            this.patiendDateOfBirthDateTimePicker.Size = new System.Drawing.Size(242, 44);
            this.patiendDateOfBirthDateTimePicker.TabIndex = 8;
            this.patiendDateOfBirthDateTimePicker.Value = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
            // 
            // searchPatientsButton
            // 
            this.searchPatientsButton.AutoSize = true;
            this.searchPatientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPatientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientsButton.Location = new System.Drawing.Point(923, 61);
            this.searchPatientsButton.Name = "searchPatientsButton";
            this.searchPatientsButton.Size = new System.Drawing.Size(128, 47);
            this.searchPatientsButton.TabIndex = 9;
            this.searchPatientsButton.Text = "Search";
            this.searchPatientsButton.UseVisualStyleBackColor = true;
            this.searchPatientsButton.Click += new System.EventHandler(this.SearchPatientsButton_Click);
            // 
            // clearSearchFieldsButton
            // 
            this.clearSearchFieldsButton.AutoSize = true;
            this.clearSearchFieldsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearchFieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchFieldsButton.Location = new System.Drawing.Point(1068, 61);
            this.clearSearchFieldsButton.Name = "clearSearchFieldsButton";
            this.clearSearchFieldsButton.Size = new System.Drawing.Size(121, 47);
            this.clearSearchFieldsButton.TabIndex = 10;
            this.clearSearchFieldsButton.Text = "Clear";
            this.clearSearchFieldsButton.UseVisualStyleBackColor = true;
            // 
            // newPatientButton
            // 
            this.newPatientButton.AutoSize = true;
            this.newPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientButton.Location = new System.Drawing.Point(923, 124);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(266, 47);
            this.newPatientButton.TabIndex = 11;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.AllowUserToAddRows = false;
            this.patientsDataGridView.AllowUserToDeleteRows = false;
            this.patientsDataGridView.AutoGenerateColumns = false;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.street1DataGridViewTextBoxColumn,
            this.street2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.patientsDataGridView.DataSource = this.patientBindingSource;
            this.patientsDataGridView.Location = new System.Drawing.Point(15, 190);
            this.patientsDataGridView.MultiSelect = false;
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.ReadOnly = true;
            this.patientsDataGridView.RowHeadersWidth = 82;
            this.patientsDataGridView.RowTemplate.Height = 33;
            this.patientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientsDataGridView.Size = new System.Drawing.Size(1174, 258);
            this.patientsDataGridView.TabIndex = 12;
            this.patientsDataGridView.SelectionChanged += new System.EventHandler(this.PatientsDataGridView_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PatientId";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // patientIdNumericUpdown
            // 
            this.patientIdNumericUpdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdNumericUpdown.Location = new System.Drawing.Point(189, 124);
            this.patientIdNumericUpdown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.patientIdNumericUpdown.Name = "patientIdNumericUpdown";
            this.patientIdNumericUpdown.Size = new System.Drawing.Size(242, 44);
            this.patientIdNumericUpdown.TabIndex = 14;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 200;
            // 
            // street1DataGridViewTextBoxColumn
            // 
            this.street1DataGridViewTextBoxColumn.DataPropertyName = "Street1";
            this.street1DataGridViewTextBoxColumn.HeaderText = "Street 1";
            this.street1DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.street1DataGridViewTextBoxColumn.Name = "street1DataGridViewTextBoxColumn";
            this.street1DataGridViewTextBoxColumn.ReadOnly = true;
            this.street1DataGridViewTextBoxColumn.Width = 200;
            // 
            // street2DataGridViewTextBoxColumn
            // 
            this.street2DataGridViewTextBoxColumn.DataPropertyName = "Street2";
            this.street2DataGridViewTextBoxColumn.HeaderText = "Street 2";
            this.street2DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.street2DataGridViewTextBoxColumn.Name = "street2DataGridViewTextBoxColumn";
            this.street2DataGridViewTextBoxColumn.ReadOnly = true;
            this.street2DataGridViewTextBoxColumn.Width = 200;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 200;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 200;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(SmartClinic.Model.Patient);
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateLabel.Location = new System.Drawing.Point(8, 52);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(274, 37);
            this.appointmentDateLabel.TabIndex = 17;
            this.appointmentDateLabel.Text = "Appointment Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 92);
            this.dateTimePicker1.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 44);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2021, 3, 6, 0, 0, 0, 0);
            // 
            // searchForPatientsGroupBox
            // 
            this.searchForPatientsGroupBox.Controls.Add(this.patientsDataGridView);
            this.searchForPatientsGroupBox.Controls.Add(this.patientFirstNameTextBox);
            this.searchForPatientsGroupBox.Controls.Add(this.patientFirstNameLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.patientIdNumericUpdown);
            this.searchForPatientsGroupBox.Controls.Add(this.patientLastNameTextBox);
            this.searchForPatientsGroupBox.Controls.Add(this.patientLastNameLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.newPatientButton);
            this.searchForPatientsGroupBox.Controls.Add(this.patientIdLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.clearSearchFieldsButton);
            this.searchForPatientsGroupBox.Controls.Add(this.patientDateOfBirthLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.searchPatientsButton);
            this.searchForPatientsGroupBox.Controls.Add(this.patiendDateOfBirthDateTimePicker);
            this.searchForPatientsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForPatientsGroupBox.Location = new System.Drawing.Point(6, 12);
            this.searchForPatientsGroupBox.Name = "searchForPatientsGroupBox";
            this.searchForPatientsGroupBox.Size = new System.Drawing.Size(1202, 478);
            this.searchForPatientsGroupBox.TabIndex = 19;
            this.searchForPatientsGroupBox.TabStop = false;
            this.searchForPatientsGroupBox.Text = "Search for Patients";
            // 
            // newAppoinmentGroupBox
            // 
            this.newAppoinmentGroupBox.Controls.Add(this.dateTimePicker1);
            this.newAppoinmentGroupBox.Controls.Add(this.appointmentDateLabel);
            this.newAppoinmentGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAppoinmentGroupBox.Location = new System.Drawing.Point(6, 512);
            this.newAppoinmentGroupBox.Name = "newAppoinmentGroupBox";
            this.newAppoinmentGroupBox.Size = new System.Drawing.Size(1202, 340);
            this.newAppoinmentGroupBox.TabIndex = 20;
            this.newAppoinmentGroupBox.TabStop = false;
            // 
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 864);
            this.Controls.Add(this.searchForPatientsGroupBox);
            this.Controls.Add(this.newAppoinmentGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Appointment";
            this.Load += new System.EventHandler(this.NewAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIdNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.searchForPatientsGroupBox.ResumeLayout(false);
            this.searchForPatientsGroupBox.PerformLayout();
            this.newAppoinmentGroupBox.ResumeLayout(false);
            this.newAppoinmentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox patientFirstNameTextBox;
        private System.Windows.Forms.Label patientFirstNameLabel;
        private System.Windows.Forms.Label patientLastNameLabel;
        private System.Windows.Forms.TextBox patientLastNameTextBox;
        private System.Windows.Forms.Label patientIdLabel;
        private System.Windows.Forms.Label patientDateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker patiendDateOfBirthDateTimePicker;
        private System.Windows.Forms.Button searchPatientsButton;
        private System.Windows.Forms.Button clearSearchFieldsButton;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.NumericUpDown patientIdNumericUpdown;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn street1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn street2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox searchForPatientsGroupBox;
        private System.Windows.Forms.GroupBox newAppoinmentGroupBox;
    }
}