
namespace SmartClinic.View
{
    partial class NewPatientForm
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
            this.newClinicPersonUserControl1 = new SmartClinic.UserControls.NewClinicPersonUserControl();
            this.SuspendLayout();
            // 
            // newClinicPersonUserControl1
            // 
            this.newClinicPersonUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newClinicPersonUserControl1.Location = new System.Drawing.Point(0, 0);
            this.newClinicPersonUserControl1.Name = "newClinicPersonUserControl1";
            this.newClinicPersonUserControl1.Size = new System.Drawing.Size(1200, 719);
            this.newClinicPersonUserControl1.TabIndex = 0;
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 719);
            this.Controls.Add(this.newClinicPersonUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Patient";
            this.Load += new System.EventHandler(this.NewPatientForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.NewClinicPersonUserControl newClinicPersonUserControl1;
    }
}