
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
            this.newAppointmentButton = new System.Windows.Forms.Button();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.PatientsTabPage = new System.Windows.Forms.TabPage();
            this.searchForIncidentsLabel = new System.Windows.Forms.Label();
            this.patientsUserControls1 = new SmartClinic.UserControls.PatientsUserControls();
            this.patientVisitsTabPage = new System.Windows.Forms.TabPage();
            this.appointmentsTabPage = new System.Windows.Forms.TabPage();
            this.mainDashBoardTabControl = new System.Windows.Forms.TabControl();
            this.searchRulesLabel = new System.Windows.Forms.Label();
            this.dobSearchLabel = new System.Windows.Forms.Label();
            this.firstNameSearchLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dobSearchPicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.userLayoutPanel.SuspendLayout();
            this.PatientsTabPage.SuspendLayout();
            this.mainDashBoardTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLayoutPanel
            // 
            this.userLayoutPanel.ColumnCount = 3;
            this.userLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.59447F));
            this.userLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.40553F));
            this.userLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.userLayoutPanel.Controls.Add(this.userNameLabel, 1, 0);
            this.userLayoutPanel.Controls.Add(this.logoutLinkLabel, 2, 0);
            this.userLayoutPanel.Controls.Add(this.welcomeLabel, 0, 0);
            this.userLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.userLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.userLayoutPanel.Name = "userLayoutPanel";
            this.userLayoutPanel.RowCount = 1;
            this.userLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.userLayoutPanel.Size = new System.Drawing.Size(1004, 28);
            this.userLayoutPanel.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(784, 5);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 17);
            this.userNameLabel.TabIndex = 1;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(943, 5);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(52, 17);
            this.logoutLinkLabel.TabIndex = 3;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(714, 5);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(66, 17);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome";
            // 
            // newAppointmentButton
            // 
            this.newAppointmentButton.AutoSize = true;
            this.newAppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAppointmentButton.Location = new System.Drawing.Point(21, 42);
            this.newAppointmentButton.Margin = new System.Windows.Forms.Padding(2);
            this.newAppointmentButton.Name = "newAppointmentButton";
            this.newAppointmentButton.Size = new System.Drawing.Size(191, 35);
            this.newAppointmentButton.TabIndex = 1;
            this.newAppointmentButton.Text = "New Appointment";
            this.newAppointmentButton.UseVisualStyleBackColor = true;
            this.newAppointmentButton.Click += new System.EventHandler(this.NewAppointmentButton_Click);
            // 
            // newPatientButton
            // 
            this.newPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPatientButton.Location = new System.Drawing.Point(243, 42);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(191, 35);
            this.newPatientButton.TabIndex = 3;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.NewPatientButton_Click);
            // 
            // PatientsTabPage
            // 
            this.PatientsTabPage.Controls.Add(this.button4);
            this.PatientsTabPage.Controls.Add(this.button3);
            this.PatientsTabPage.Controls.Add(this.button2);
            this.PatientsTabPage.Controls.Add(this.button1);
            this.PatientsTabPage.Controls.Add(this.textBox2);
            this.PatientsTabPage.Controls.Add(this.textBox1);
            this.PatientsTabPage.Controls.Add(this.dobSearchPicker);
            this.PatientsTabPage.Controls.Add(this.lastNameLabel);
            this.PatientsTabPage.Controls.Add(this.firstNameSearchLabel);
            this.PatientsTabPage.Controls.Add(this.dobSearchLabel);
            this.PatientsTabPage.Controls.Add(this.searchRulesLabel);
            this.PatientsTabPage.Controls.Add(this.searchForIncidentsLabel);
            this.PatientsTabPage.Controls.Add(this.patientsUserControls1);
            this.PatientsTabPage.Location = new System.Drawing.Point(4, 25);
            this.PatientsTabPage.Name = "PatientsTabPage";
            this.PatientsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PatientsTabPage.Size = new System.Drawing.Size(996, 532);
            this.PatientsTabPage.TabIndex = 2;
            this.PatientsTabPage.Text = "Patients";
            this.PatientsTabPage.UseVisualStyleBackColor = true;
            // 
            // searchForIncidentsLabel
            // 
            this.searchForIncidentsLabel.AutoSize = true;
            this.searchForIncidentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForIncidentsLabel.Location = new System.Drawing.Point(17, 318);
            this.searchForIncidentsLabel.Name = "searchForIncidentsLabel";
            this.searchForIncidentsLabel.Size = new System.Drawing.Size(192, 25);
            this.searchForIncidentsLabel.TabIndex = 1;
            this.searchForIncidentsLabel.Text = "Search For Incidents";
            // 
            // patientsUserControls1
            // 
            this.patientsUserControls1.Location = new System.Drawing.Point(0, 0);
            this.patientsUserControls1.Name = "patientsUserControls1";
            this.patientsUserControls1.Size = new System.Drawing.Size(996, 532);
            this.patientsUserControls1.TabIndex = 0;
            // 
            // patientVisitsTabPage
            // 
            this.patientVisitsTabPage.Location = new System.Drawing.Point(4, 25);
            this.patientVisitsTabPage.Name = "patientVisitsTabPage";
            this.patientVisitsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.patientVisitsTabPage.Size = new System.Drawing.Size(996, 532);
            this.patientVisitsTabPage.TabIndex = 1;
            this.patientVisitsTabPage.Text = "Patient Visits";
            this.patientVisitsTabPage.UseVisualStyleBackColor = true;
            // 
            // appointmentsTabPage
            // 
            this.appointmentsTabPage.Location = new System.Drawing.Point(4, 25);
            this.appointmentsTabPage.Name = "appointmentsTabPage";
            this.appointmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentsTabPage.Size = new System.Drawing.Size(996, 532);
            this.appointmentsTabPage.TabIndex = 0;
            this.appointmentsTabPage.Text = "Appointments";
            this.appointmentsTabPage.UseVisualStyleBackColor = true;
            // 
            // mainDashBoardTabControl
            // 
            this.mainDashBoardTabControl.Controls.Add(this.appointmentsTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.patientVisitsTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.PatientsTabPage);
            this.mainDashBoardTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainDashBoardTabControl.Location = new System.Drawing.Point(0, 160);
            this.mainDashBoardTabControl.Name = "mainDashBoardTabControl";
            this.mainDashBoardTabControl.SelectedIndex = 0;
            this.mainDashBoardTabControl.Size = new System.Drawing.Size(1004, 561);
            this.mainDashBoardTabControl.TabIndex = 2;
            // 
            // searchRulesLabel
            // 
            this.searchRulesLabel.AutoSize = true;
            this.searchRulesLabel.Location = new System.Drawing.Point(22, 347);
            this.searchRulesLabel.Name = "searchRulesLabel";
            this.searchRulesLabel.Size = new System.Drawing.Size(378, 17);
            this.searchRulesLabel.TabIndex = 2;
            this.searchRulesLabel.Text = "Search by DOB, first and last name, or DOB and last name";
            // 
            // dobSearchLabel
            // 
            this.dobSearchLabel.AutoSize = true;
            this.dobSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobSearchLabel.Location = new System.Drawing.Point(71, 380);
            this.dobSearchLabel.Name = "dobSearchLabel";
            this.dobSearchLabel.Size = new System.Drawing.Size(61, 25);
            this.dobSearchLabel.TabIndex = 3;
            this.dobSearchLabel.Text = "DOB:";
            // 
            // firstNameSearchLabel
            // 
            this.firstNameSearchLabel.AutoSize = true;
            this.firstNameSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameSearchLabel.Location = new System.Drawing.Point(20, 430);
            this.firstNameSearchLabel.Name = "firstNameSearchLabel";
            this.firstNameSearchLabel.Size = new System.Drawing.Size(112, 25);
            this.firstNameSearchLabel.TabIndex = 4;
            this.firstNameSearchLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(20, 477);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 25);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // dobSearchPicker
            // 
            this.dobSearchPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobSearchPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobSearchPicker.Location = new System.Drawing.Point(138, 380);
            this.dobSearchPicker.Name = "dobSearchPicker";
            this.dobSearchPicker.Size = new System.Drawing.Size(262, 30);
            this.dobSearchPicker.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(138, 430);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 30);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(138, 477);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 30);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(440, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(656, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(783, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 35);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 721);
            this.Controls.Add(this.newPatientButton);
            this.Controls.Add(this.mainDashBoardTabControl);
            this.Controls.Add(this.newAppointmentButton);
            this.Controls.Add(this.userLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "smartClinic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboard_FormClosed);
            this.userLayoutPanel.ResumeLayout(false);
            this.userLayoutPanel.PerformLayout();
            this.PatientsTabPage.ResumeLayout(false);
            this.PatientsTabPage.PerformLayout();
            this.mainDashBoardTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel userLayoutPanel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.Button newAppointmentButton;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.TabPage PatientsTabPage;
        private UserControls.PatientsUserControls patientsUserControls1;
        private System.Windows.Forms.TabPage patientVisitsTabPage;
        private System.Windows.Forms.TabPage appointmentsTabPage;
        private System.Windows.Forms.TabControl mainDashBoardTabControl;
        private System.Windows.Forms.Label searchForIncidentsLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dobSearchPicker;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameSearchLabel;
        private System.Windows.Forms.Label dobSearchLabel;
        private System.Windows.Forms.Label searchRulesLabel;
    }
}