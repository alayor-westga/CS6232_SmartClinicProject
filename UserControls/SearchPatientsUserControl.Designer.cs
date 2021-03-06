﻿
namespace SmartClinic.UserControls
{
    partial class SearchPatientsUserControl
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
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editPatientButton = new System.Windows.Forms.Button();
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.patientsGroupBox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchForPatientsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.patientsGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.searchForPatientsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.searchForPatientsGroupBox.Name = "searchForPatientsGroupBox";
            this.searchForPatientsGroupBox.Size = new System.Drawing.Size(559, 410);
            this.searchForPatientsGroupBox.TabIndex = 37;
            this.searchForPatientsGroupBox.TabStop = false;
            this.searchForPatientsGroupBox.Text = "Select a search option";
            // 
            // lastNameCombinedTextBox
            // 
            this.lastNameCombinedTextBox.Enabled = false;
            this.lastNameCombinedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameCombinedTextBox.Location = new System.Drawing.Point(266, 344);
            this.lastNameCombinedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameCombinedTextBox.Name = "lastNameCombinedTextBox";
            this.lastNameCombinedTextBox.Size = new System.Drawing.Size(243, 44);
            this.lastNameCombinedTextBox.TabIndex = 35;
            // 
            // lastNameCombinedLabel
            // 
            this.lastNameCombinedLabel.AutoSize = true;
            this.lastNameCombinedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameCombinedLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lastNameCombinedLabel.Location = new System.Drawing.Point(64, 347);
            this.lastNameCombinedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameCombinedLabel.Name = "lastNameCombinedLabel";
            this.lastNameCombinedLabel.Size = new System.Drawing.Size(182, 37);
            this.lastNameCombinedLabel.TabIndex = 34;
            this.lastNameCombinedLabel.Text = "Last Name:";
            this.lastNameCombinedLabel.Click += new System.EventHandler(this.LastNameCombinedLabel_Click);
            // 
            // searchByDOBAndLastNameRadioButton
            // 
            this.searchByDOBAndLastNameRadioButton.AutoSize = true;
            this.searchByDOBAndLastNameRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDOBAndLastNameRadioButton.Location = new System.Drawing.Point(30, 319);
            this.searchByDOBAndLastNameRadioButton.Name = "searchByDOBAndLastNameRadioButton";
            this.searchByDOBAndLastNameRadioButton.Size = new System.Drawing.Size(27, 26);
            this.searchByDOBAndLastNameRadioButton.TabIndex = 33;
            this.searchByDOBAndLastNameRadioButton.TabStop = true;
            this.searchByDOBAndLastNameRadioButton.UseVisualStyleBackColor = true;
            this.searchByDOBAndLastNameRadioButton.CheckedChanged += new System.EventHandler(this.SearchByDOBAndLastNameRadioButton_CheckedChanged);
            // 
            // dobCombinedDatePicker
            // 
            this.dobCombinedDatePicker.CustomFormat = "mm/dd/yyyy";
            this.dobCombinedDatePicker.Enabled = false;
            this.dobCombinedDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobCombinedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobCombinedDatePicker.Location = new System.Drawing.Point(266, 290);
            this.dobCombinedDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dobCombinedDatePicker.Name = "dobCombinedDatePicker";
            this.dobCombinedDatePicker.Size = new System.Drawing.Size(243, 44);
            this.dobCombinedDatePicker.TabIndex = 32;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.firstNameLabel.Location = new System.Drawing.Point(64, 148);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(184, 37);
            this.firstNameLabel.TabIndex = 16;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
            // 
            // dobCombinedLabel
            // 
            this.dobCombinedLabel.AutoSize = true;
            this.dobCombinedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobCombinedLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dobCombinedLabel.Location = new System.Drawing.Point(64, 290);
            this.dobCombinedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobCombinedLabel.Name = "dobCombinedLabel";
            this.dobCombinedLabel.Size = new System.Drawing.Size(204, 37);
            this.dobCombinedLabel.TabIndex = 31;
            this.dobCombinedLabel.Text = "Date of Birth:";
            this.dobCombinedLabel.Click += new System.EventHandler(this.DobCombinedLabel_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lastNameLabel.Location = new System.Drawing.Point(64, 201);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(182, 37);
            this.lastNameLabel.TabIndex = 17;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.Click += new System.EventHandler(this.LastNameLabel_Click);
            // 
            // searchByNamesRadioButton
            // 
            this.searchByNamesRadioButton.AutoSize = true;
            this.searchByNamesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByNamesRadioButton.Location = new System.Drawing.Point(30, 172);
            this.searchByNamesRadioButton.Name = "searchByNamesRadioButton";
            this.searchByNamesRadioButton.Size = new System.Drawing.Size(27, 26);
            this.searchByNamesRadioButton.TabIndex = 30;
            this.searchByNamesRadioButton.TabStop = true;
            this.searchByNamesRadioButton.UseVisualStyleBackColor = true;
            this.searchByNamesRadioButton.CheckedChanged += new System.EventHandler(this.SearchByNamesRadioButton_CheckedChanged);
            // 
            // dobOnlyDatePicker
            // 
            this.dobOnlyDatePicker.CustomFormat = "mm/dd/yyyy";
            this.dobOnlyDatePicker.Enabled = false;
            this.dobOnlyDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobOnlyDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobOnlyDatePicker.Location = new System.Drawing.Point(266, 59);
            this.dobOnlyDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dobOnlyDatePicker.Name = "dobOnlyDatePicker";
            this.dobOnlyDatePicker.Size = new System.Drawing.Size(243, 44);
            this.dobOnlyDatePicker.TabIndex = 18;
            // 
            // searchByDOBOnlyRadioButton
            // 
            this.searchByDOBOnlyRadioButton.AutoSize = true;
            this.searchByDOBOnlyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByDOBOnlyRadioButton.Location = new System.Drawing.Point(30, 70);
            this.searchByDOBOnlyRadioButton.Name = "searchByDOBOnlyRadioButton";
            this.searchByDOBOnlyRadioButton.Size = new System.Drawing.Size(27, 26);
            this.searchByDOBOnlyRadioButton.TabIndex = 29;
            this.searchByDOBOnlyRadioButton.TabStop = true;
            this.searchByDOBOnlyRadioButton.UseVisualStyleBackColor = true;
            this.searchByDOBOnlyRadioButton.CheckedChanged += new System.EventHandler(this.SearchByDOBOnlyRadioButton_CheckedChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(266, 145);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(243, 44);
            this.firstNameTextBox.TabIndex = 19;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(266, 199);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(243, 44);
            this.lastNameTextBox.TabIndex = 20;
            // 
            // dobOnlyLabel
            // 
            this.dobOnlyLabel.AutoSize = true;
            this.dobOnlyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobOnlyLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dobOnlyLabel.Location = new System.Drawing.Point(64, 65);
            this.dobOnlyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobOnlyLabel.Name = "dobOnlyLabel";
            this.dobOnlyLabel.Size = new System.Drawing.Size(204, 37);
            this.dobOnlyLabel.TabIndex = 15;
            this.dobOnlyLabel.Text = "Date of Birth:";
            this.dobOnlyLabel.Click += new System.EventHandler(this.DobOnlyLabel_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(817, 186);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(188, 55);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(597, 186);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(188, 55);
            this.searchButton.TabIndex = 21;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.AllowUserToAddRows = false;
            this.patientsDataGridView.AllowUserToDeleteRows = false;
            this.patientsDataGridView.AutoGenerateColumns = false;
            this.patientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.patientsDataGridView.DataSource = this.patientBindingSource;
            this.patientsDataGridView.Location = new System.Drawing.Point(6, 42);
            this.patientsDataGridView.MultiSelect = false;
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.ReadOnly = true;
            this.patientsDataGridView.RowHeadersWidth = 82;
            this.patientsDataGridView.RowTemplate.Height = 33;
            this.patientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientsDataGridView.Size = new System.Drawing.Size(1332, 238);
            this.patientsDataGridView.TabIndex = 38;
            this.patientsDataGridView.SelectionChanged += new System.EventHandler(this.PatientsDataGridView_SelectionChanged);
            this.patientsDataGridView.DoubleClick += new System.EventHandler(this.PatientsDataGridView_DoubleClick);
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(SmartClinic.Model.Patient);
            // 
            // editPatientButton
            // 
            this.editPatientButton.AutoSize = true;
            this.editPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPatientButton.Enabled = false;
            this.editPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPatientButton.Location = new System.Drawing.Point(1082, 721);
            this.editPatientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(268, 47);
            this.editPatientButton.TabIndex = 41;
            this.editPatientButton.Text = "View/Edit";
            this.editPatientButton.UseVisualStyleBackColor = true;
            this.editPatientButton.Visible = false;
            this.editPatientButton.Click += new System.EventHandler(this.EditPatientButton_Click);
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.searchMessageLabel.Location = new System.Drawing.Point(884, 385);
            this.searchMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(276, 49);
            this.searchMessageLabel.TabIndex = 25;
            // 
            // patientsGroupBox
            // 
            this.patientsGroupBox.Controls.Add(this.patientsDataGridView);
            this.patientsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsGroupBox.Location = new System.Drawing.Point(12, 419);
            this.patientsGroupBox.Name = "patientsGroupBox";
            this.patientsGroupBox.Size = new System.Drawing.Size(1348, 294);
            this.patientsGroupBox.TabIndex = 43;
            this.patientsGroupBox.TabStop = false;
            this.patientsGroupBox.Text = "Patients";
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.FillWeight = 51.28205F;
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.patientIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            this.patientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.FillWeight = 93.62367F;
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.FillWeight = 62.45741F;
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.FillWeight = 192.6368F;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SearchPatientsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editPatientButton);
            this.Controls.Add(this.searchForPatientsGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchMessageLabel);
            this.Controls.Add(this.patientsGroupBox);
            this.Name = "SearchPatientsUserControl";
            this.Size = new System.Drawing.Size(1378, 782);
            this.Load += new System.EventHandler(this.SearchPatientsUserControl_Load);
            this.searchForPatientsGroupBox.ResumeLayout(false);
            this.searchForPatientsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.patientsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.Button editPatientButton;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.GroupBox patientsGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}
