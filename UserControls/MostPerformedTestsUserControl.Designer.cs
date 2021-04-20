
namespace SmartClinic.UserControls
{
    partial class MostPerformedTestsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostPerformedTestsUserControl));
            this.reportTitleLabel = new System.Windows.Forms.Label();
            this.reportDescriptionLabel = new System.Windows.Forms.Label();
            this.reportInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.queryInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.reportInformationGroupBox.SuspendLayout();
            this.queryInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportTitleLabel
            // 
            this.reportTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTitleLabel.Location = new System.Drawing.Point(13, 35);
            this.reportTitleLabel.Name = "reportTitleLabel";
            this.reportTitleLabel.Size = new System.Drawing.Size(517, 73);
            this.reportTitleLabel.TabIndex = 0;
            this.reportTitleLabel.Text = "This report will show the most performed tests during the\r\nspecified time period " +
    "that were performed at least twice.";
            // 
            // reportDescriptionLabel
            // 
            this.reportDescriptionLabel.Location = new System.Drawing.Point(18, 123);
            this.reportDescriptionLabel.Name = "reportDescriptionLabel";
            this.reportDescriptionLabel.Size = new System.Drawing.Size(660, 231);
            this.reportDescriptionLabel.TabIndex = 1;
            this.reportDescriptionLabel.Text = resources.GetString("reportDescriptionLabel.Text");
            // 
            // reportInformationGroupBox
            // 
            this.reportInformationGroupBox.Controls.Add(this.reportDescriptionLabel);
            this.reportInformationGroupBox.Controls.Add(this.reportTitleLabel);
            this.reportInformationGroupBox.Location = new System.Drawing.Point(19, 18);
            this.reportInformationGroupBox.Name = "reportInformationGroupBox";
            this.reportInformationGroupBox.Size = new System.Drawing.Size(965, 364);
            this.reportInformationGroupBox.TabIndex = 2;
            this.reportInformationGroupBox.TabStop = false;
            this.reportInformationGroupBox.Text = "Report Information";
            // 
            // queryInformationGroupBox
            // 
            this.queryInformationGroupBox.Controls.Add(this.generateReportButton);
            this.queryInformationGroupBox.Controls.Add(this.endDateDateTimePicker);
            this.queryInformationGroupBox.Controls.Add(this.startDateDateTimePicker);
            this.queryInformationGroupBox.Controls.Add(this.endDateLabel);
            this.queryInformationGroupBox.Controls.Add(this.startDateLabel);
            this.queryInformationGroupBox.Location = new System.Drawing.Point(19, 388);
            this.queryInformationGroupBox.Name = "queryInformationGroupBox";
            this.queryInformationGroupBox.Size = new System.Drawing.Size(965, 94);
            this.queryInformationGroupBox.TabIndex = 3;
            this.queryInformationGroupBox.TabStop = false;
            this.queryInformationGroupBox.Text = "Query";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(7, 36);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(72, 17);
            this.startDateLabel.TabIndex = 0;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(215, 36);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(67, 17);
            this.endDateLabel.TabIndex = 1;
            this.endDateLabel.Text = "End Date";
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateDateTimePicker.Location = new System.Drawing.Point(10, 57);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(151, 22);
            this.startDateDateTimePicker.TabIndex = 2;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateDateTimePicker.Location = new System.Drawing.Point(218, 56);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(151, 22);
            this.endDateDateTimePicker.TabIndex = 3;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(420, 57);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(140, 23);
            this.generateReportButton.TabIndex = 4;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // MostPerformedTestsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.queryInformationGroupBox);
            this.Controls.Add(this.reportInformationGroupBox);
            this.Name = "MostPerformedTestsUserControl";
            this.Size = new System.Drawing.Size(996, 618);
            this.reportInformationGroupBox.ResumeLayout(false);
            this.queryInformationGroupBox.ResumeLayout(false);
            this.queryInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label reportTitleLabel;
        private System.Windows.Forms.Label reportDescriptionLabel;
        private System.Windows.Forms.GroupBox reportInformationGroupBox;
        private System.Windows.Forms.GroupBox queryInformationGroupBox;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
    }
}
