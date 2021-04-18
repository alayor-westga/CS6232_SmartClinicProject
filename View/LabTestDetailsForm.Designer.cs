
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
            this.closeButton = new System.Windows.Forms.Button();
            this.labTestListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labTestResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labTestResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridGroupBox = new System.Windows.Forms.GroupBox();
            this.labTestCodeComboBox = new System.Windows.Forms.ComboBox();
            this.labTestNameComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.resetSearchButton = new System.Windows.Forms.Button();
            this.codeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTestNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePerformedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            appointmentIDLabel = new System.Windows.Forms.Label();
            datePerformedLabel = new System.Windows.Forms.Label();
            isNormalLabel = new System.Windows.Forms.Label();
            resultLabel = new System.Windows.Forms.Label();
            labTestCodeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.labTestsDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            this.labTestDetailsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestResultsDataGridView)).BeginInit();
            this.dataGridGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentIDLabel
            // 
            appointmentIDLabel.AutoSize = true;
            appointmentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentIDLabel.Location = new System.Drawing.Point(702, 144);
            appointmentIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            appointmentIDLabel.Name = "appointmentIDLabel";
            appointmentIDLabel.Size = new System.Drawing.Size(113, 31);
            appointmentIDLabel.TabIndex = 90;
            appointmentIDLabel.Text = "Appt ID:";
            // 
            // datePerformedLabel
            // 
            datePerformedLabel.AutoSize = true;
            datePerformedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datePerformedLabel.Location = new System.Drawing.Point(9, 144);
            datePerformedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            datePerformedLabel.Name = "datePerformedLabel";
            datePerformedLabel.Size = new System.Drawing.Size(213, 31);
            datePerformedLabel.TabIndex = 92;
            datePerformedLabel.Text = "Date Performed:";
            // 
            // isNormalLabel
            // 
            isNormalLabel.AutoSize = true;
            isNormalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            isNormalLabel.Location = new System.Drawing.Point(9, 233);
            isNormalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            isNormalLabel.Name = "isNormalLabel";
            isNormalLabel.Size = new System.Drawing.Size(246, 31);
            isNormalLabel.TabIndex = 94;
            isNormalLabel.Text = "Normal / Abnormal:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resultLabel.Location = new System.Drawing.Point(9, 322);
            resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(100, 31);
            resultLabel.TabIndex = 96;
            resultLabel.Text = "Result:";
            // 
            // labTestCodeLabel
            // 
            labTestCodeLabel.AutoSize = true;
            labTestCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labTestCodeLabel.Location = new System.Drawing.Point(9, 45);
            labTestCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labTestCodeLabel.Name = "labTestCodeLabel";
            labTestCodeLabel.Size = new System.Drawing.Size(200, 31);
            labTestCodeLabel.TabIndex = 97;
            labTestCodeLabel.Text = "Lab Test Code:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(9, 95);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(94, 31);
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
            this.labTestsDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestsDetailsGroupBox.Location = new System.Drawing.Point(550, 19);
            this.labTestsDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labTestsDetailsGroupBox.Name = "labTestsDetailsGroupBox";
            this.labTestsDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labTestsDetailsGroupBox.Size = new System.Drawing.Size(1008, 225);
            this.labTestsDetailsGroupBox.TabIndex = 90;
            this.labTestsDetailsGroupBox.TabStop = false;
            this.labTestsDetailsGroupBox.Text = "Patient and Appointment Info";
            // 
            // appointmentIDLabel2
            // 
            this.appointmentIDLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentIDLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.appointmentIDLabel2.Location = new System.Drawing.Point(816, 144);
            this.appointmentIDLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appointmentIDLabel2.Name = "appointmentIDLabel2";
            this.appointmentIDLabel2.Size = new System.Drawing.Size(183, 36);
            this.appointmentIDLabel2.TabIndex = 91;
            // 
            // patientNameDisplayLabel
            // 
            this.patientNameDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameDisplayLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patientNameDisplayLabel.Location = new System.Drawing.Point(207, 59);
            this.patientNameDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientNameDisplayLabel.Name = "patientNameDisplayLabel";
            this.patientNameDisplayLabel.Size = new System.Drawing.Size(447, 31);
            this.patientNameDisplayLabel.TabIndex = 0;
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.appointmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateLabel.ForeColor = System.Drawing.Color.Black;
            this.appointmentDateLabel.Location = new System.Drawing.Point(14, 142);
            this.appointmentDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(212, 36);
            this.appointmentDateLabel.TabIndex = 43;
            this.appointmentDateLabel.Text = "Appt. Date/Time:";
            this.appointmentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // apptDateTimeDisplayLabel
            // 
            this.apptDateTimeDisplayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.apptDateTimeDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptDateTimeDisplayLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.apptDateTimeDisplayLabel.Location = new System.Drawing.Point(234, 144);
            this.apptDateTimeDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apptDateTimeDisplayLabel.Name = "apptDateTimeDisplayLabel";
            this.apptDateTimeDisplayLabel.Size = new System.Drawing.Size(366, 44);
            this.apptDateTimeDisplayLabel.TabIndex = 0;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.ForeColor = System.Drawing.Color.Black;
            this.PatientNameLabel.Location = new System.Drawing.Point(24, 59);
            this.PatientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientNameLabel.Name = "PatientNameLabel";
            this.PatientNameLabel.Size = new System.Drawing.Size(174, 36);
            this.PatientNameLabel.TabIndex = 54;
            this.PatientNameLabel.Text = "Patient Name:";
            this.PatientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLabel.ForeColor = System.Drawing.Color.Black;
            this.patientIDLabel.Location = new System.Drawing.Point(682, 59);
            this.patientIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(144, 36);
            this.patientIDLabel.TabIndex = 38;
            this.patientIDLabel.Text = "Patient ID:";
            this.patientIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // patientIDDisplayLabel
            // 
            this.patientIDDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDDisplayLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patientIDDisplayLabel.Location = new System.Drawing.Point(836, 59);
            this.patientIDDisplayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientIDDisplayLabel.Name = "patientIDDisplayLabel";
            this.patientIDDisplayLabel.Size = new System.Drawing.Size(164, 36);
            this.patientIDDisplayLabel.TabIndex = 0;
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(SmartClinic.Model.LabTest);
            // 
            // orderTestButton
            // 
            this.orderTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTestButton.Location = new System.Drawing.Point(9, 239);
            this.orderTestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(506, 47);
            this.orderTestButton.TabIndex = 91;
            this.orderTestButton.Text = "Order Selected Tests";
            this.orderTestButton.UseVisualStyleBackColor = true;
            this.orderTestButton.Click += new System.EventHandler(this.OrderTestButton_Click);
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
            this.labTestDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestDetailsGroupBox.Location = new System.Drawing.Point(1184, 253);
            this.labTestDetailsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labTestDetailsGroupBox.Name = "labTestDetailsGroupBox";
            this.labTestDetailsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labTestDetailsGroupBox.Size = new System.Drawing.Size(375, 625);
            this.labTestDetailsGroupBox.TabIndex = 103;
            this.labTestDetailsGroupBox.TabStop = false;
            this.labTestDetailsGroupBox.Text = "Lab Test Details";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(15, 358);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(348, 190);
            this.resultTextBox.TabIndex = 97;
            // 
            // isNormalComboBox
            // 
            this.isNormalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isNormalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isNormalComboBox.FormattingEnabled = true;
            this.isNormalComboBox.Items.AddRange(new object[] {
            "",
            "normal",
            "abnormal"});
            this.isNormalComboBox.Location = new System.Drawing.Point(15, 269);
            this.isNormalComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isNormalComboBox.Name = "isNormalComboBox";
            this.isNormalComboBox.Size = new System.Drawing.Size(348, 39);
            this.isNormalComboBox.TabIndex = 95;
            // 
            // datePerformedDateTimePicker
            // 
            this.datePerformedDateTimePicker.AllowDrop = true;
            this.datePerformedDateTimePicker.CustomFormat = "";
            this.datePerformedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePerformedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePerformedDateTimePicker.Location = new System.Drawing.Point(15, 181);
            this.datePerformedDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePerformedDateTimePicker.Name = "datePerformedDateTimePicker";
            this.datePerformedDateTimePicker.ShowCheckBox = true;
            this.datePerformedDateTimePicker.Size = new System.Drawing.Size(348, 38);
            this.datePerformedDateTimePicker.TabIndex = 93;
            this.datePerformedDateTimePicker.Value = new System.DateTime(2021, 4, 11, 0, 27, 11, 0);
            this.datePerformedDateTimePicker.ValueChanged += new System.EventHandler(this.DatePerformedDateTimePicker_ValueChanged);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(15, 559);
            this.saveChangesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(350, 48);
            this.saveChangesButton.TabIndex = 101;
            this.saveChangesButton.Text = "Save Updates to Lab Test";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // labTestCodeLabel2
            // 
            this.labTestCodeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestCodeLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labTestCodeLabel2.Location = new System.Drawing.Point(208, 45);
            this.labTestCodeLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTestCodeLabel2.Name = "labTestCodeLabel2";
            this.labTestCodeLabel2.Size = new System.Drawing.Size(156, 36);
            this.labTestCodeLabel2.TabIndex = 98;
            // 
            // nameLabel1
            // 
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameLabel1.Location = new System.Drawing.Point(105, 95);
            this.nameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(261, 36);
            this.nameLabel1.TabIndex = 100;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(27, 812);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(183, 48);
            this.closeButton.TabIndex = 102;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // labTestListBox
            // 
            this.labTestListBox.AllowDrop = true;
            this.labTestListBox.DataSource = this.labTestBindingSource;
            this.labTestListBox.DisplayMember = "Name";
            this.labTestListBox.FormattingEnabled = true;
            this.labTestListBox.ItemHeight = 25;
            this.labTestListBox.Location = new System.Drawing.Point(9, 44);
            this.labTestListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labTestListBox.Name = "labTestListBox";
            this.labTestListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.labTestListBox.Size = new System.Drawing.Size(504, 179);
            this.labTestListBox.Sorted = true;
            this.labTestListBox.TabIndex = 107;
            this.labTestListBox.ValueMember = "LabTestCode";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labTestListBox);
            this.groupBox1.Controls.Add(this.orderTestButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(524, 302);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click to Select or Deselect Tests";
            // 
            // labTestResultsBindingSource
            // 
            this.labTestResultsBindingSource.DataSource = typeof(SmartClinic.Model.LabTestResults);
            // 
            // labTestResultsDataGridView
            // 
            this.labTestResultsDataGridView.AllowUserToAddRows = false;
            this.labTestResultsDataGridView.AllowUserToDeleteRows = false;
            this.labTestResultsDataGridView.AutoGenerateColumns = false;
            this.labTestResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.labTestResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labTestResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeColumn,
            this.labTestNameColumn,
            this.datePerformedColumn,
            this.resultColumn,
            this.normalColumn});
            this.labTestResultsDataGridView.DataSource = this.labTestResultsBindingSource;
            this.labTestResultsDataGridView.Location = new System.Drawing.Point(9, 41);
            this.labTestResultsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labTestResultsDataGridView.MultiSelect = false;
            this.labTestResultsDataGridView.Name = "labTestResultsDataGridView";
            this.labTestResultsDataGridView.ReadOnly = true;
            this.labTestResultsDataGridView.RowHeadersWidth = 51;
            this.labTestResultsDataGridView.RowTemplate.Height = 24;
            this.labTestResultsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.labTestResultsDataGridView.Size = new System.Drawing.Size(1138, 428);
            this.labTestResultsDataGridView.TabIndex = 108;
            this.labTestResultsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridViewStateChanged_RowsAdded);
            this.labTestResultsDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridViewStateChanged_RowsRemoved);
            this.labTestResultsDataGridView.SelectionChanged += new System.EventHandler(this.RowSelectionChanged_Click);
            // 
            // dataGridGroupBox
            // 
            this.dataGridGroupBox.Controls.Add(this.labTestResultsDataGridView);
            this.dataGridGroupBox.Location = new System.Drawing.Point(18, 325);
            this.dataGridGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridGroupBox.Name = "dataGridGroupBox";
            this.dataGridGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridGroupBox.Size = new System.Drawing.Size(1156, 478);
            this.dataGridGroupBox.TabIndex = 110;
            this.dataGridGroupBox.TabStop = false;
            this.dataGridGroupBox.Text = "The Tests Below Have Been Ordered";
            // 
            // labTestCodeComboBox
            // 
            this.labTestCodeComboBox.DataSource = this.labTestBindingSource;
            this.labTestCodeComboBox.DisplayMember = "LabTestCode";
            this.labTestCodeComboBox.FormattingEnabled = true;
            this.labTestCodeComboBox.Location = new System.Drawing.Point(567, 289);
            this.labTestCodeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labTestCodeComboBox.Name = "labTestCodeComboBox";
            this.labTestCodeComboBox.Size = new System.Drawing.Size(134, 33);
            this.labTestCodeComboBox.TabIndex = 111;
            this.labTestCodeComboBox.ValueMember = "LabTestCode";
            this.labTestCodeComboBox.DropDownClosed += new System.EventHandler(this.LabTestCode_DropDownClosed);
            // 
            // labTestNameComboBox
            // 
            this.labTestNameComboBox.DataSource = this.labTestBindingSource;
            this.labTestNameComboBox.DisplayMember = "Name";
            this.labTestNameComboBox.FormattingEnabled = true;
            this.labTestNameComboBox.Location = new System.Drawing.Point(712, 289);
            this.labTestNameComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labTestNameComboBox.Name = "labTestNameComboBox";
            this.labTestNameComboBox.Size = new System.Drawing.Size(288, 33);
            this.labTestNameComboBox.TabIndex = 112;
            this.labTestNameComboBox.ValueMember = "LabTestCode";
            this.labTestNameComboBox.DropDownClosed += new System.EventHandler(this.LabTestName_DropDownClosed);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1011, 289);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(154, 38);
            this.searchButton.TabIndex = 113;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(567, 258);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(343, 25);
            this.searchLabel.TabIndex = 114;
            this.searchLabel.Text = "Search by Lab Test Code or Name";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.ForeColor = System.Drawing.Color.Red;
            this.resultsLabel.Location = new System.Drawing.Point(1032, 808);
            this.resultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(0, 25);
            this.resultsLabel.TabIndex = 115;
            // 
            // resetSearchButton
            // 
            this.resetSearchButton.Location = new System.Drawing.Point(1011, 245);
            this.resetSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetSearchButton.Name = "resetSearchButton";
            this.resetSearchButton.Size = new System.Drawing.Size(154, 36);
            this.resetSearchButton.TabIndex = 116;
            this.resetSearchButton.Text = "Reset Search";
            this.resetSearchButton.UseVisualStyleBackColor = true;
            this.resetSearchButton.Click += new System.EventHandler(this.ResetSearchButton_Click);
            // 
            // codeColumn
            // 
            this.codeColumn.DataPropertyName = "LabTestCode";
            this.codeColumn.FillWeight = 25F;
            this.codeColumn.HeaderText = "Code";
            this.codeColumn.MinimumWidth = 6;
            this.codeColumn.Name = "codeColumn";
            this.codeColumn.ReadOnly = true;
            // 
            // labTestNameColumn
            // 
            this.labTestNameColumn.DataPropertyName = "LabTestName";
            this.labTestNameColumn.FillWeight = 80F;
            this.labTestNameColumn.HeaderText = "Test Name";
            this.labTestNameColumn.MinimumWidth = 6;
            this.labTestNameColumn.Name = "labTestNameColumn";
            this.labTestNameColumn.ReadOnly = true;
            // 
            // datePerformedColumn
            // 
            this.datePerformedColumn.DataPropertyName = "DatePerformed";
            this.datePerformedColumn.FillWeight = 65F;
            this.datePerformedColumn.HeaderText = "Date Performed";
            this.datePerformedColumn.MinimumWidth = 6;
            this.datePerformedColumn.Name = "datePerformedColumn";
            this.datePerformedColumn.ReadOnly = true;
            // 
            // resultColumn
            // 
            this.resultColumn.DataPropertyName = "Result";
            this.resultColumn.HeaderText = "Result";
            this.resultColumn.MinimumWidth = 6;
            this.resultColumn.Name = "resultColumn";
            this.resultColumn.ReadOnly = true;
            // 
            // normalColumn
            // 
            this.normalColumn.DataPropertyName = "IsNormal";
            this.normalColumn.FillWeight = 30F;
            this.normalColumn.HeaderText = "Normal?";
            this.normalColumn.MinimumWidth = 6;
            this.normalColumn.Name = "normalColumn";
            this.normalColumn.ReadOnly = true;
            this.normalColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.normalColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LabTestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 886);
            this.Controls.Add(this.resetSearchButton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.labTestNameComboBox);
            this.Controls.Add(this.labTestCodeComboBox);
            this.Controls.Add(this.dataGridGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labTestDetailsGroupBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.labTestsDetailsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LabTestDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Tests";
            this.Load += new System.EventHandler(this.ThisFormLoad_Load);
            this.labTestsDetailsGroupBox.ResumeLayout(false);
            this.labTestsDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            this.labTestDetailsGroupBox.ResumeLayout(false);
            this.labTestDetailsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.labTestResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestResultsDataGridView)).EndInit();
            this.dataGridGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label patientNameDisplayLabel;
        private System.Windows.Forms.Label apptDateTimeDisplayLabel;
        private System.Windows.Forms.Label patientIDDisplayLabel;
        private System.Windows.Forms.GroupBox labTestDetailsGroupBox;
        private System.Windows.Forms.ListBox labTestListBox;
        private System.Windows.Forms.BindingSource labTestBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource labTestResultsBindingSource;
        private System.Windows.Forms.DataGridView labTestResultsDataGridView;
        private System.Windows.Forms.GroupBox dataGridGroupBox;
        private System.Windows.Forms.ComboBox labTestCodeComboBox;
        private System.Windows.Forms.ComboBox labTestNameComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button resetSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labTestNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePerformedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normalColumn;
    }
}