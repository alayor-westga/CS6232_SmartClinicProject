
namespace SmartClinic.UserControls
{
    partial class MostPerformedTestUserControl
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._cs6232_g1DataSet = new SmartClinic._cs6232_g1DataSet();
            this.getMostPerformedTestsDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getMostPerformedTestsDuringDatesTableAdapter = new SmartClinic._cs6232_g1DataSetTableAdapters.getMostPerformedTestsDuringDatesTableAdapter();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.resultsButton = new System.Windows.Forms.Button();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMostPerformedTestsDuringDatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "MostPerformedTestsDataSet";
            reportDataSource3.Value = this.getMostPerformedTestsDuringDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SmartClinic.MostPerformedTestsReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(21, 101);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1046, 488);
            this.reportViewer1.TabIndex = 0;
            // 
            // _cs6232_g1DataSet
            // 
            this._cs6232_g1DataSet.DataSetName = "_cs6232_g1DataSet";
            this._cs6232_g1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getMostPerformedTestsDuringDatesBindingSource
            // 
            this.getMostPerformedTestsDuringDatesBindingSource.DataMember = "getMostPerformedTestsDuringDates";
            this.getMostPerformedTestsDuringDatesBindingSource.DataSource = this._cs6232_g1DataSet;
            // 
            // getMostPerformedTestsDuringDatesTableAdapter
            // 
            this.getMostPerformedTestsDuringDatesTableAdapter.ClearBeforeFill = true;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(26, 33);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(72, 17);
            this.startDateLabel.TabIndex = 1;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(162, 33);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(67, 17);
            this.endDateLabel.TabIndex = 2;
            this.endDateLabel.Text = "End Date";
            // 
            // resultsButton
            // 
            this.resultsButton.Location = new System.Drawing.Point(301, 50);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(141, 28);
            this.resultsButton.TabIndex = 3;
            this.resultsButton.Text = "Get Query Results";
            this.resultsButton.UseVisualStyleBackColor = true;
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(29, 53);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(116, 22);
            this.startDateTimePicker.TabIndex = 4;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(165, 53);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.endDateTimePicker.TabIndex = 5;
            // 
            // MostPerformedTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostPerformedTestUserControl";
            this.Size = new System.Drawing.Size(1086, 614);
            this.Load += new System.EventHandler(this.MostPerformedTestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMostPerformedTestsDuringDatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private _cs6232_g1DataSet _cs6232_g1DataSet;
        private System.Windows.Forms.BindingSource getMostPerformedTestsDuringDatesBindingSource;
        private _cs6232_g1DataSetTableAdapters.getMostPerformedTestsDuringDatesTableAdapter getMostPerformedTestsDuringDatesTableAdapter;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
    }
}
