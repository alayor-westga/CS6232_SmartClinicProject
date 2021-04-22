
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._cs6232_g1DataSet = new SmartClinic._cs6232_g1DataSet();
            this.getMostPerformedTestsDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getMostPerformedTestsDuringDatesTableAdapter = new SmartClinic._cs6232_g1DataSetTableAdapters.getMostPerformedTestsDuringDatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMostPerformedTestsDuringDatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "MostPerformedTestsDataSet";
            reportDataSource1.Value = this.getMostPerformedTestsDuringDatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
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
            // MostPerformedTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostPerformedTestUserControl";
            this.Size = new System.Drawing.Size(1086, 614);
            this.Load += new System.EventHandler(this.MostPerformedTestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._cs6232_g1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getMostPerformedTestsDuringDatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private _cs6232_g1DataSet _cs6232_g1DataSet;
        private System.Windows.Forms.BindingSource getMostPerformedTestsDuringDatesBindingSource;
        private _cs6232_g1DataSetTableAdapters.getMostPerformedTestsDuringDatesTableAdapter getMostPerformedTestsDuringDatesTableAdapter;
    }
}
