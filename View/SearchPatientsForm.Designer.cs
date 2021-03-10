
namespace SmartClinic.View
{
    partial class SearchPatientsForm
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
            this.searchPatientsUserControl = new SmartClinic.UserControls.SearchPatientsUserControl();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectPatientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchPatientsUserControl
            // 
            this.searchPatientsUserControl.Location = new System.Drawing.Point(12, 12);
            this.searchPatientsUserControl.Name = "searchPatientsUserControl";
            this.searchPatientsUserControl.Size = new System.Drawing.Size(1172, 694);
            this.searchPatientsUserControl.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(749, 707);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(188, 55);
            this.cancelButton.TabIndex = 42;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // selectPatientButton
            // 
            this.selectPatientButton.AutoSize = true;
            this.selectPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPatientButton.Location = new System.Drawing.Point(969, 707);
            this.selectPatientButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectPatientButton.Name = "selectPatientButton";
            this.selectPatientButton.Size = new System.Drawing.Size(188, 55);
            this.selectPatientButton.TabIndex = 43;
            this.selectPatientButton.Text = "Select";
            this.selectPatientButton.UseVisualStyleBackColor = true;
            this.selectPatientButton.Click += new System.EventHandler(this.SelectPatientButton_Click);
            // 
            // SearchPatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 776);
            this.Controls.Add(this.selectPatientButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchPatientsUserControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchPatientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Patients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.SearchPatientsUserControl searchPatientsUserControl;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button selectPatientButton;
    }
}