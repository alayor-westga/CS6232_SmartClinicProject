
namespace SmartClinic.View
{
    partial class MainDashboard
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
            this.userLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.PatientsTabPage = new System.Windows.Forms.TabPage();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.searchPatientsUserControl1 = new SmartClinic.UserControls.SearchPatientsUserControl();
            this.patientVisitsTabPage = new System.Windows.Forms.TabPage();
            this.patientVisitsUserControl1 = new SmartClinic.UserControls.PatientVisitsUserControl();
            this.appointmentsTabPage = new System.Windows.Forms.TabPage();
            this.appointmentsUserControl1 = new SmartClinic.UserControls.AppointmentsUserControl();
            this.mainDashBoardTabControl = new System.Windows.Forms.TabControl();
            this.newAppoinmentTabPage = new System.Windows.Forms.TabPage();
            this.newAppointmentUserControl1 = new SmartClinic.UserControls.NewAppointmentUserControl();
            this.nursesTabPage = new System.Windows.Forms.TabPage();
            this.nursesUserControl1 = new SmartClinic.UserControls.NursesUserControl();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mostPerformedTestDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTestCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTestNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allTestsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testCountPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normalResultsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abnormalResultsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsOn18To29PercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsOn30To39PercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsNotOn18To39PercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.userLayoutPanel.SuspendLayout();
            this.PatientsTabPage.SuspendLayout();
            this.patientVisitsTabPage.SuspendLayout();
            this.appointmentsTabPage.SuspendLayout();
            this.mainDashBoardTabControl.SuspendLayout();
            this.newAppoinmentTabPage.SuspendLayout();
            this.nursesTabPage.SuspendLayout();
            this.reportTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostPerformedTestDuringDatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userLayoutPanel
            // 
            this.userLayoutPanel.ColumnCount = 3;
            this.userLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.85758F));
            this.userLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.14242F));
            this.userLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.userLayoutPanel.Controls.Add(this.userNameLabel, 1, 0);
            this.userLayoutPanel.Controls.Add(this.logoutLinkLabel, 2, 0);
            this.userLayoutPanel.Controls.Add(this.welcomeLabel, 0, 0);
            this.userLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.userLayoutPanel.Name = "userLayoutPanel";
            this.userLayoutPanel.RowCount = 1;
            this.userLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userLayoutPanel.Size = new System.Drawing.Size(1506, 44);
            this.userLayoutPanel.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(1059, 6);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 31);
            this.userNameLabel.TabIndex = 1;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(1357, 6);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(97, 31);
            this.logoutLinkLabel.TabIndex = 3;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(927, 6);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(126, 31);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome";
            // 
            // PatientsTabPage
            // 
            this.PatientsTabPage.Controls.Add(this.newPatientButton);
            this.PatientsTabPage.Controls.Add(this.searchPatientsUserControl1);
            this.PatientsTabPage.Location = new System.Drawing.Point(8, 39);
            this.PatientsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientsTabPage.Name = "PatientsTabPage";
            this.PatientsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientsTabPage.Size = new System.Drawing.Size(1490, 964);
            this.PatientsTabPage.TabIndex = 2;
            this.PatientsTabPage.Text = "Patients";
            this.PatientsTabPage.UseVisualStyleBackColor = true;
            // 
            // newPatientButton
            // 
            this.newPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientButton.Location = new System.Drawing.Point(30, 34);
            this.newPatientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(250, 47);
            this.newPatientButton.TabIndex = 1;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.NewPatientButton_Click);
            // 
            // searchPatientsUserControl1
            // 
            this.searchPatientsUserControl1.Location = new System.Drawing.Point(30, 123);
            this.searchPatientsUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.searchPatientsUserControl1.Name = "searchPatientsUserControl1";
            this.searchPatientsUserControl1.Size = new System.Drawing.Size(1444, 800);
            this.searchPatientsUserControl1.TabIndex = 0;
            // 
            // patientVisitsTabPage
            // 
            this.patientVisitsTabPage.Controls.Add(this.patientVisitsUserControl1);
            this.patientVisitsTabPage.Location = new System.Drawing.Point(8, 39);
            this.patientVisitsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientVisitsTabPage.Name = "patientVisitsTabPage";
            this.patientVisitsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientVisitsTabPage.Size = new System.Drawing.Size(1490, 964);
            this.patientVisitsTabPage.TabIndex = 1;
            this.patientVisitsTabPage.Text = "Patient Visits";
            this.patientVisitsTabPage.UseVisualStyleBackColor = true;
            // 
            // patientVisitsUserControl1
            // 
            this.patientVisitsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.patientVisitsUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.patientVisitsUserControl1.Name = "patientVisitsUserControl1";
            this.patientVisitsUserControl1.Size = new System.Drawing.Size(1236, 791);
            this.patientVisitsUserControl1.TabIndex = 0;
            // 
            // appointmentsTabPage
            // 
            this.appointmentsTabPage.Controls.Add(this.appointmentsUserControl1);
            this.appointmentsTabPage.Location = new System.Drawing.Point(8, 39);
            this.appointmentsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appointmentsTabPage.Name = "appointmentsTabPage";
            this.appointmentsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appointmentsTabPage.Size = new System.Drawing.Size(1490, 964);
            this.appointmentsTabPage.TabIndex = 0;
            this.appointmentsTabPage.Text = "Appointments";
            this.appointmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // appointmentsUserControl1
            // 
            this.appointmentsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentsUserControl1.Location = new System.Drawing.Point(4, 5);
            this.appointmentsUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.appointmentsUserControl1.Name = "appointmentsUserControl1";
            this.appointmentsUserControl1.Size = new System.Drawing.Size(1482, 954);
            this.appointmentsUserControl1.TabIndex = 0;
            // 
            // mainDashBoardTabControl
            // 
            this.mainDashBoardTabControl.Controls.Add(this.newAppoinmentTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.appointmentsTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.patientVisitsTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.PatientsTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.nursesTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.reportTabPage);
            this.mainDashBoardTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDashBoardTabControl.Location = new System.Drawing.Point(0, 44);
            this.mainDashBoardTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainDashBoardTabControl.Name = "mainDashBoardTabControl";
            this.mainDashBoardTabControl.SelectedIndex = 0;
            this.mainDashBoardTabControl.Size = new System.Drawing.Size(1506, 1011);
            this.mainDashBoardTabControl.TabIndex = 2;
            this.mainDashBoardTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.MainDashBoardTabControl_Selected);
            // 
            // newAppoinmentTabPage
            // 
            this.newAppoinmentTabPage.Controls.Add(this.newAppointmentUserControl1);
            this.newAppoinmentTabPage.Location = new System.Drawing.Point(8, 39);
            this.newAppoinmentTabPage.Name = "newAppoinmentTabPage";
            this.newAppoinmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.newAppoinmentTabPage.Size = new System.Drawing.Size(1490, 964);
            this.newAppoinmentTabPage.TabIndex = 3;
            this.newAppoinmentTabPage.Text = "New Appointment";
            this.newAppoinmentTabPage.UseVisualStyleBackColor = true;
            // 
            // newAppointmentUserControl1
            // 
            this.newAppointmentUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newAppointmentUserControl1.Location = new System.Drawing.Point(3, 3);
            this.newAppointmentUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.newAppointmentUserControl1.Name = "newAppointmentUserControl1";
            this.newAppointmentUserControl1.Size = new System.Drawing.Size(1484, 958);
            this.newAppointmentUserControl1.TabIndex = 0;
            // 
            // nursesTabPage
            // 
            this.nursesTabPage.Controls.Add(this.nursesUserControl1);
            this.nursesTabPage.Location = new System.Drawing.Point(8, 39);
            this.nursesTabPage.Name = "nursesTabPage";
            this.nursesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.nursesTabPage.Size = new System.Drawing.Size(1490, 964);
            this.nursesTabPage.TabIndex = 4;
            this.nursesTabPage.Text = "Nurses";
            this.nursesTabPage.UseVisualStyleBackColor = true;
            // 
            // nursesUserControl1
            // 
            this.nursesUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nursesUserControl1.Location = new System.Drawing.Point(3, 3);
            this.nursesUserControl1.Name = "nursesUserControl1";
            this.nursesUserControl1.Size = new System.Drawing.Size(1484, 958);
            this.nursesUserControl1.TabIndex = 0;
            // 
            // reportTabPage
            // 
            this.reportTabPage.Controls.Add(this.button1);
            this.reportTabPage.Controls.Add(this.label3);
            this.reportTabPage.Controls.Add(this.label2);
            this.reportTabPage.Controls.Add(this.endDate);
            this.reportTabPage.Controls.Add(this.startDate);
            this.reportTabPage.Controls.Add(this.label1);
            this.reportTabPage.Controls.Add(this.reportDataGridView);
            this.reportTabPage.Location = new System.Drawing.Point(8, 39);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportTabPage.Size = new System.Drawing.Size(1490, 964);
            this.reportTabPage.TabIndex = 5;
            this.reportTabPage.Text = "Report";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AutoGenerateColumns = false;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labTestCodeDataGridViewTextBoxColumn,
            this.labTestNameDataGridViewTextBoxColumn,
            this.testsCountDataGridViewTextBoxColumn,
            this.allTestsCountDataGridViewTextBoxColumn,
            this.testCountPercentageDataGridViewTextBoxColumn,
            this.normalResultsCountDataGridViewTextBoxColumn,
            this.abnormalResultsCountDataGridViewTextBoxColumn,
            this.testsOn18To29PercentDataGridViewTextBoxColumn,
            this.testsOn30To39PercentDataGridViewTextBoxColumn,
            this.testsNotOn18To39PercentDataGridViewTextBoxColumn});
            this.reportDataGridView.DataSource = this.mostPerformedTestDuringDatesBindingSource;
            this.reportDataGridView.Location = new System.Drawing.Point(19, 167);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.RowHeadersWidth = 82;
            this.reportDataGridView.RowTemplate.Height = 33;
            this.reportDataGridView.Size = new System.Drawing.Size(1465, 334);
            this.reportDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(252, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1048, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "This Tab is just for testing. Delete me and create the report";
            // 
            // mostPerformedTestDuringDatesBindingSource
            // 
            this.mostPerformedTestDuringDatesBindingSource.DataSource = typeof(SmartClinic.Model.MostPerformedTestDuringDates);
            // 
            // labTestCodeDataGridViewTextBoxColumn
            // 
            this.labTestCodeDataGridViewTextBoxColumn.DataPropertyName = "LabTestCode";
            this.labTestCodeDataGridViewTextBoxColumn.HeaderText = "LabTestCode";
            this.labTestCodeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.labTestCodeDataGridViewTextBoxColumn.Name = "labTestCodeDataGridViewTextBoxColumn";
            this.labTestCodeDataGridViewTextBoxColumn.Width = 200;
            // 
            // labTestNameDataGridViewTextBoxColumn
            // 
            this.labTestNameDataGridViewTextBoxColumn.DataPropertyName = "LabTestName";
            this.labTestNameDataGridViewTextBoxColumn.HeaderText = "LabTestName";
            this.labTestNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.labTestNameDataGridViewTextBoxColumn.Name = "labTestNameDataGridViewTextBoxColumn";
            this.labTestNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // testsCountDataGridViewTextBoxColumn
            // 
            this.testsCountDataGridViewTextBoxColumn.DataPropertyName = "TestsCount";
            this.testsCountDataGridViewTextBoxColumn.HeaderText = "TestsCount";
            this.testsCountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.testsCountDataGridViewTextBoxColumn.Name = "testsCountDataGridViewTextBoxColumn";
            this.testsCountDataGridViewTextBoxColumn.Width = 200;
            // 
            // allTestsCountDataGridViewTextBoxColumn
            // 
            this.allTestsCountDataGridViewTextBoxColumn.DataPropertyName = "AllTestsCount";
            this.allTestsCountDataGridViewTextBoxColumn.HeaderText = "AllTestsCount";
            this.allTestsCountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.allTestsCountDataGridViewTextBoxColumn.Name = "allTestsCountDataGridViewTextBoxColumn";
            this.allTestsCountDataGridViewTextBoxColumn.Width = 200;
            // 
            // testCountPercentageDataGridViewTextBoxColumn
            // 
            this.testCountPercentageDataGridViewTextBoxColumn.DataPropertyName = "TestCountPercentage";
            this.testCountPercentageDataGridViewTextBoxColumn.HeaderText = "TestCountPercentage";
            this.testCountPercentageDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.testCountPercentageDataGridViewTextBoxColumn.Name = "testCountPercentageDataGridViewTextBoxColumn";
            this.testCountPercentageDataGridViewTextBoxColumn.Width = 200;
            // 
            // normalResultsCountDataGridViewTextBoxColumn
            // 
            this.normalResultsCountDataGridViewTextBoxColumn.DataPropertyName = "NormalResultsCount";
            this.normalResultsCountDataGridViewTextBoxColumn.HeaderText = "NormalResultsCount";
            this.normalResultsCountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.normalResultsCountDataGridViewTextBoxColumn.Name = "normalResultsCountDataGridViewTextBoxColumn";
            this.normalResultsCountDataGridViewTextBoxColumn.Width = 200;
            // 
            // abnormalResultsCountDataGridViewTextBoxColumn
            // 
            this.abnormalResultsCountDataGridViewTextBoxColumn.DataPropertyName = "AbnormalResultsCount";
            this.abnormalResultsCountDataGridViewTextBoxColumn.HeaderText = "AbnormalResultsCount";
            this.abnormalResultsCountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.abnormalResultsCountDataGridViewTextBoxColumn.Name = "abnormalResultsCountDataGridViewTextBoxColumn";
            this.abnormalResultsCountDataGridViewTextBoxColumn.Width = 200;
            // 
            // testsOn18To29PercentDataGridViewTextBoxColumn
            // 
            this.testsOn18To29PercentDataGridViewTextBoxColumn.DataPropertyName = "TestsOn18To29Percent";
            this.testsOn18To29PercentDataGridViewTextBoxColumn.HeaderText = "TestsOn18To29Percent";
            this.testsOn18To29PercentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.testsOn18To29PercentDataGridViewTextBoxColumn.Name = "testsOn18To29PercentDataGridViewTextBoxColumn";
            this.testsOn18To29PercentDataGridViewTextBoxColumn.Width = 200;
            // 
            // testsOn30To39PercentDataGridViewTextBoxColumn
            // 
            this.testsOn30To39PercentDataGridViewTextBoxColumn.DataPropertyName = "TestsOn30To39Percent";
            this.testsOn30To39PercentDataGridViewTextBoxColumn.HeaderText = "TestsOn30To39Percent";
            this.testsOn30To39PercentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.testsOn30To39PercentDataGridViewTextBoxColumn.Name = "testsOn30To39PercentDataGridViewTextBoxColumn";
            this.testsOn30To39PercentDataGridViewTextBoxColumn.Width = 200;
            // 
            // testsNotOn18To39PercentDataGridViewTextBoxColumn
            // 
            this.testsNotOn18To39PercentDataGridViewTextBoxColumn.DataPropertyName = "TestsNotOn18To39Percent";
            this.testsNotOn18To39PercentDataGridViewTextBoxColumn.HeaderText = "TestsNotOn18To39Percent";
            this.testsNotOn18To39PercentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.testsNotOn18To39PercentDataGridViewTextBoxColumn.Name = "testsNotOn18To39PercentDataGridViewTextBoxColumn";
            this.testsNotOn18To39PercentDataGridViewTextBoxColumn.Width = 200;
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(148, 95);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 31);
            this.startDate.TabIndex = 2;
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(495, 95);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 31);
            this.endDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "startDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "endDate";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "GetReport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 1055);
            this.Controls.Add(this.mainDashBoardTabControl);
            this.Controls.Add(this.userLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "smartClinic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboard_FormClosed);
            this.userLayoutPanel.ResumeLayout(false);
            this.userLayoutPanel.PerformLayout();
            this.PatientsTabPage.ResumeLayout(false);
            this.patientVisitsTabPage.ResumeLayout(false);
            this.appointmentsTabPage.ResumeLayout(false);
            this.mainDashBoardTabControl.ResumeLayout(false);
            this.newAppoinmentTabPage.ResumeLayout(false);
            this.nursesTabPage.ResumeLayout(false);
            this.reportTabPage.ResumeLayout(false);
            this.reportTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostPerformedTestDuringDatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel userLayoutPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabPage PatientsTabPage;
        private System.Windows.Forms.TabPage patientVisitsTabPage;
        private System.Windows.Forms.TabPage appointmentsTabPage;
        private System.Windows.Forms.TabControl mainDashBoardTabControl;
        private UserControls.AppointmentsUserControl appointmentsUserControl1;
        private UserControls.SearchPatientsUserControl searchPatientsUserControl1;
        private System.Windows.Forms.TabPage newAppoinmentTabPage;
        private UserControls.NewAppointmentUserControl newAppointmentUserControl1;
        private UserControls.PatientVisitsUserControl patientVisitsUserControl1;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.TabPage nursesTabPage;
        private UserControls.NursesUserControl nursesUserControl1;
        private System.Windows.Forms.TabPage reportTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn labTestCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labTestNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allTestsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testCountPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normalResultsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abnormalResultsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testsOn18To29PercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testsOn30To39PercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testsNotOn18To39PercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mostPerformedTestDuringDatesBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
    }
}