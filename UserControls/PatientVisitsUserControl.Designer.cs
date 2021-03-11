
namespace SmartClinic.UserControls
{
    partial class PatientVisitsUserControl
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
            this.doubleClickOptionToViewPatientLabel = new System.Windows.Forms.Label();
            this.viewOrEditPatientVisitDetailsButton = new System.Windows.Forms.Button();
            this.searchForPatientVisitLabel = new System.Windows.Forms.Label();
            this.appointmentSearchResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSearchResultDataGridView = new System.Windows.Forms.DataGridView();
            this.searchForPatientsGroupBox = new System.Windows.Forms.GroupBox();
            this.lastNameCombinedTextBox = new System.Windows.Forms.TextBox();
            this.lastNameCombinedLabel = new System.Windows.Forms.Label();
            this.searchByDOBAndLastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.dobCombinedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.dobCombinedLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchByNamesRadioButton = new System.Windows.Forms.RadioButton();
            this.dobOnlyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.searchByDOBOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dobOnlyLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientSearchResultDataGridView)).BeginInit();
            this.searchForPatientsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // doubleClickOptionToViewPatientLabel
            // 
            this.doubleClickOptionToViewPatientLabel.AutoSize = true;
            this.doubleClickOptionToViewPatientLabel.Location = new System.Drawing.Point(301, 475);
            this.doubleClickOptionToViewPatientLabel.Name = "doubleClickOptionToViewPatientLabel";
            this.doubleClickOptionToViewPatientLabel.Size = new System.Drawing.Size(347, 17);
            this.doubleClickOptionToViewPatientLabel.TabIndex = 43;
            this.doubleClickOptionToViewPatientLabel.Text = "Double-click any row to view or edit a patient\'s details.";
            // 
            // viewOrEditPatientVisitDetailsButton
            // 
            this.viewOrEditPatientVisitDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrEditPatientVisitDetailsButton.Location = new System.Drawing.Point(663, 475);
            this.viewOrEditPatientVisitDetailsButton.Name = "viewOrEditPatientVisitDetailsButton";
            this.viewOrEditPatientVisitDetailsButton.Size = new System.Drawing.Size(309, 35);
            this.viewOrEditPatientVisitDetailsButton.TabIndex = 40;
            this.viewOrEditPatientVisitDetailsButton.Text = "View / Edit Patient Visit Details";
            this.viewOrEditPatientVisitDetailsButton.UseVisualStyleBackColor = true;
            // 
            // searchForPatientVisitLabel
            // 
            this.searchForPatientVisitLabel.AutoSize = true;
            this.searchForPatientVisitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForPatientVisitLabel.Location = new System.Drawing.Point(13, 16);
            this.searchForPatientVisitLabel.Name = "searchForPatientVisitLabel";
            this.searchForPatientVisitLabel.Size = new System.Drawing.Size(226, 25);
            this.searchForPatientVisitLabel.TabIndex = 30;
            this.searchForPatientVisitLabel.Text = "Search For Patient Visits";
            // 
            // appointmentSearchResultBindingSource
            // 
            this.appointmentSearchResultBindingSource.DataSource = typeof(SmartClinic.Model.AppointmentSearchResult);
            // 
            // patientVisitsBindingSource
            // 
            this.patientVisitsBindingSource.DataSource = typeof(SmartClinic.Model.PatientVisits);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DoctorFullName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Doctor";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PatientDateOfBirth";
            this.dataGridViewTextBoxColumn3.FillWeight = 70F;
            this.dataGridViewTextBoxColumn3.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PatientFullName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Patient Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AppointmentDate";
            this.dataGridViewTextBoxColumn2.FillWeight = 90F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Visit Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // patientSearchResultDataGridView
            // 
            this.patientSearchResultDataGridView.AllowUserToAddRows = false;
            this.patientSearchResultDataGridView.AllowUserToDeleteRows = false;
            this.patientSearchResultDataGridView.AutoGenerateColumns = false;
            this.patientSearchResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientSearchResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientSearchResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6});
            this.patientSearchResultDataGridView.DataSource = this.appointmentSearchResultBindingSource;
            this.patientSearchResultDataGridView.Location = new System.Drawing.Point(396, 16);
            this.patientSearchResultDataGridView.Name = "patientSearchResultDataGridView";
            this.patientSearchResultDataGridView.ReadOnly = true;
            this.patientSearchResultDataGridView.RowHeadersWidth = 51;
            this.patientSearchResultDataGridView.RowTemplate.Height = 24;
            this.patientSearchResultDataGridView.Size = new System.Drawing.Size(576, 428);
            this.patientSearchResultDataGridView.TabIndex = 44;
            // 
            // searchForPatientsGroupBox
            // 
            this.searchForPatientsGroupBox.Controls.Add(this.lastNameCombinedTextBox);
            this.searchForPatientsGroupBox.Controls.Add(this.lastNameCombinedLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.searchByDOBAndLastNameRadioButton);
            this.searchForPatientsGroupBox.Controls.Add(this.dobCombinedDatePicker);
            this.searchForPatientsGroupBox.Controls.Add(this.firstNameLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.dobCombinedLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.lastNameLabel);
            this.searchForPatientsGroupBox.Controls.Add(this.searchByNamesRadioButton);
            this.searchForPatientsGroupBox.Controls.Add(this.dobOnlyDatePicker);
            this.searchForPatientsGroupBox.Controls.Add(this.searchByDOBOnlyRadioButton);
            this.searchForPatientsGroupBox.Controls.Add(this.firstNameTextBox);
            this.searchForPatientsGroupBox.Controls.Add(this.lastNameTextBox);
            this.searchForPatientsGroupBox.Controls.Add(this.dobOnlyLabel);
            this.searchForPatientsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForPatientsGroupBox.Location = new System.Drawing.Point(18, 54);
            this.searchForPatientsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchForPatientsGroupBox.Name = "searchForPatientsGroupBox";
            this.searchForPatientsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.searchForPatientsGroupBox.Size = new System.Drawing.Size(373, 266);
            this.searchForPatientsGroupBox.TabIndex = 48;
            this.searchForPatientsGroupBox.TabStop = false;
            this.searchForPatientsGroupBox.Text = "Select a search option";
            // 
            // lastNameCombinedTextBox
            // 
            this.lastNameCombinedTextBox.Enabled = false;
            this.lastNameCombinedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameCombinedTextBox.Location = new System.Drawing.Point(177, 220);
            this.lastNameCombinedTextBox.Name = "lastNameCombinedTextBox";
            this.lastNameCombinedTextBox.Size = new System.Drawing.Size(163, 30);
            this.lastNameCombinedTextBox.TabIndex = 35;
            // 
            // lastNameCombinedLabel
            // 
            this.lastNameCombinedLabel.AutoSize = true;
            this.lastNameCombinedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameCombinedLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lastNameCombinedLabel.Location = new System.Drawing.Point(43, 222);
            this.lastNameCombinedLabel.Name = "lastNameCombinedLabel";
            this.lastNameCombinedLabel.Size = new System.Drawing.Size(112, 25);
            this.lastNameCombinedLabel.TabIndex = 34;
            this.lastNameCombinedLabel.Text = "Last Name:";
            // 
            // searchByDOBAndLastNameRadioButton
            // 
            this.searchByDOBAndLastNameRadioButton.AutoSize = true;
            this.searchByDOBAndLastNameRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDOBAndLastNameRadioButton.Location = new System.Drawing.Point(20, 204);
            this.searchByDOBAndLastNameRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchByDOBAndLastNameRadioButton.Name = "searchByDOBAndLastNameRadioButton";
            this.searchByDOBAndLastNameRadioButton.Size = new System.Drawing.Size(17, 16);
            this.searchByDOBAndLastNameRadioButton.TabIndex = 33;
            this.searchByDOBAndLastNameRadioButton.TabStop = true;
            this.searchByDOBAndLastNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // dobCombinedDatePicker
            // 
            this.dobCombinedDatePicker.CustomFormat = "mm/dd/yyyy";
            this.dobCombinedDatePicker.Enabled = false;
            this.dobCombinedDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobCombinedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobCombinedDatePicker.Location = new System.Drawing.Point(177, 186);
            this.dobCombinedDatePicker.Name = "dobCombinedDatePicker";
            this.dobCombinedDatePicker.Size = new System.Drawing.Size(163, 30);
            this.dobCombinedDatePicker.TabIndex = 32;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.firstNameLabel.Location = new System.Drawing.Point(43, 95);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(112, 25);
            this.firstNameLabel.TabIndex = 16;
            this.firstNameLabel.Text = "First Name:";
            // 
            // dobCombinedLabel
            // 
            this.dobCombinedLabel.AutoSize = true;
            this.dobCombinedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobCombinedLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dobCombinedLabel.Location = new System.Drawing.Point(43, 186);
            this.dobCombinedLabel.Name = "dobCombinedLabel";
            this.dobCombinedLabel.Size = new System.Drawing.Size(124, 25);
            this.dobCombinedLabel.TabIndex = 31;
            this.dobCombinedLabel.Text = "Date of Birth:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lastNameLabel.Location = new System.Drawing.Point(43, 129);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 25);
            this.lastNameLabel.TabIndex = 17;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // searchByNamesRadioButton
            // 
            this.searchByNamesRadioButton.AutoSize = true;
            this.searchByNamesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNamesRadioButton.Location = new System.Drawing.Point(20, 110);
            this.searchByNamesRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchByNamesRadioButton.Name = "searchByNamesRadioButton";
            this.searchByNamesRadioButton.Size = new System.Drawing.Size(17, 16);
            this.searchByNamesRadioButton.TabIndex = 30;
            this.searchByNamesRadioButton.TabStop = true;
            this.searchByNamesRadioButton.UseVisualStyleBackColor = true;
            // 
            // dobOnlyDatePicker
            // 
            this.dobOnlyDatePicker.CustomFormat = "mm/dd/yyyy";
            this.dobOnlyDatePicker.Enabled = false;
            this.dobOnlyDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobOnlyDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobOnlyDatePicker.Location = new System.Drawing.Point(177, 38);
            this.dobOnlyDatePicker.Name = "dobOnlyDatePicker";
            this.dobOnlyDatePicker.Size = new System.Drawing.Size(163, 30);
            this.dobOnlyDatePicker.TabIndex = 18;
            // 
            // searchByDOBOnlyRadioButton
            // 
            this.searchByDOBOnlyRadioButton.AutoSize = true;
            this.searchByDOBOnlyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDOBOnlyRadioButton.Location = new System.Drawing.Point(20, 45);
            this.searchByDOBOnlyRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchByDOBOnlyRadioButton.Name = "searchByDOBOnlyRadioButton";
            this.searchByDOBOnlyRadioButton.Size = new System.Drawing.Size(17, 16);
            this.searchByDOBOnlyRadioButton.TabIndex = 29;
            this.searchByDOBOnlyRadioButton.TabStop = true;
            this.searchByDOBOnlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(177, 93);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(163, 30);
            this.firstNameTextBox.TabIndex = 19;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(177, 127);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(163, 30);
            this.lastNameTextBox.TabIndex = 20;
            // 
            // dobOnlyLabel
            // 
            this.dobOnlyLabel.AutoSize = true;
            this.dobOnlyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobOnlyLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dobOnlyLabel.Location = new System.Drawing.Point(43, 42);
            this.dobOnlyLabel.Name = "dobOnlyLabel";
            this.dobOnlyLabel.Size = new System.Drawing.Size(124, 25);
            this.dobOnlyLabel.TabIndex = 15;
            this.dobOnlyLabel.Text = "Date of Birth:";
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(179, 340);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 35);
            this.clearButton.TabIndex = 46;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(18, 340);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(125, 35);
            this.searchButton.TabIndex = 45;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.searchMessageLabel.Location = new System.Drawing.Point(15, 397);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(184, 31);
            this.searchMessageLabel.TabIndex = 47;
            // 
            // PatientVisitsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchForPatientsGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchMessageLabel);
            this.Controls.Add(this.patientSearchResultDataGridView);
            this.Controls.Add(this.doubleClickOptionToViewPatientLabel);
            this.Controls.Add(this.viewOrEditPatientVisitDetailsButton);
            this.Controls.Add(this.searchForPatientVisitLabel);
            this.Name = "PatientVisitsUserControl";
            this.Size = new System.Drawing.Size(996, 551);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientSearchResultDataGridView)).EndInit();
            this.searchForPatientsGroupBox.ResumeLayout(false);
            this.searchForPatientsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label doubleClickOptionToViewPatientLabel;
        private System.Windows.Forms.Button viewOrEditPatientVisitDetailsButton;
        private System.Windows.Forms.Label searchForPatientVisitLabel;
        private System.Windows.Forms.BindingSource patientVisitsBindingSource;
        private System.Windows.Forms.BindingSource appointmentSearchResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView patientSearchResultDataGridView;
        private System.Windows.Forms.GroupBox searchForPatientsGroupBox;
        private System.Windows.Forms.TextBox lastNameCombinedTextBox;
        private System.Windows.Forms.Label lastNameCombinedLabel;
        private System.Windows.Forms.RadioButton searchByDOBAndLastNameRadioButton;
        private System.Windows.Forms.DateTimePicker dobCombinedDatePicker;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label dobCombinedLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.RadioButton searchByNamesRadioButton;
        private System.Windows.Forms.DateTimePicker dobOnlyDatePicker;
        private System.Windows.Forms.RadioButton searchByDOBOnlyRadioButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label dobOnlyLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchMessageLabel;
    }
}
