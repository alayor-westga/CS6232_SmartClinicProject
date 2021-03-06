
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
            this.addPatientButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePickerForDOB = new System.Windows.Forms.DateTimePicker();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.address2 = new System.Windows.Forms.Label();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addPatientButton
            // 
            this.addPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientButton.Location = new System.Drawing.Point(402, 309);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(137, 37);
            this.addPatientButton.TabIndex = 0;
            this.addPatientButton.Text = "Add Patient";
            this.addPatientButton.UseVisualStyleBackColor = true;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(594, 309);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(137, 37);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(124, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 30);
            this.textBox1.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(252, 73);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(236, 30);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(550, 73);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(236, 30);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // dateTimePickerForDOB
            // 
            this.dateTimePickerForDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerForDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerForDOB.Location = new System.Drawing.Point(330, 18);
            this.dateTimePickerForDOB.Name = "dateTimePickerForDOB";
            this.dateTimePickerForDOB.Size = new System.Drawing.Size(172, 30);
            this.dateTimePickerForDOB.TabIndex = 5;
            // 
            // address1TextBox
            // 
            this.address1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1TextBox.Location = new System.Drawing.Point(125, 133);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(661, 30);
            this.address1TextBox.TabIndex = 6;
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLabel.Location = new System.Drawing.Point(13, 21);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(102, 25);
            this.patientIDLabel.TabIndex = 7;
            this.patientIDLabel.Text = "Patient ID:";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(263, 21);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(61, 25);
            this.dob.TabIndex = 8;
            this.dob.Text = "DOB:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(191, 76);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(55, 25);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(492, 76);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(55, 25);
            this.lastName.TabIndex = 10;
            this.lastName.Text = "Last:";
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1Label.Location = new System.Drawing.Point(12, 136);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(107, 25);
            this.address1Label.TabIndex = 11;
            this.address1Label.Text = "Address 1:";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.Location = new System.Drawing.Point(368, 256);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(64, 25);
            this.state.TabIndex = 12;
            this.state.Text = "State:";
            // 
            // address2
            // 
            this.address2.AutoSize = true;
            this.address2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2.Location = new System.Drawing.Point(12, 195);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(107, 25);
            this.address2.TabIndex = 14;
            this.address2.Text = "Address 2:";
            // 
            // address2TextBox
            // 
            this.address2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2TextBox.Location = new System.Drawing.Point(125, 192);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(661, 30);
            this.address2TextBox.TabIndex = 13;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(67, 256);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(52, 25);
            this.cityLabel.TabIndex = 15;
            this.cityLabel.Text = "City:";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeLabel.Location = new System.Drawing.Point(537, 256);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(93, 25);
            this.zipCodeLabel.TabIndex = 16;
            this.zipCodeLabel.Text = "ZipCode:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(44, 315);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(75, 25);
            this.phoneNumberLabel.TabIndex = 17;
            this.phoneNumberLabel.Text = "Phone:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(125, 253);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(221, 30);
            this.cityTextBox.TabIndex = 18;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTextBox.Location = new System.Drawing.Point(440, 253);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(82, 30);
            this.stateTextBox.TabIndex = 19;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeTextBox.Location = new System.Drawing.Point(636, 253);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(150, 30);
            this.zipCodeTextBox.TabIndex = 20;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(124, 312);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(221, 30);
            this.phoneTextBox.TabIndex = 21;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(34, 73);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(88, 25);
            this.genderLabel.TabIndex = 22;
            this.genderLabel.Text = "Gender: ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(124, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 30);
            this.textBox2.TabIndex = 23;
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.state);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.patientIDLabel);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.dateTimePickerForDOB);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NewPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerForDOB;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label address2;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox textBox2;
    }
}