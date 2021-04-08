
namespace SmartClinic.View
{
    partial class LabTestsForm
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
            this.labTestsComboBox = new System.Windows.Forms.ComboBox();
            this.chooseATestLabel = new System.Windows.Forms.Label();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labTestsComboBox
            // 
            this.labTestsComboBox.DataSource = this.labTestBindingSource;
            this.labTestsComboBox.DisplayMember = "Name";
            this.labTestsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTestsComboBox.FormattingEnabled = true;
            this.labTestsComboBox.Location = new System.Drawing.Point(291, 153);
            this.labTestsComboBox.Name = "labTestsComboBox";
            this.labTestsComboBox.Size = new System.Drawing.Size(475, 45);
            this.labTestsComboBox.TabIndex = 0;
            this.labTestsComboBox.ValueMember = "LabTestCode";
            // 
            // chooseATestLabel
            // 
            this.chooseATestLabel.AutoSize = true;
            this.chooseATestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseATestLabel.Location = new System.Drawing.Point(33, 156);
            this.chooseATestLabel.Name = "chooseATestLabel";
            this.chooseATestLabel.Size = new System.Drawing.Size(223, 37);
            this.chooseATestLabel.TabIndex = 1;
            this.chooseATestLabel.Text = "Choose a test:";
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(SmartClinic.Model.LabTest);
            // 
            // LabTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.chooseATestLabel);
            this.Controls.Add(this.labTestsComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabTestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Tests";
            this.Load += new System.EventHandler(this.LabTestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox labTestsComboBox;
        private System.Windows.Forms.Label chooseATestLabel;
        private System.Windows.Forms.BindingSource labTestBindingSource;
    }
}