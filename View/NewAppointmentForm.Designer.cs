
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
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
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
            this.patientFirstNameTextBox.Size = new System.Drawing.Size(242, 44);
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
            this.patientLastNameLabel.Location = new System.Drawing.Point(477, 86);
            this.patientLastNameLabel.Name = "patientLastNameLabel";
            this.patientLastNameLabel.Size = new System.Drawing.Size(173, 37);
            this.patientLastNameLabel.TabIndex = 4;
            this.patientLastNameLabel.Text = "Last Name";
            // 
            // patientLastNameTextBox
            // 
            this.patientLastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLastNameTextBox.Location = new System.Drawing.Point(656, 83);
            this.patientLastNameTextBox.Name = "patientLastNameTextBox";
            this.patientLastNameTextBox.Size = new System.Drawing.Size(242, 44);
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
            this.patiendIdTextBox.Size = new System.Drawing.Size(242, 44);
            this.patiendIdTextBox.TabIndex = 5;
            // 
            // patientDateOfBirthLabel
            // 
            this.patientDateOfBirthLabel.AutoSize = true;
            this.patientDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthLabel.Location = new System.Drawing.Point(455, 149);
            this.patientDateOfBirthLabel.Name = "patientDateOfBirthLabel";
            this.patientDateOfBirthLabel.Size = new System.Drawing.Size(195, 37);
            this.patientDateOfBirthLabel.TabIndex = 7;
            this.patientDateOfBirthLabel.Text = "Date of Birth";
            // 
            // patiendDateOfBirthDateTimePicker
            // 
            this.patiendDateOfBirthDateTimePicker.Checked = false;
            this.patiendDateOfBirthDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.patiendDateOfBirthDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patiendDateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.patiendDateOfBirthDateTimePicker.Location = new System.Drawing.Point(656, 146);
            this.patiendDateOfBirthDateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.patiendDateOfBirthDateTimePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.patiendDateOfBirthDateTimePicker.Name = "patiendDateOfBirthDateTimePicker";
            this.patiendDateOfBirthDateTimePicker.ShowCheckBox = true;
            this.patiendDateOfBirthDateTimePicker.Size = new System.Drawing.Size(242, 44);
            this.patiendDateOfBirthDateTimePicker.TabIndex = 8;
            this.patiendDateOfBirthDateTimePicker.Value = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            // 
            // searchPatientsButton
            // 
            this.searchPatientsButton.AutoSize = true;
            this.searchPatientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientsButton.Location = new System.Drawing.Point(929, 83);
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
            this.clearSearchFieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchFieldsButton.Location = new System.Drawing.Point(1074, 83);
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
            this.newPatientButton.Location = new System.Drawing.Point(929, 146);
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
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.street1DataGridViewTextBoxColumn,
            this.street2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.patientsDataGridView.DataSource = this.patientBindingSource;
            this.patientsDataGridView.Location = new System.Drawing.Point(21, 232);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.ReadOnly = true;
            this.patientsDataGridView.RowHeadersWidth = 82;
            this.patientsDataGridView.RowTemplate.Height = 33;
            this.patientsDataGridView.Size = new System.Drawing.Size(1174, 258);
            this.patientsDataGridView.TabIndex = 12;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(SmartClinic.Model.Patient);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 200;
            // 
            // street1DataGridViewTextBoxColumn
            // 
            this.street1DataGridViewTextBoxColumn.DataPropertyName = "Street1";
            this.street1DataGridViewTextBoxColumn.HeaderText = "Street1";
            this.street1DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.street1DataGridViewTextBoxColumn.Name = "street1DataGridViewTextBoxColumn";
            this.street1DataGridViewTextBoxColumn.ReadOnly = true;
            this.street1DataGridViewTextBoxColumn.Width = 200;
            // 
            // street2DataGridViewTextBoxColumn
            // 
            this.street2DataGridViewTextBoxColumn.DataPropertyName = "Street2";
            this.street2DataGridViewTextBoxColumn.HeaderText = "Street2";
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
            // NewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 864);
            this.Controls.Add(this.patientsDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn street1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn street2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientBindingSource;
    }
}