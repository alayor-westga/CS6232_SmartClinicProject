
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
            this.searchForPatientsGroupBox = new System.Windows.Forms.GroupBox();
            this.newPatientButton = new System.Windows.Forms.Button();
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
            this.patientVisitsDataGridView = new System.Windows.Forms.DataGridView();
            this.viewAppointmentButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientVisitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentSearchResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchForPatientsGroupBox.SuspendLayout();
            this.appointmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.searchForPatientsGroupBox.Location = new System.Drawing.Point(18, 19);
            this.searchForPatientsGroupBox.Name = "searchForPatientsGroupBox";
            this.searchForPatientsGroupBox.Size = new System.Drawing.Size(1202, 227);
            this.searchForPatientsGroupBox.TabIndex = 22;
            this.searchForPatientsGroupBox.TabStop = false;
            this.searchForPatientsGroupBox.Text = "Search for a patient";
            // 
            // newPatientButton
            // 
            this.newPatientButton.AutoSize = true;
            this.newPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientButton.Location = new System.Drawing.Point(29, 144);
            this.newPatientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(250, 47);
            this.newPatientButton.TabIndex = 39;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.NewPatientButton_Click);
            // 
            // patientDateOfBirthValueLabel
            // 
            this.patientDateOfBirthValueLabel.AutoSize = true;
            this.patientDateOfBirthValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthValueLabel.Location = new System.Drawing.Point(932, 89);
            this.patientDateOfBirthValueLabel.Name = "patientDateOfBirthValueLabel";
            this.patientDateOfBirthValueLabel.Size = new System.Drawing.Size(27, 37);
            this.patientDateOfBirthValueLabel.TabIndex = 36;
            this.patientDateOfBirthValueLabel.Text = "-";
            // 
            // patientAddressValueLabel
            // 
            this.patientAddressValueLabel.AutoSize = true;
            this.patientAddressValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAddressValueLabel.Location = new System.Drawing.Point(453, 148);
            this.patientAddressValueLabel.Name = "patientAddressValueLabel";
            this.patientAddressValueLabel.Size = new System.Drawing.Size(27, 37);
            this.patientAddressValueLabel.TabIndex = 38;
            this.patientAddressValueLabel.Text = "-";
            // 
            // patientAddressLabel
            // 
            this.patientAddressLabel.AutoSize = true;
            this.patientAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAddressLabel.Location = new System.Drawing.Point(316, 148);
            this.patientAddressLabel.Name = "patientAddressLabel";
            this.patientAddressLabel.Size = new System.Drawing.Size(144, 37);
            this.patientAddressLabel.TabIndex = 37;
            this.patientAddressLabel.Text = "Address:";
            // 
            // patientDateOfBirthLabel
            // 
            this.patientDateOfBirthLabel.AutoSize = true;
            this.patientDateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDateOfBirthLabel.Location = new System.Drawing.Point(734, 89);
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
            this.patientIdLabel.Location = new System.Drawing.Point(316, 34);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(57, 37);
            this.patientIdLabel.TabIndex = 33;
            this.patientIdLabel.Text = "ID:";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLabel.Location = new System.Drawing.Point(316, 89);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(112, 37);
            this.patientNameLabel.TabIndex = 32;
            this.patientNameLabel.Text = "Name:";
            // 
            // patientFullNameValueLabel
            // 
            this.patientFullNameValueLabel.AutoSize = true;
            this.patientFullNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFullNameValueLabel.Location = new System.Drawing.Point(424, 89);
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
            this.searchPatientButton.Location = new System.Drawing.Point(29, 67);
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
            this.appointmentsGroupBox.Controls.Add(this.patientVisitsDataGridView);
            this.appointmentsGroupBox.Controls.Add(this.viewAppointmentButton);
            this.appointmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsGroupBox.Location = new System.Drawing.Point(18, 275);
            this.appointmentsGroupBox.Name = "appointmentsGroupBox";
            this.appointmentsGroupBox.Size = new System.Drawing.Size(1209, 506);
            this.appointmentsGroupBox.TabIndex = 23;
            this.appointmentsGroupBox.TabStop = false;
            this.appointmentsGroupBox.Text = "Patient Visits";
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.AutoSize = true;
            this.searchMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.searchMessageLabel.Location = new System.Drawing.Point(754, 41);
            this.searchMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(0, 31);
            this.searchMessageLabel.TabIndex = 15;
            // 
            // patientVisitsDataGridView
            // 
            this.patientVisitsDataGridView.AllowUserToAddRows = false;
            this.patientVisitsDataGridView.AllowUserToDeleteRows = false;
            this.patientVisitsDataGridView.AutoGenerateColumns = false;
            this.patientVisitsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientVisitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientVisitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6});
            this.patientVisitsDataGridView.DataSource = this.patientVisitsBindingSource;
            this.patientVisitsDataGridView.Location = new System.Drawing.Point(20, 53);
            this.patientVisitsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientVisitsDataGridView.Name = "patientVisitsDataGridView";
            this.patientVisitsDataGridView.ReadOnly = true;
            this.patientVisitsDataGridView.RowHeadersWidth = 51;
            this.patientVisitsDataGridView.RowTemplate.Height = 24;
            this.patientVisitsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientVisitsDataGridView.Size = new System.Drawing.Size(1148, 322);
            this.patientVisitsDataGridView.TabIndex = 14;
            this.patientVisitsDataGridView.SelectionChanged += new System.EventHandler(this.AppointmentsDataGridView_SelectionChanged);
            this.patientVisitsDataGridView.DoubleClick += new System.EventHandler(this.AppointmentsDataGridView_DoubleClick);
            // 
            // viewAppointmentButton
            // 
            this.viewAppointmentButton.AutoSize = true;
            this.viewAppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAppointmentButton.Enabled = false;
            this.viewAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAppointmentButton.Location = new System.Drawing.Point(901, 418);
            this.viewAppointmentButton.Name = "viewAppointmentButton";
            this.viewAppointmentButton.Size = new System.Drawing.Size(250, 47);
            this.viewAppointmentButton.TabIndex = 14;
            this.viewAppointmentButton.Text = "View / Edit";
            this.viewAppointmentButton.UseVisualStyleBackColor = true;
            this.viewAppointmentButton.Click += new System.EventHandler(this.ViewAppointmentButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AppointmentID";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "AppointmentID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "VisitDate";
            this.dataGridViewTextBoxColumn8.FillWeight = 65F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Visit Date / Time";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Doctor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Doctor";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nurse";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nurse";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // patientVisitsBindingSource
            // 
            this.patientVisitsBindingSource.DataSource = typeof(SmartClinic.Model.PatientVisits);
            // 
            // appointmentSearchResultBindingSource
            // 
            this.appointmentSearchResultBindingSource.DataSource = typeof(SmartClinic.Model.AppointmentSearchResult);
            // 
            // PatientVisitsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchForPatientsGroupBox);
            this.Controls.Add(this.appointmentsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PatientVisitsUserControl";
            this.Size = new System.Drawing.Size(1236, 795);
            this.searchForPatientsGroupBox.ResumeLayout(false);
            this.searchForPatientsGroupBox.PerformLayout();
            this.appointmentsGroupBox.ResumeLayout(false);
            this.appointmentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource patientVisitsBindingSource;
        private System.Windows.Forms.BindingSource appointmentSearchResultBindingSource;
        private System.Windows.Forms.GroupBox searchForPatientsGroupBox;
        private System.Windows.Forms.Button newPatientButton;
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
        private System.Windows.Forms.Button viewAppointmentButton;
        private System.Windows.Forms.DataGridView patientVisitsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label searchMessageLabel;
    }
}
