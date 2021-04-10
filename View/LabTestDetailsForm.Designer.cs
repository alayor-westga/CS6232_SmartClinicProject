﻿
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
            this.patientVisitDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.patientIDTextBox = new System.Windows.Forms.Label();
            this.selectTestLabel = new System.Windows.Forms.Label();
            this.PatientNameLabel = new System.Windows.Forms.Label();
            this.patientNameTextBox = new System.Windows.Forms.Label();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.appointmentDateTextBox = new System.Windows.Forms.Label();
            this.selectTestomboBox = new System.Windows.Forms.ComboBox();
            this.orderTestButton = new System.Windows.Forms.Button();
            this.patientVisitDetailsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientVisitDetailsGroupBox
            // 
            this.patientVisitDetailsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.patientVisitDetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientVisitDetailsGroupBox.Location = new System.Drawing.Point(29, 23);
            this.patientVisitDetailsGroupBox.Name = "patientVisitDetailsGroupBox";
            this.patientVisitDetailsGroupBox.Size = new System.Drawing.Size(914, 138);
            this.patientVisitDetailsGroupBox.TabIndex = 90;
            this.patientVisitDetailsGroupBox.TabStop = false;
            this.patientVisitDetailsGroupBox.Text = "Patient Visit Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.93064F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.06936F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Controls.Add(this.orderTestButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientIDLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientIDTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectTestLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.PatientNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.appointmentDateLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.appointmentDateTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectTestomboBox, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.31507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.68493F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 77);
            this.tableLayoutPanel1.TabIndex = 88;
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLabel.ForeColor = System.Drawing.Color.Black;
            this.patientIDLabel.Location = new System.Drawing.Point(349, 0);
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
            this.patientIDTextBox.Location = new System.Drawing.Point(461, 0);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(100, 23);
            this.patientIDTextBox.TabIndex = 42;
            // 
            // selectTestLabel
            // 
            this.selectTestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectTestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTestLabel.ForeColor = System.Drawing.Color.Black;
            this.selectTestLabel.Location = new System.Drawing.Point(329, 37);
            this.selectTestLabel.Name = "selectTestLabel";
            this.selectTestLabel.Size = new System.Drawing.Size(126, 23);
            this.selectTestLabel.TabIndex = 51;
            this.selectTestLabel.Text = "Select Test:";
            this.selectTestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PatientNameLabel
            // 
            this.PatientNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameLabel.ForeColor = System.Drawing.Color.Black;
            this.PatientNameLabel.Location = new System.Drawing.Point(18, 0);
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
            this.patientNameTextBox.Location = new System.Drawing.Point(146, 0);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(177, 23);
            this.patientNameTextBox.TabIndex = 55;
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appointmentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateLabel.ForeColor = System.Drawing.Color.Black;
            this.appointmentDateLabel.Location = new System.Drawing.Point(3, 37);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(137, 23);
            this.appointmentDateLabel.TabIndex = 43;
            this.appointmentDateLabel.Text = "Appt. Date/Time:";
            this.appointmentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // appointmentDateTextBox
            // 
            this.appointmentDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.appointmentDateTextBox.Location = new System.Drawing.Point(146, 37);
            this.appointmentDateTextBox.Name = "appointmentDateTextBox";
            this.appointmentDateTextBox.Size = new System.Drawing.Size(177, 23);
            this.appointmentDateTextBox.TabIndex = 47;
            // 
            // selectTestomboBox
            // 
            this.selectTestomboBox.FormattingEnabled = true;
            this.selectTestomboBox.Location = new System.Drawing.Point(461, 40);
            this.selectTestomboBox.Name = "selectTestomboBox";
            this.selectTestomboBox.Size = new System.Drawing.Size(265, 33);
            this.selectTestomboBox.TabIndex = 56;
            // 
            // orderTestButton
            // 
            this.orderTestButton.Location = new System.Drawing.Point(759, 40);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(140, 33);
            this.orderTestButton.TabIndex = 91;
            this.orderTestButton.Text = "Order Test";
            this.orderTestButton.UseVisualStyleBackColor = true;
            // 
            // LabTestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 643);
            this.Controls.Add(this.patientVisitDetailsGroupBox);
            this.Name = "LabTestDetailsForm";
            this.Text = "LabTestDetailsForm";
            this.patientVisitDetailsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox patientVisitDetailsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Label patientIDTextBox;
        private System.Windows.Forms.Label selectTestLabel;
        private System.Windows.Forms.Label PatientNameLabel;
        private System.Windows.Forms.Label patientNameTextBox;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.Label appointmentDateTextBox;
        private System.Windows.Forms.ComboBox selectTestomboBox;
        private System.Windows.Forms.Button orderTestButton;
    }
}