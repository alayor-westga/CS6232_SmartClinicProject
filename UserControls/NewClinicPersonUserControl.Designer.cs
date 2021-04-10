
namespace SmartClinic.UserControls
{
    partial class NewClinicPersonUserControl
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
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.ssnErrorLabel = new System.Windows.Forms.Label();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.dobErrorLabel = new System.Windows.Forms.Label();
            this.zipCodeErrorLabel = new System.Windows.Forms.Label();
            this.stateErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.cityErrorLabel = new System.Windows.Forms.Label();
            this.address1ErrorLabel = new System.Windows.Forms.Label();
            this.genderErrorLabel = new System.Windows.Forms.Label();
            this.lastNameErrorLabel = new System.Windows.Forms.Label();
            this.firstNameErrorLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.genderLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.address1Label = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.dateTimePickerForDOB = new System.Windows.Forms.DateTimePicker();
            this.addClinicPersonButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.address2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(174, 108);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(256, 45);
            this.genderComboBox.TabIndex = 3;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(179, 451);
            this.stateComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(527, 45);
            this.stateComboBox.TabIndex = 8;
            // 
            // ssnErrorLabel
            // 
            this.ssnErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ssnErrorLabel.Location = new System.Drawing.Point(624, 591);
            this.ssnErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ssnErrorLabel.Name = "ssnErrorLabel";
            this.ssnErrorLabel.Size = new System.Drawing.Size(321, 36);
            this.ssnErrorLabel.TabIndex = 73;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnTextBox.Location = new System.Drawing.Point(628, 541);
            this.ssnTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ssnTextBox.MaxLength = 9;
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(238, 44);
            this.ssnTextBox.TabIndex = 11;
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssnLabel.Location = new System.Drawing.Point(528, 544);
            this.ssnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(92, 37);
            this.ssnLabel.TabIndex = 71;
            this.ssnLabel.Text = "SSN:";
            // 
            // idLabel
            // 
            this.idLabel.Enabled = false;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.Black;
            this.idLabel.Location = new System.Drawing.Point(775, 94);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(390, 36);
            this.idLabel.TabIndex = 70;
            this.idLabel.Text = "ID: -";
            // 
            // dobErrorLabel
            // 
            this.dobErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.dobErrorLabel.Location = new System.Drawing.Point(434, 171);
            this.dobErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobErrorLabel.Name = "dobErrorLabel";
            this.dobErrorLabel.Size = new System.Drawing.Size(363, 36);
            this.dobErrorLabel.TabIndex = 69;
            // 
            // zipCodeErrorLabel
            // 
            this.zipCodeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.zipCodeErrorLabel.Location = new System.Drawing.Point(982, 501);
            this.zipCodeErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipCodeErrorLabel.Name = "zipCodeErrorLabel";
            this.zipCodeErrorLabel.Size = new System.Drawing.Size(219, 36);
            this.zipCodeErrorLabel.TabIndex = 68;
            // 
            // stateErrorLabel
            // 
            this.stateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.stateErrorLabel.Location = new System.Drawing.Point(175, 501);
            this.stateErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateErrorLabel.Name = "stateErrorLabel";
            this.stateErrorLabel.Size = new System.Drawing.Size(296, 36);
            this.stateErrorLabel.TabIndex = 67;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorLabel.Location = new System.Drawing.Point(182, 591);
            this.phoneErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(321, 36);
            this.phoneErrorLabel.TabIndex = 66;
            // 
            // cityErrorLabel
            // 
            this.cityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.cityErrorLabel.Location = new System.Drawing.Point(835, 402);
            this.cityErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityErrorLabel.Name = "cityErrorLabel";
            this.cityErrorLabel.Size = new System.Drawing.Size(363, 36);
            this.cityErrorLabel.TabIndex = 65;
            // 
            // address1ErrorLabel
            // 
            this.address1ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.address1ErrorLabel.Location = new System.Drawing.Point(182, 311);
            this.address1ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address1ErrorLabel.Name = "address1ErrorLabel";
            this.address1ErrorLabel.Size = new System.Drawing.Size(363, 36);
            this.address1ErrorLabel.TabIndex = 64;
            // 
            // genderErrorLabel
            // 
            this.genderErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.genderErrorLabel.Location = new System.Drawing.Point(448, 111);
            this.genderErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderErrorLabel.Name = "genderErrorLabel";
            this.genderErrorLabel.Size = new System.Drawing.Size(218, 36);
            this.genderErrorLabel.TabIndex = 63;
            // 
            // lastNameErrorLabel
            // 
            this.lastNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameErrorLabel.Location = new System.Drawing.Point(734, 68);
            this.lastNameErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameErrorLabel.Name = "lastNameErrorLabel";
            this.lastNameErrorLabel.Size = new System.Drawing.Size(363, 36);
            this.lastNameErrorLabel.TabIndex = 62;
            // 
            // firstNameErrorLabel
            // 
            this.firstNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameErrorLabel.Location = new System.Drawing.Point(174, 68);
            this.firstNameErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameErrorLabel.Name = "firstNameErrorLabel";
            this.firstNameErrorLabel.Size = new System.Drawing.Size(363, 36);
            this.firstNameErrorLabel.TabIndex = 61;
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(964, 637);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(201, 58);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear Form";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(36, 111);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(141, 37);
            this.genderLabel.TabIndex = 60;
            this.genderLabel.Text = "Gender: ";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(174, 541);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTextBox.MaxLength = 10;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(330, 44);
            this.phoneTextBox.TabIndex = 10;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeTextBox.Location = new System.Drawing.Point(982, 447);
            this.zipCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zipCodeTextBox.MaxLength = 10;
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(180, 44);
            this.zipCodeTextBox.TabIndex = 9;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(829, 348);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(330, 44);
            this.cityTextBox.TabIndex = 7;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(56, 544);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(118, 37);
            this.phoneNumberLabel.TabIndex = 59;
            this.phoneNumberLabel.Text = "Phone:";
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeLabel.Location = new System.Drawing.Point(822, 454);
            this.zipCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(156, 37);
            this.zipCodeLabel.TabIndex = 58;
            this.zipCodeLabel.Text = "Zip Code:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(747, 355);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(80, 37);
            this.cityLabel.TabIndex = 57;
            this.cityLabel.Text = "City:";
            // 
            // address2TextBox
            // 
            this.address2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2TextBox.Location = new System.Drawing.Point(176, 354);
            this.address2TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(530, 44);
            this.address2TextBox.TabIndex = 6;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(75, 454);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(100, 37);
            this.stateLabel.TabIndex = 54;
            this.stateLabel.Text = "State:";
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1Label.Location = new System.Drawing.Point(6, 265);
            this.address1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(169, 37);
            this.address1Label.TabIndex = 52;
            this.address1Label.Text = "Address 1:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(632, 21);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(87, 37);
            this.lastNameLabel.TabIndex = 51;
            this.lastNameLabel.Text = "Last:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(79, 21);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(89, 37);
            this.firstNameLabel.TabIndex = 49;
            this.firstNameLabel.Text = "First:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(46, 187);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(95, 37);
            this.dobLabel.TabIndex = 46;
            this.dobLabel.Text = "DOB:";
            // 
            // address1TextBox
            // 
            this.address1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1TextBox.Location = new System.Drawing.Point(176, 261);
            this.address1TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(990, 44);
            this.address1TextBox.TabIndex = 5;
            // 
            // dateTimePickerForDOB
            // 
            this.dateTimePickerForDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerForDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerForDOB.Location = new System.Drawing.Point(174, 180);
            this.dateTimePickerForDOB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerForDOB.Name = "dateTimePickerForDOB";
            this.dateTimePickerForDOB.Size = new System.Drawing.Size(256, 44);
            this.dateTimePickerForDOB.TabIndex = 4;
            // 
            // addClinicPersonButton
            // 
            this.addClinicPersonButton.AutoSize = true;
            this.addClinicPersonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClinicPersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClinicPersonButton.Location = new System.Drawing.Point(530, 637);
            this.addClinicPersonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addClinicPersonButton.Name = "addClinicPersonButton";
            this.addClinicPersonButton.Size = new System.Drawing.Size(216, 58);
            this.addClinicPersonButton.TabIndex = 12;
            this.addClinicPersonButton.Text = "Add";
            this.addClinicPersonButton.UseVisualStyleBackColor = true;
            this.addClinicPersonButton.Click += new System.EventHandler(this.AddClinicPersonButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(728, 16);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(434, 44);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(170, 16);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(434, 44);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(754, 637);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(201, 58);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Label.Location = new System.Drawing.Point(6, 355);
            this.address2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(171, 37);
            this.address2Label.TabIndex = 56;
            this.address2Label.Text = "Address 2:";
            // 
            // NewClinicPersonUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.ssnErrorLabel);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.dobErrorLabel);
            this.Controls.Add(this.zipCodeErrorLabel);
            this.Controls.Add(this.stateErrorLabel);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.cityErrorLabel);
            this.Controls.Add(this.address1ErrorLabel);
            this.Controls.Add(this.genderErrorLabel);
            this.Controls.Add(this.lastNameErrorLabel);
            this.Controls.Add(this.firstNameErrorLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.dateTimePickerForDOB);
            this.Controls.Add(this.addClinicPersonButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.address2Label);
            this.Name = "NewClinicPersonUserControl";
            this.Size = new System.Drawing.Size(1230, 728);
            this.Load += new System.EventHandler(this.NewClinicPersonUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label ssnErrorLabel;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label dobErrorLabel;
        private System.Windows.Forms.Label zipCodeErrorLabel;
        private System.Windows.Forms.Label stateErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label cityErrorLabel;
        private System.Windows.Forms.Label address1ErrorLabel;
        private System.Windows.Forms.Label genderErrorLabel;
        private System.Windows.Forms.Label lastNameErrorLabel;
        private System.Windows.Forms.Label firstNameErrorLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerForDOB;
        private System.Windows.Forms.Button addClinicPersonButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label address2Label;
    }
}
