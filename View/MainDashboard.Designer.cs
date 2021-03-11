
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
            this.userLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.PatientsTabPage = new System.Windows.Forms.TabPage();
            this.searchPatientsUserControl1 = new SmartClinic.UserControls.SearchPatientsUserControl();
            this.patientVisitsTabPage = new System.Windows.Forms.TabPage();
            this.patientVisitsUserControl1 = new SmartClinic.UserControls.PatientVisitsUserControl();
            this.appointmentsTabPage = new System.Windows.Forms.TabPage();
            this.appointmentsUserControl1 = new SmartClinic.UserControls.AppointmentsUserControl();
            this.mainDashBoardTabControl = new System.Windows.Forms.TabControl();
            this.newAppoinmentTabPage = new System.Windows.Forms.TabPage();
            this.newAppointmentUserControl1 = new SmartClinic.UserControls.NewAppointmentUserControl();
            this.userLayoutPanel.SuspendLayout();
            this.PatientsTabPage.SuspendLayout();
            this.patientVisitsTabPage.SuspendLayout();
            this.appointmentsTabPage.SuspendLayout();
            this.mainDashBoardTabControl.SuspendLayout();
            this.newAppoinmentTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLayoutPanel
            // 
            this.userLayoutPanel.ColumnCount = 3;
            this.userLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.59447F));
            this.userLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.40553F));
            this.userLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
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
            this.userNameLabel.Location = new System.Drawing.Point(1109, 6);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 31);
            this.userNameLabel.TabIndex = 1;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(1366, 6);
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
            this.welcomeLabel.Location = new System.Drawing.Point(977, 6);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(126, 31);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome";
            // 
            // newPatientButton
            // 
            this.newPatientButton.AutoSize = true;
            this.newPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientButton.Location = new System.Drawing.Point(32, 68);
            this.newPatientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(286, 55);
            this.newPatientButton.TabIndex = 3;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.NewPatientButton_Click);
            // 
            // PatientsTabPage
            // 
            this.PatientsTabPage.Controls.Add(this.searchPatientsUserControl1);
            this.PatientsTabPage.Location = new System.Drawing.Point(8, 39);
            this.PatientsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientsTabPage.Name = "PatientsTabPage";
            this.PatientsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatientsTabPage.Size = new System.Drawing.Size(1490, 859);
            this.PatientsTabPage.TabIndex = 2;
            this.PatientsTabPage.Text = "Patients";
            this.PatientsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchPatientsUserControl1
            // 
            this.searchPatientsUserControl1.Location = new System.Drawing.Point(26, 61);
            this.searchPatientsUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.searchPatientsUserControl1.Name = "searchPatientsUserControl1";
            this.searchPatientsUserControl1.Size = new System.Drawing.Size(1172, 756);
            this.searchPatientsUserControl1.TabIndex = 0;
            // 
            // patientVisitsTabPage
            // 
            this.patientVisitsTabPage.Controls.Add(this.patientVisitsUserControl1);
            this.patientVisitsTabPage.Location = new System.Drawing.Point(8, 39);
            this.patientVisitsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientVisitsTabPage.Name = "patientVisitsTabPage";
            this.patientVisitsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientVisitsTabPage.Size = new System.Drawing.Size(1490, 859);
            this.patientVisitsTabPage.TabIndex = 1;
            this.patientVisitsTabPage.Text = "Patient Visits";
            this.patientVisitsTabPage.UseVisualStyleBackColor = true;
            // 
            // patientVisitsUserControl1
            // 
            this.patientVisitsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.patientVisitsUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.patientVisitsUserControl1.Name = "patientVisitsUserControl1";
            this.patientVisitsUserControl1.Size = new System.Drawing.Size(1494, 861);
            this.patientVisitsUserControl1.TabIndex = 0;
            // 
            // appointmentsTabPage
            // 
            this.appointmentsTabPage.Controls.Add(this.appointmentsUserControl1);
            this.appointmentsTabPage.Location = new System.Drawing.Point(8, 39);
            this.appointmentsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appointmentsTabPage.Name = "appointmentsTabPage";
            this.appointmentsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appointmentsTabPage.Size = new System.Drawing.Size(1490, 859);
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
            this.appointmentsUserControl1.Size = new System.Drawing.Size(1482, 849);
            this.appointmentsUserControl1.TabIndex = 0;
            // 
            // mainDashBoardTabControl
            // 
            this.mainDashBoardTabControl.Controls.Add(this.newAppoinmentTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.appointmentsTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.patientVisitsTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.PatientsTabPage);
            this.mainDashBoardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainDashBoardTabControl.Location = new System.Drawing.Point(0, 149);
            this.mainDashBoardTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainDashBoardTabControl.Name = "mainDashBoardTabControl";
            this.mainDashBoardTabControl.SelectedIndex = 0;
            this.mainDashBoardTabControl.Size = new System.Drawing.Size(1506, 906);
            this.mainDashBoardTabControl.TabIndex = 2;
            // 
            // newAppoinmentTabPage
            // 
            this.newAppoinmentTabPage.Controls.Add(this.newAppointmentUserControl1);
            this.newAppoinmentTabPage.Location = new System.Drawing.Point(8, 39);
            this.newAppoinmentTabPage.Name = "newAppoinmentTabPage";
            this.newAppoinmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.newAppoinmentTabPage.Size = new System.Drawing.Size(1490, 859);
            this.newAppoinmentTabPage.TabIndex = 3;
            this.newAppoinmentTabPage.Text = "New Appointment";
            this.newAppoinmentTabPage.UseVisualStyleBackColor = true;
            // 
            // newAppointmentUserControl1
            // 
            this.newAppointmentUserControl1.Location = new System.Drawing.Point(24, 34);
            this.newAppointmentUserControl1.Name = "newAppointmentUserControl1";
            this.newAppointmentUserControl1.Size = new System.Drawing.Size(1210, 646);
            this.newAppointmentUserControl1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 1055);
            this.Controls.Add(this.newPatientButton);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel userLayoutPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.TabPage PatientsTabPage;
        private System.Windows.Forms.TabPage patientVisitsTabPage;
        private System.Windows.Forms.TabPage appointmentsTabPage;
        private System.Windows.Forms.TabControl mainDashBoardTabControl;
        private UserControls.AppointmentsUserControl appointmentsUserControl1;
        private UserControls.SearchPatientsUserControl searchPatientsUserControl1;
        private UserControls.PatientVisitsUserControl patientVisitsUserControl1;
        private System.Windows.Forms.TabPage newAppoinmentTabPage;
        private UserControls.NewAppointmentUserControl newAppointmentUserControl1;
    }
}