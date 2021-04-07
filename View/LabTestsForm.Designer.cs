
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
            this.testsComboBox = new System.Windows.Forms.ComboBox();
            this.chooseATestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testsComboBox
            // 
            this.testsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testsComboBox.FormattingEnabled = true;
            this.testsComboBox.Location = new System.Drawing.Point(291, 153);
            this.testsComboBox.Name = "testsComboBox";
            this.testsComboBox.Size = new System.Drawing.Size(475, 45);
            this.testsComboBox.TabIndex = 0;
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
            // LabTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.chooseATestLabel);
            this.Controls.Add(this.testsComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabTestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab Tests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox testsComboBox;
        private System.Windows.Forms.Label chooseATestLabel;
    }
}