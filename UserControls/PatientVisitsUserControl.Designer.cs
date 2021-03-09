
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
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.viewOrEditPatientVisitDetailsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.dobSearchPicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameSearchLabel = new System.Windows.Forms.Label();
            this.dobSearchLabel = new System.Windows.Forms.Label();
            this.searchRulesLabel = new System.Windows.Forms.Label();
            this.searchForPatientVisitLabel = new System.Windows.Forms.Label();
            this.appointmentSearchResultDataGridView = new System.Windows.Forms.DataGridView();
            this.dobLabel = new System.Windows.Forms.Label();
            this.firstAndLastLabel = new System.Windows.Forms.Label();
            this.dobLastName = new System.Windows.Forms.Label();
            this.appointmentSearchResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleClickOptionToViewPatientLabel
            // 
            this.doubleClickOptionToViewPatientLabel.AutoSize = true;
            this.doubleClickOptionToViewPatientLabel.Location = new System.Drawing.Point(310, 538);
            this.doubleClickOptionToViewPatientLabel.Name = "doubleClickOptionToViewPatientLabel";
            this.doubleClickOptionToViewPatientLabel.Size = new System.Drawing.Size(347, 17);
            this.doubleClickOptionToViewPatientLabel.TabIndex = 43;
            this.doubleClickOptionToViewPatientLabel.Text = "Double-click any row to view or edit a patient\'s details.";
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.searchMessageLabel.Location = new System.Drawing.Point(134, 285);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(262, 19);
            this.searchMessageLabel.TabIndex = 42;
            // 
            // viewOrEditPatientVisitDetailsButton
            // 
            this.viewOrEditPatientVisitDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrEditPatientVisitDetailsButton.Location = new System.Drawing.Point(663, 526);
            this.viewOrEditPatientVisitDetailsButton.Name = "viewOrEditPatientVisitDetailsButton";
            this.viewOrEditPatientVisitDetailsButton.Size = new System.Drawing.Size(309, 35);
            this.viewOrEditPatientVisitDetailsButton.TabIndex = 40;
            this.viewOrEditPatientVisitDetailsButton.Text = "View / Edit Patient Visit Details";
            this.viewOrEditPatientVisitDetailsButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(232, 307);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 35);
            this.clearButton.TabIndex = 39;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(137, 307);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 35);
            this.searchButton.TabIndex = 38;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(134, 250);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(185, 30);
            this.lastNameTextBox.TabIndex = 37;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(134, 203);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(185, 30);
            this.firstNameTextBox.TabIndex = 36;
            // 
            // dobSearchPicker
            // 
            this.dobSearchPicker.Checked = false;
            this.dobSearchPicker.CustomFormat = "mm/dd/yyyy";
            this.dobSearchPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobSearchPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobSearchPicker.Location = new System.Drawing.Point(134, 157);
            this.dobSearchPicker.Name = "dobSearchPicker";
            this.dobSearchPicker.ShowCheckBox = true;
            this.dobSearchPicker.Size = new System.Drawing.Size(185, 30);
            this.dobSearchPicker.TabIndex = 35;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(16, 250);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 25);
            this.lastNameLabel.TabIndex = 34;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameSearchLabel
            // 
            this.firstNameSearchLabel.AutoSize = true;
            this.firstNameSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameSearchLabel.Location = new System.Drawing.Point(16, 203);
            this.firstNameSearchLabel.Name = "firstNameSearchLabel";
            this.firstNameSearchLabel.Size = new System.Drawing.Size(112, 25);
            this.firstNameSearchLabel.TabIndex = 33;
            this.firstNameSearchLabel.Text = "First Name:";
            // 
            // dobSearchLabel
            // 
            this.dobSearchLabel.AutoSize = true;
            this.dobSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobSearchLabel.Location = new System.Drawing.Point(67, 157);
            this.dobSearchLabel.Name = "dobSearchLabel";
            this.dobSearchLabel.Size = new System.Drawing.Size(61, 25);
            this.dobSearchLabel.TabIndex = 32;
            this.dobSearchLabel.Text = "DOB:";
            // 
            // searchRulesLabel
            // 
            this.searchRulesLabel.AutoSize = true;
            this.searchRulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRulesLabel.Location = new System.Drawing.Point(15, 50);
            this.searchRulesLabel.Name = "searchRulesLabel";
            this.searchRulesLabel.Size = new System.Drawing.Size(89, 20);
            this.searchRulesLabel.TabIndex = 31;
            this.searchRulesLabel.Text = "Search by:";
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
            // appointmentSearchResultDataGridView
            // 
            this.appointmentSearchResultDataGridView.AllowUserToAddRows = false;
            this.appointmentSearchResultDataGridView.AllowUserToDeleteRows = false;
            this.appointmentSearchResultDataGridView.AutoGenerateColumns = false;
            this.appointmentSearchResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentSearchResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentSearchResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6});
            this.appointmentSearchResultDataGridView.DataSource = this.appointmentSearchResultBindingSource;
            this.appointmentSearchResultDataGridView.Location = new System.Drawing.Point(349, 16);
            this.appointmentSearchResultDataGridView.Name = "appointmentSearchResultDataGridView";
            this.appointmentSearchResultDataGridView.ReadOnly = true;
            this.appointmentSearchResultDataGridView.RowHeadersWidth = 51;
            this.appointmentSearchResultDataGridView.RowTemplate.Height = 24;
            this.appointmentSearchResultDataGridView.Size = new System.Drawing.Size(623, 496);
            this.appointmentSearchResultDataGridView.TabIndex = 44;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(21, 74);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(47, 17);
            this.dobLabel.TabIndex = 45;
            this.dobLabel.Text = "- DOB";
            // 
            // firstAndLastLabel
            // 
            this.firstAndLastLabel.AutoSize = true;
            this.firstAndLastLabel.Location = new System.Drawing.Point(21, 95);
            this.firstAndLastLabel.Name = "firstAndLastLabel";
            this.firstAndLastLabel.Size = new System.Drawing.Size(144, 17);
            this.firstAndLastLabel.TabIndex = 46;
            this.firstAndLastLabel.Text = "- First and Last Name";
            // 
            // dobLastName
            // 
            this.dobLastName.AutoSize = true;
            this.dobLastName.Location = new System.Drawing.Point(21, 116);
            this.dobLastName.Name = "dobLastName";
            this.dobLastName.Size = new System.Drawing.Size(147, 17);
            this.dobLastName.TabIndex = 47;
            this.dobLastName.Text = "- DOB and Last Name";
            // 
            // appointmentSearchResultBindingSource
            // 
            this.appointmentSearchResultBindingSource.DataSource = typeof(SmartClinic.Model.AppointmentSearchResult);
            // 
            // patientVisitsBindingSource
            // 
            this.patientVisitsBindingSource.DataSource = typeof(SmartClinic.Model.PatientVisits);
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PatientFullName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Patient Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DoctorFullName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Doctor";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // PatientVisitsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dobLastName);
            this.Controls.Add(this.firstAndLastLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.appointmentSearchResultDataGridView);
            this.Controls.Add(this.doubleClickOptionToViewPatientLabel);
            this.Controls.Add(this.searchMessageLabel);
            this.Controls.Add(this.viewOrEditPatientVisitDetailsButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.dobSearchPicker);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameSearchLabel);
            this.Controls.Add(this.dobSearchLabel);
            this.Controls.Add(this.searchRulesLabel);
            this.Controls.Add(this.searchForPatientVisitLabel);
            this.Name = "PatientVisitsUserControl";
            this.Size = new System.Drawing.Size(997, 587);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label doubleClickOptionToViewPatientLabel;
        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.Button viewOrEditPatientVisitDetailsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.DateTimePicker dobSearchPicker;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameSearchLabel;
        private System.Windows.Forms.Label dobSearchLabel;
        private System.Windows.Forms.Label searchRulesLabel;
        private System.Windows.Forms.Label searchForPatientVisitLabel;
        private System.Windows.Forms.BindingSource patientVisitsBindingSource;
        private System.Windows.Forms.BindingSource appointmentSearchResultBindingSource;
        private System.Windows.Forms.DataGridView appointmentSearchResultDataGridView;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label firstAndLastLabel;
        private System.Windows.Forms.Label dobLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
