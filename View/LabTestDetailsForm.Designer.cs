
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labTestsDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labTestComboBox = new System.Windows.Forms.ComboBox();
            this.orderTestButton = new System.Windows.Forms.Button();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.patientIDTextBox = new System.Windows.Forms.Label();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.patientNameTextBox = new System.Windows.Forms.Label();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.appointmentDateTextBox = new System.Windows.Forms.Label();
            this.selectTestLabel = new System.Windows.Forms.Label();
            this.appointmentIDLabel2 = new System.Windows.Forms.Label();
            this.labTestResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datePerformedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isNormalComboBox = new System.Windows.Forms.ComboBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.labTestCodeLabel2 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.labTestResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            appointmentIDLabel = new System.Windows.Forms.Label();
            datePerformedLabel = new System.Windows.Forms.Label();
            isNormalLabel = new System.Windows.Forms.Label();
            resultLabel = new System.Windows.Forms.Label();
            labTestCodeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.labTestsDetailsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestResultsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentIDLabel
            // 
            appointmentIDLabel.AutoSize = true;
            appointmentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentIDLabel.Location = new System.Drawing.Point(31, 401);
            appointmentIDLabel.Name = "appointmentIDLabel";
            appointmentIDLabel.Size = new System.Drawing.Size(129, 20);
            appointmentIDLabel.TabIndex = 90;
            appointmentIDLabel.Text = "Appointment ID:";
            // 
            // datePerformedLabel
            // 
            datePerformedLabel.AutoSize = true;
            datePerformedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datePerformedLabel.Location = new System.Drawing.Point(31, 444);
            datePerformedLabel.Name = "datePerformedLabel";
            datePerformedLabel.Size = new System.Drawing.Size(133, 20);
            datePerformedLabel.TabIndex = 92;
            datePerformedLabel.Text = "Date Performed:";
            // 
            // isNormalLabel
            // 
            isNormalLabel.AutoSize = true;
            isNormalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isNormalLabel.Location = new System.Drawing.Point(31, 501);
            isNormalLabel.Name = "isNormalLabel";
            isNormalLabel.Size = new System.Drawing.Size(154, 20);
            isNormalLabel.TabIndex = 94;
            isNormalLabel.Text = "Normal / Abnormal:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resultLabel.Location = new System.Drawing.Point(424, 441);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(62, 20);
            resultLabel.TabIndex = 96;
            resultLabel.Text = "Result:";
            // 
            // labTestCodeLabel
            // 
            labTestCodeLabel.AutoSize = true;
            labTestCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labTestCodeLabel.Location = new System.Drawing.Point(295, 401);
            labTestCodeLabel.Name = "labTestCodeLabel";
            labTestCodeLabel.Size = new System.Drawing.Size(124, 20);
            labTestCodeLabel.TabIndex = 97;
            labTestCodeLabel.Text = "Lab Test Code:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(545, 401);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(96, 20);
            nameLabel.TabIndex = 99;
            nameLabel.Text = "Test Name:";
            // 
            // labTestsDetailsGroupBox
            // 
            this.labTestsDetailsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.labTestsDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestsDetailsGroupBox.Location = new System.Drawing.Point(29, 23);
            this.labTestsDetailsGroupBox.Name = "labTestsDetailsGroupBox";
            this.labTestsDetailsGroupBox.Size = new System.Drawing.Size(914, 138);
            this.labTestsDetailsGroupBox.TabIndex = 90;
            this.labTestsDetailsGroupBox.TabStop = false;
            this.labTestsDetailsGroupBox.Text = "Lab Test Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.54369F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.45631F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.Controls.Add(this.labTestComboBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.orderTestButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientIDLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientIDTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PatientNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.appointmentDateLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.appointmentDateTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectTestLabel, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.31507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.68493F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 70);
            this.tableLayoutPanel1.TabIndex = 88;
            // 
            // labTestComboBox
            // 
            this.labTestComboBox.DataSource = this.labTestBindingSource;
            this.labTestComboBox.DisplayMember = "Name";
            this.labTestComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestComboBox.FormattingEnabled = true;
            this.labTestComboBox.Location = new System.Drawing.Point(439, 37);
            this.labTestComboBox.Name = "labTestComboBox";
            this.labTestComboBox.Size = new System.Drawing.Size(271, 28);
            this.labTestComboBox.TabIndex = 105;
            this.labTestComboBox.ValueMember = "LabTestCode";
            // 
            // orderTestButton
            // 
            this.orderTestButton.Location = new System.Drawing.Point(737, 37);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(140, 30);
            this.orderTestButton.TabIndex = 91;
            this.orderTestButton.Text = "Order Test";
            this.orderTestButton.UseVisualStyleBackColor = true;
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLabel.ForeColor = System.Drawing.Color.Black;
            this.patientIDLabel.Location = new System.Drawing.Point(327, 0);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(106, 23);
            this.patientIDLabel.TabIndex = 38;
            this.patientIDLabel.Text = "Patient ID:";
            this.patientIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patientIDTextBox.Location = new System.Drawing.Point(439, 0);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(100, 23);
            this.patientIDTextBox.TabIndex = 42;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.ForeColor = System.Drawing.Color.Black;
            this.PatientNameLabel.Location = new System.Drawing.Point(23, 0);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(122, 23);
            this.PatientNameLabel.TabIndex = 54;
            this.PatientNameLabel.Text = "Patient Name:";
            this.PatientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patientNameTextBox.Location = new System.Drawing.Point(151, 0);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(150, 23);
            this.patientNameTextBox.TabIndex = 55;
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.appointmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateLabel.ForeColor = System.Drawing.Color.Black;
            this.appointmentDateLabel.Location = new System.Drawing.Point(3, 40);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(142, 23);
            this.appointmentDateLabel.TabIndex = 43;
            this.appointmentDateLabel.Text = "Appt. Date/Time:";
            this.appointmentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appointmentDateTextBox
            // 
            this.appointmentDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.appointmentDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.appointmentDateTextBox.Location = new System.Drawing.Point(151, 40);
            this.appointmentDateTextBox.Name = "appointmentDateTextBox";
            this.appointmentDateTextBox.Size = new System.Drawing.Size(150, 23);
            this.appointmentDateTextBox.TabIndex = 47;
            // 
            // selectTestLabel
            // 
            this.selectTestLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTestLabel.ForeColor = System.Drawing.Color.Black;
            this.selectTestLabel.Location = new System.Drawing.Point(307, 40);
            this.selectTestLabel.Name = "selectTestLabel";
            this.selectTestLabel.Size = new System.Drawing.Size(126, 23);
            this.selectTestLabel.TabIndex = 51;
            this.selectTestLabel.Text = "Select Test:";
            this.selectTestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appointmentIDLabel2
            // 
            this.appointmentIDLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestResultsBindingSource, "AppointmentID", true));
            this.appointmentIDLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentIDLabel2.Location = new System.Drawing.Point(166, 401);
            this.appointmentIDLabel2.Name = "appointmentIDLabel2";
            this.appointmentIDLabel2.Size = new System.Drawing.Size(106, 23);
            this.appointmentIDLabel2.TabIndex = 91;
            // 
            // labTestResultsBindingSource
            // 
            this.labTestResultsBindingSource.DataSource = typeof(SmartClinic.Model.LabTestResults);
            // 
            // datePerformedDateTimePicker
            // 
            this.datePerformedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.labTestResultsBindingSource, "DatePerformed", true));
            this.datePerformedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePerformedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePerformedDateTimePicker.Location = new System.Drawing.Point(170, 439);
            this.datePerformedDateTimePicker.Name = "datePerformedDateTimePicker";
            this.datePerformedDateTimePicker.Size = new System.Drawing.Size(210, 26);
            this.datePerformedDateTimePicker.TabIndex = 93;
            // 
            // isNormalComboBox
            // 
            this.isNormalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestResultsBindingSource, "IsNormal", true));
            this.isNormalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isNormalComboBox.FormattingEnabled = true;
            this.isNormalComboBox.Location = new System.Drawing.Point(191, 498);
            this.isNormalComboBox.Name = "isNormalComboBox";
            this.isNormalComboBox.Size = new System.Drawing.Size(189, 28);
            this.isNormalComboBox.TabIndex = 95;
            // 
            // resultTextBox
            // 
            this.resultTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestResultsBindingSource, "Result", true));
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(496, 441);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(441, 85);
            this.resultTextBox.TabIndex = 97;
            // 
            // labTestCodeLabel2
            // 
            this.labTestCodeLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestResultsBindingSource, "LabTest.LabTestCode", true));
            this.labTestCodeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestCodeLabel2.Location = new System.Drawing.Point(425, 401);
            this.labTestCodeLabel2.Name = "labTestCodeLabel2";
            this.labTestCodeLabel2.Size = new System.Drawing.Size(100, 23);
            this.labTestCodeLabel2.TabIndex = 98;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labTestResultsBindingSource, "LabTest.Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.Location = new System.Drawing.Point(647, 401);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(284, 23);
            this.nameLabel1.TabIndex = 100;
            // 
            // labTestResultsDataGridView
            // 
            this.labTestResultsDataGridView.AllowUserToAddRows = false;
            this.labTestResultsDataGridView.AutoGenerateColumns = false;
            this.labTestResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.labTestResultsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.labTestResultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.labTestResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labTestResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.LabTest,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.labTestResultsDataGridView.DataSource = this.labTestResultsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.labTestResultsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.labTestResultsDataGridView.Location = new System.Drawing.Point(29, 167);
            this.labTestResultsDataGridView.Name = "labTestResultsDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.labTestResultsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.labTestResultsDataGridView.RowHeadersWidth = 51;
            this.labTestResultsDataGridView.RowTemplate.Height = 24;
            this.labTestResultsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.labTestResultsDataGridView.Size = new System.Drawing.Size(914, 220);
            this.labTestResultsDataGridView.TabIndex = 100;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AppointmentID";
            this.dataGridViewTextBoxColumn1.FillWeight = 40F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Appt ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // LabTest
            // 
            this.LabTest.DataPropertyName = "LabTest";
            this.LabTest.HeaderText = "LabTest";
            this.LabTest.MinimumWidth = 6;
            this.LabTest.Name = "LabTest";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DatePerformed";
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Date Performed";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Result";
            this.dataGridViewTextBoxColumn4.HeaderText = "Result";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(29, 560);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(131, 31);
            this.saveChangesButton.TabIndex = 101;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(170, 560);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 31);
            this.cancelButton.TabIndex = 102;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(SmartClinic.Model.LabTest);
            // 
            // LabTestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 635);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.labTestResultsDataGridView);
            this.Controls.Add(labTestCodeLabel);
            this.Controls.Add(this.labTestCodeLabel2);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(appointmentIDLabel);
            this.Controls.Add(this.appointmentIDLabel2);
            this.Controls.Add(datePerformedLabel);
            this.Controls.Add(this.datePerformedDateTimePicker);
            this.Controls.Add(isNormalLabel);
            this.Controls.Add(this.isNormalComboBox);
            this.Controls.Add(resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.labTestsDetailsGroupBox);
            this.Name = "LabTestDetailsForm";
            this.Text = "LabTestDetailsForm";
            this.Load += new System.EventHandler(this.ThisFormLoad_Load);
            this.labTestsDetailsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.labTestResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestResultsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox labTestsDetailsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Label patientIDTextBox;
        private System.Windows.Forms.Label selectTestLabel;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label patientNameTextBox;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.Label appointmentDateTextBox;
        private System.Windows.Forms.Button orderTestButton;
        private System.Windows.Forms.BindingSource labTestResultsBindingSource;
        private System.Windows.Forms.Label appointmentIDLabel2;
        private System.Windows.Forms.DateTimePicker datePerformedDateTimePicker;
        private System.Windows.Forms.ComboBox isNormalComboBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label labTestCodeLabel2;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.DataGridView labTestResultsDataGridView;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox labTestComboBox;
        private System.Windows.Forms.BindingSource labTestBindingSource;
    }
}