
namespace SmartClinic.View
{
    partial class NurseAccessCredentialsForm
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
            this.nurseIdLabel = new System.Windows.Forms.Label();
            this.nurseIdValueLabel = new System.Windows.Forms.Label();
            this.nurseNameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.nurseNameValueLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.setCredentialsButton = new System.Windows.Forms.Button();
            this.confirmPasswordErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.userNameErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nurseIdLabel
            // 
            this.nurseIdLabel.AutoSize = true;
            this.nurseIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseIdLabel.Location = new System.Drawing.Point(29, 24);
            this.nurseIdLabel.Name = "nurseIdLabel";
            this.nurseIdLabel.Size = new System.Drawing.Size(152, 37);
            this.nurseIdLabel.TabIndex = 0;
            this.nurseIdLabel.Text = "Nurse ID:";
            // 
            // nurseIdValueLabel
            // 
            this.nurseIdValueLabel.AutoSize = true;
            this.nurseIdValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseIdValueLabel.Location = new System.Drawing.Point(175, 24);
            this.nurseIdValueLabel.Name = "nurseIdValueLabel";
            this.nurseIdValueLabel.Size = new System.Drawing.Size(27, 37);
            this.nurseIdValueLabel.TabIndex = 1;
            this.nurseIdValueLabel.Text = "-";
            // 
            // nurseNameLabel
            // 
            this.nurseNameLabel.AutoSize = true;
            this.nurseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseNameLabel.Location = new System.Drawing.Point(29, 85);
            this.nurseNameLabel.Name = "nurseNameLabel";
            this.nurseNameLabel.Size = new System.Drawing.Size(207, 37);
            this.nurseNameLabel.TabIndex = 2;
            this.nurseNameLabel.Text = "Nurse Name:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(29, 161);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(179, 37);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "User Name";
            // 
            // nurseNameValueLabel
            // 
            this.nurseNameValueLabel.AutoSize = true;
            this.nurseNameValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseNameValueLabel.Location = new System.Drawing.Point(229, 85);
            this.nurseNameValueLabel.Name = "nurseNameValueLabel";
            this.nurseNameValueLabel.Size = new System.Drawing.Size(27, 37);
            this.nurseNameValueLabel.TabIndex = 4;
            this.nurseNameValueLabel.Text = "-";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(29, 242);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(158, 37);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(29, 323);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(280, 37);
            this.confirmPasswordLabel.TabIndex = 6;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(214, 158);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(407, 44);
            this.userNameTextBox.TabIndex = 7;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(214, 239);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(407, 44);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(315, 320);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(306, 44);
            this.confirmPasswordTextBox.TabIndex = 9;
            this.confirmPasswordTextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox_TextChanged);
            // 
            // setCredentialsButton
            // 
            this.setCredentialsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setCredentialsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCredentialsButton.Location = new System.Drawing.Point(376, 407);
            this.setCredentialsButton.Name = "setCredentialsButton";
            this.setCredentialsButton.Size = new System.Drawing.Size(245, 57);
            this.setCredentialsButton.TabIndex = 10;
            this.setCredentialsButton.Text = "Set Credentials";
            this.setCredentialsButton.UseVisualStyleBackColor = true;
            this.setCredentialsButton.Click += new System.EventHandler(this.SetCredentialsButton_Click);
            // 
            // confirmPasswordErrorLabel
            // 
            this.confirmPasswordErrorLabel.AutoSize = true;
            this.confirmPasswordErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.confirmPasswordErrorLabel.Location = new System.Drawing.Point(357, 367);
            this.confirmPasswordErrorLabel.Name = "confirmPasswordErrorLabel";
            this.confirmPasswordErrorLabel.Size = new System.Drawing.Size(0, 25);
            this.confirmPasswordErrorLabel.TabIndex = 11;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.passwordErrorLabel.Location = new System.Drawing.Point(357, 285);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(0, 25);
            this.passwordErrorLabel.TabIndex = 12;
            // 
            // userNameErrorLabel
            // 
            this.userNameErrorLabel.AutoSize = true;
            this.userNameErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.userNameErrorLabel.Location = new System.Drawing.Point(357, 205);
            this.userNameErrorLabel.Name = "userNameErrorLabel";
            this.userNameErrorLabel.Size = new System.Drawing.Size(0, 25);
            this.userNameErrorLabel.TabIndex = 13;
            // 
            // NurseAccessCredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 476);
            this.Controls.Add(this.userNameErrorLabel);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.confirmPasswordErrorLabel);
            this.Controls.Add(this.setCredentialsButton);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nurseNameValueLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.nurseNameLabel);
            this.Controls.Add(this.nurseIdValueLabel);
            this.Controls.Add(this.nurseIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NurseAccessCredentialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nurse Access Credentials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nurseIdLabel;
        private System.Windows.Forms.Label nurseIdValueLabel;
        private System.Windows.Forms.Label nurseNameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label nurseNameValueLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Button setCredentialsButton;
        private System.Windows.Forms.Label confirmPasswordErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label userNameErrorLabel;
    }
}