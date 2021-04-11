
namespace SmartClinic.View
{
    partial class LabTestDetailsForm
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
            System.Windows.Forms.Label appointmentIDLabel;
            System.Windows.Forms.Label datePerformedLabel;
            System.Windows.Forms.Label isNormalLabel;
            System.Windows.Forms.Label resultLabel;
            System.Windows.Forms.Label labTestCodeLabel;
            System.Windows.Forms.Label nameLabel;
            this.labTestsDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.appointmentIDLabel2 = new System.Windows.Forms.Label();
            this.patientNameDisplayLabel = new System.Windows.Forms.Label();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.apptDateTimeDisplayLabel = new System.Windows.Forms.Label();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.patientIDDisplayLabel = new System.Windows.Forms.Label();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTestButton = new System.Windows.Forms.Button();
            this.labTestDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.isNormalComboBox = new System.Windows.Forms.ComboBox();
            this.datePerformedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.labTestCodeLabel2 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.labTestResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.labTestListBox = new System.Windows.Forms.ListBox();
            this.clinicPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labTestCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            appointmentIDLabel = new System.Windows.Forms.Label();
            datePerformedLabel = new System.Windows.Forms.Label();
            isNormalLabel = new System.Windows.Forms.Label();
            resultLabel = new System.Windows.Forms.Label();
            labTestCodeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.labTestsDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            this.labTestDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestResultsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicPersonBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentIDLabel
            // 
            appointmentIDLabel.AutoSize = true;
            appointmentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentIDLabel.Location = new System.Drawing.Point(468, 92);
            appointmentIDLabel.Name = "appointmentIDLabel";
            appointmentIDLabel.Size = new System.Drawing.Size(70, 20);
            appointmentIDLabel.TabIndex = 90;
            appointmentIDLabel.Text = "Appt ID:";
            // 
            // datePerformedLabel
            // 
            datePerformedLabel.AutoSize = true;
            datePerformedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datePerformedLabel.Location = new System.Drawing.Point(17, 107);
            datePerformedLabel.Name = "datePerformedLabel";
            datePerformedLabel.Size = new System.Drawing.Size(133, 20);
            datePerformedLabel.TabIndex = 92;
            datePerformedLabel.Text = "Date Performed:";
            // 
            // isNormalLabel
            // 
            isNormalLabel.AutoSize = true;
            isNormalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isNormalLabel.Location = new System.Drawing.Point(17, 149);
            isNormalLabel.Name = "isNormalLabel";
            isNormalLabel.Size = new System.Drawing.Size(154, 20);
            isNormalLabel.TabIndex = 94;
            isNormalLabel.Text = "Normal / Abnormal:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resultLabel.Location = new System.Drawing.Point(17, 202);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(62, 20);
            resultLabel.TabIndex = 96;
            resultLabel.Text = "Result:";
            // 
            // labTestCodeLabel
            // 
            labTestCodeLabel.AutoSize = true;
            labTestCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labTestCodeLabel.Location = new System.Drawing.Point(17, 33);
            labTestCodeLabel.Name = "labTestCodeLabel";
            labTestCodeLabel.Size = new System.Drawing.Size(124, 20);
            labTestCodeLabel.TabIndex = 97;
            labTestCodeLabel.Text = "Lab Test Code:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(17, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(58, 20);
            nameLabel.TabIndex = 99;
            nameLabel.Text = "Name:";
            // 
            // labTestsDetailsGroupBox
            // 
            this.labTestsDetailsGroupBox.Controls.Add(this.appointmentIDLabel2);
            this.labTestsDetailsGroupBox.Controls.Add(this.patientNameDisplayLabel);
            this.labTestsDetailsGroupBox.Controls.Add(appointmentIDLabel);
            this.labTestsDetailsGroupBox.Controls.Add(this.appointmentDateLabel);
            this.labTestsDetailsGroupBox.Controls.Add(this.apptDateTimeDisplayLabel);
            this.labTestsDetailsGroupBox.Controls.Add(this.PatientNameLabel);
            this.labTestsDetailsGroupBox.Controls.Add(this.patientIDLabel);
            this.labTestsDetailsGroupBox.Controls.Add(this.patientIDDisplayLabel);
            this.labTestsDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestsDetailsGroupBox.Location = new System.Drawing.Point(367, 12);
            this.labTestsDetailsGroupBox.Name = "labTestsDetailsGroupBox";
            this.labTestsDetailsGroupBox.Size = new System.Drawing.Size(672, 144);
            this.labTestsDetailsGroupBox.TabIndex = 90;
            this.labTestsDetailsGroupBox.TabStop = false;
            this.labTestsDetailsGroupBox.Text = "Patient and Appointment Info";
            // 
            // appointmentIDLabel2
            // 
            this.appointmentIDLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentIDLabel2.Location = new System.Drawing.Point(544, 92);
            this.appointmentIDLabel2.Name = "appointmentIDLabel2";
            this.appointmentIDLabel2.Size = new System.Drawing.Size(122, 23);
            this.appointmentIDLabel2.TabIndex = 91;
            // 
            // patientNameDisplayLabel
            // 
            this.patientNameDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameDisplayLabel.Location = new System.Drawing.Point(138, 38);
            this.patientNameDisplayLabel.Name = "patientNameDisplayLabel";
            this.patientNameDisplayLabel.Size = new System.Drawing.Size(298, 20);
            this.patientNameDisplayLabel.TabIndex = 0;
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.appointmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateLabel.ForeColor = System.Drawing.Color.Black;
            this.appointmentDateLabel.Location = new System.Drawing.Point(9, 91);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(141, 23);
            this.appointmentDateLabel.TabIndex = 43;
            this.appointmentDateLabel.Text = "Appt. Date/Time:";
            this.appointmentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // apptDateTimeDisplayLabel
            // 
            this.apptDateTimeDisplayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.apptDateTimeDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptDateTimeDisplayLabel.Location = new System.Drawing.Point(156, 92);
            this.apptDateTimeDisplayLabel.Name = "apptDateTimeDisplayLabel";
            this.apptDateTimeDisplayLabel.Size = new System.Drawing.Size(244, 28);
            this.apptDateTimeDisplayLabel.TabIndex = 0;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.ForeColor = System.Drawing.Color.Black;
            this.PatientNameLabel.Location = new System.Drawing.Point(16, 38);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(116, 23);
            this.PatientNameLabel.TabIndex = 54;
            this.PatientNameLabel.Text = "Patient Name:";
            this.PatientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLabel.ForeColor = System.Drawing.Color.Black;
            this.patientIDLabel.Location = new System.Drawing.Point(455, 38);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(96, 23);
            this.patientIDLabel.TabIndex = 38;
            this.patientIDLabel.Text = "Patient ID:";
            this.patientIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // patientIDDisplayLabel
            // 
            this.patientIDDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDDisplayLabel.Location = new System.Drawing.Point(557, 38);
            this.patientIDDisplayLabel.Name = "patientIDDisplayLabel";
            this.patientIDDisplayLabel.Size = new System.Drawing.Size(109, 23);
            this.patientIDDisplayLabel.TabIndex = 0;
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(SmartClinic.Model.LabTest);
            // 
            // orderTestButton
            // 
            this.orderTestButton.Location = new System.Drawing.Point(6, 158);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(337, 30);
            this.orderTestButton.TabIndex = 91;
            this.orderTestButton.Text = "Order Tests";
            this.orderTestButton.UseVisualStyleBackColor = true;
            this.orderTestButton.Click += new System.EventHandler(this.orderTestButton_Click);
            // 
            // labTestDetailsGroupBox
            // 
            this.labTestDetailsGroupBox.Controls.Add(this.resultTextBox);
            this.labTestDetailsGroupBox.Controls.Add(resultLabel);
            this.labTestDetailsGroupBox.Controls.Add(this.isNormalComboBox);
            this.labTestDetailsGroupBox.Controls.Add(isNormalLabel);
            this.labTestDetailsGroupBox.Controls.Add(this.datePerformedDateTimePicker);
            this.labTestDetailsGroupBox.Controls.Add(this.saveChangesButton);
            this.labTestDetailsGroupBox.Controls.Add(labTestCodeLabel);
            this.labTestDetailsGroupBox.Controls.Add(datePerformedLabel);
            this.labTestDetailsGroupBox.Controls.Add(this.labTestCodeLabel2);
            this.labTestDetailsGroupBox.Controls.Add(nameLabel);
            this.labTestDetailsGroupBox.Controls.Add(this.nameLabel1);
            this.labTestDetailsGroupBox.Location = new System.Drawing.Point(688, 162);
            this.labTestDetailsGroupBox.Name = "labTestDetailsGroupBox";
            this.labTestDetailsGroupBox.Size = new System.Drawing.Size(351, 347);
            this.labTestDetailsGroupBox.TabIndex = 103;
            this.labTestDetailsGroupBox.TabStop = false;
            this.labTestDetailsGroupBox.Text = "Lab Test Details";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(85, 199);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(249, 85);
            this.resultTextBox.TabIndex = 97;
            // 
            // isNormalComboBox
            // 
            this.isNormalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isNormalComboBox.FormattingEnabled = true;
            this.isNormalComboBox.Items.AddRange(new object[] {
            "",
            "normal",
            "abnormal"});
            this.isNormalComboBox.Location = new System.Drawing.Point(177, 146);
            this.isNormalComboBox.Name = "isNormalComboBox";
            this.isNormalComboBox.Size = new System.Drawing.Size(157, 28);
            this.isNormalComboBox.TabIndex = 95;
            // 
            // datePerformedDateTimePicker
            // 
            this.datePerformedDateTimePicker.CustomFormat = "";
            this.datePerformedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePerformedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePerformedDateTimePicker.Location = new System.Drawing.Point(156, 102);
            this.datePerformedDateTimePicker.Name = "datePerformedDateTimePicker";
            this.datePerformedDateTimePicker.ShowCheckBox = true;
            this.datePerformedDateTimePicker.Size = new System.Drawing.Size(178, 26);
            this.datePerformedDateTimePicker.TabIndex = 93;
            this.datePerformedDateTimePicker.Value = new System.DateTime(2021, 4, 11, 0, 27, 11, 0);
            this.datePerformedDateTimePicker.ValueChanged += new System.EventHandler(this.DatePerformedDateTimePicker_ValueChanged);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(21, 310);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(313, 31);
            this.saveChangesButton.TabIndex = 101;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            // 
            // labTestCodeLabel2
            // 
            this.labTestCodeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestCodeLabel2.Location = new System.Drawing.Point(147, 33);
            this.labTestCodeLabel2.Name = "labTestCodeLabel2";
            this.labTestCodeLabel2.Size = new System.Drawing.Size(142, 23);
            this.labTestCodeLabel2.TabIndex = 98;
            // 
            // nameLabel1
            // 
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.Location = new System.Drawing.Point(81, 70);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(264, 23);
            this.nameLabel1.TabIndex = 100;
            // 
            // labTestResultsDataGridView
            // 
            this.labTestResultsDataGridView.AllowUserToAddRows = false;
            this.labTestResultsDataGridView.AutoGenerateColumns = false;
            this.labTestResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.labTestResultsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labTestResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labTestResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.labTestCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.labTestResultsDataGridView.DataSource = this.labTestBindingSource;
            this.labTestResultsDataGridView.Location = new System.Drawing.Point(12, 219);
            this.labTestResultsDataGridView.Name = "labTestResultsDataGridView";
            this.labTestResultsDataGridView.RowHeadersWidth = 51;
            this.labTestResultsDataGridView.RowTemplate.Height = 24;
            this.labTestResultsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.labTestResultsDataGridView.Size = new System.Drawing.Size(670, 250);
            this.labTestResultsDataGridView.TabIndex = 100;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(12, 478);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(122, 31);
            this.closeButton.TabIndex = 102;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // labTestListBox
            // 
            this.labTestListBox.AllowDrop = true;
            this.labTestListBox.DataSource = this.labTestBindingSource;
            this.labTestListBox.DisplayMember = "Name";
            this.labTestListBox.FormattingEnabled = true;
            this.labTestListBox.ItemHeight = 20;
            this.labTestListBox.Location = new System.Drawing.Point(6, 28);
            this.labTestListBox.Name = "labTestListBox";
            this.labTestListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.labTestListBox.Size = new System.Drawing.Size(337, 124);
            this.labTestListBox.Sorted = true;
            this.labTestListBox.TabIndex = 107;
            this.labTestListBox.ValueMember = "LabTestCode";
            // 
            // clinicPersonBindingSource
            // 
            this.clinicPersonBindingSource.DataSource = typeof(SmartClinic.Model.ClinicPerson);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labTestListBox);
            this.groupBox1.Controls.Add(this.orderTestButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 193);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click to Select or Deselect Tests";
            // 
            // labTestCodeDataGridViewTextBoxColumn
            // 
            this.labTestCodeDataGridViewTextBoxColumn.DataPropertyName = "LabTestCode";
            this.labTestCodeDataGridViewTextBoxColumn.HeaderText = "LabTestCode";
            this.labTestCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labTestCodeDataGridViewTextBoxColumn.Name = "labTestCodeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // LabTestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labTestResultsDataGridView);
            this.Controls.Add(this.labTestDetailsGroupBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.labTestsDetailsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LabTestDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Tests";
            this.Load += new System.EventHandler(this.ThisFormLoad_Load);
            this.labTestsDetailsGroupBox.ResumeLayout(false);
            this.labTestsDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            this.labTestDetailsGroupBox.ResumeLayout(false);
            this.labTestDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestResultsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicPersonBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox labTestsDetailsGroupBox;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.Button orderTestButton;
        private System.Windows.Forms.Label appointmentIDLabel2;
        private System.Windows.Forms.DateTimePicker datePerformedDateTimePicker;
        private System.Windows.Forms.ComboBox isNormalComboBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label labTestCodeLabel2;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.DataGridView labTestResultsDataGridView;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label patientNameDisplayLabel;
        private System.Windows.Forms.Label apptDateTimeDisplayLabel;
        private System.Windows.Forms.Label patientIDDisplayLabel;
        private System.Windows.Forms.GroupBox labTestDetailsGroupBox;
        private System.Windows.Forms.ListBox labTestListBox;
        private System.Windows.Forms.BindingSource labTestBindingSource;
        private System.Windows.Forms.BindingSource clinicPersonBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn labTestCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}