
namespace SmartClinic.UserControls
{
    partial class PatientVisitsUserControl
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
            this.rightClickToDeleteLabel = new System.Windows.Forms.Label();
            this.doubleClickOptionToViewPatientLabel = new System.Windows.Forms.Label();
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.viewOrEditPatientDetailsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.dobSearchPicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameSearchLabel = new System.Windows.Forms.Label();
            this.dobSearchLabel = new System.Windows.Forms.Label();
            this.searchRulesLabel = new System.Windows.Forms.Label();
            this.searchForPatientsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rightClickToDeleteLabel
            // 
            this.rightClickToDeleteLabel.AutoSize = true;
            this.rightClickToDeleteLabel.Location = new System.Drawing.Point(49, 440);
            this.rightClickToDeleteLabel.Name = "rightClickToDeleteLabel";
            this.rightClickToDeleteLabel.Size = new System.Drawing.Size(245, 17);
            this.rightClickToDeleteLabel.TabIndex = 44;
            this.rightClickToDeleteLabel.Text = "Right-click any row for \'Delete\' option.";
            // 
            // doubleClickOptionToViewPatientLabel
            // 
            this.doubleClickOptionToViewPatientLabel.AutoSize = true;
            this.doubleClickOptionToViewPatientLabel.Location = new System.Drawing.Point(49, 409);
            this.doubleClickOptionToViewPatientLabel.Name = "doubleClickOptionToViewPatientLabel";
            this.doubleClickOptionToViewPatientLabel.Size = new System.Drawing.Size(347, 17);
            this.doubleClickOptionToViewPatientLabel.TabIndex = 43;
            this.doubleClickOptionToViewPatientLabel.Text = "Double-click any row to view or edit a patient\'s details.";
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.searchMessageLabel.Location = new System.Drawing.Point(134, 206);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(262, 19);
            this.searchMessageLabel.TabIndex = 42;
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientButton.Location = new System.Drawing.Point(811, 532);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(166, 35);
            this.deletePatientButton.TabIndex = 41;
            this.deletePatientButton.Text = "Delete Patient";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            // 
            // viewOrEditPatientDetailsButton
            // 
            this.viewOrEditPatientDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrEditPatientDetailsButton.Location = new System.Drawing.Point(556, 532);
            this.viewOrEditPatientDetailsButton.Name = "viewOrEditPatientDetailsButton";
            this.viewOrEditPatientDetailsButton.Size = new System.Drawing.Size(249, 35);
            this.viewOrEditPatientDetailsButton.TabIndex = 40;
            this.viewOrEditPatientDetailsButton.Text = "View / Edit Patient Details";
            this.viewOrEditPatientDetailsButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(271, 228);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 35);
            this.clearButton.TabIndex = 39;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(134, 228);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(125, 35);
            this.searchButton.TabIndex = 38;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(134, 171);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(262, 30);
            this.lastNameTextBox.TabIndex = 37;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(134, 124);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(262, 30);
            this.firstNameTextBox.TabIndex = 36;
            // 
            // dobSearchPicker
            // 
            this.dobSearchPicker.Checked = false;
            this.dobSearchPicker.CustomFormat = "mm/dd/yyyy";
            this.dobSearchPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobSearchPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobSearchPicker.Location = new System.Drawing.Point(134, 78);
            this.dobSearchPicker.Name = "dobSearchPicker";
            this.dobSearchPicker.ShowCheckBox = true;
            this.dobSearchPicker.Size = new System.Drawing.Size(262, 30);
            this.dobSearchPicker.TabIndex = 35;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(16, 171);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 25);
            this.lastNameLabel.TabIndex = 34;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameSearchLabel
            // 
            this.firstNameSearchLabel.AutoSize = true;
            this.firstNameSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameSearchLabel.Location = new System.Drawing.Point(16, 124);
            this.firstNameSearchLabel.Name = "firstNameSearchLabel";
            this.firstNameSearchLabel.Size = new System.Drawing.Size(112, 25);
            this.firstNameSearchLabel.TabIndex = 33;
            this.firstNameSearchLabel.Text = "First Name:";
            // 
            // dobSearchLabel
            // 
            this.dobSearchLabel.AutoSize = true;
            this.dobSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobSearchLabel.Location = new System.Drawing.Point(67, 78);
            this.dobSearchLabel.Name = "dobSearchLabel";
            this.dobSearchLabel.Size = new System.Drawing.Size(61, 25);
            this.dobSearchLabel.TabIndex = 32;
            this.dobSearchLabel.Text = "DOB:";
            // 
            // searchRulesLabel
            // 
            this.searchRulesLabel.AutoSize = true;
            this.searchRulesLabel.Location = new System.Drawing.Point(18, 45);
            this.searchRulesLabel.Name = "searchRulesLabel";
            this.searchRulesLabel.Size = new System.Drawing.Size(378, 17);
            this.searchRulesLabel.TabIndex = 31;
            this.searchRulesLabel.Text = "Search by DOB, first and last name, or DOB and last name";
            // 
            // searchForPatientsLabel
            // 
            this.searchForPatientsLabel.AutoSize = true;
            this.searchForPatientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForPatientsLabel.Location = new System.Drawing.Point(13, 16);
            this.searchForPatientsLabel.Name = "searchForPatientsLabel";
            this.searchForPatientsLabel.Size = new System.Drawing.Size(184, 25);
            this.searchForPatientsLabel.TabIndex = 30;
            this.searchForPatientsLabel.Text = "Search For Patients";
            // 
            // PatientVisitsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rightClickToDeleteLabel);
            this.Controls.Add(this.doubleClickOptionToViewPatientLabel);
            this.Controls.Add(this.searchMessageLabel);
            this.Controls.Add(this.deletePatientButton);
            this.Controls.Add(this.viewOrEditPatientDetailsButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.dobSearchPicker);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameSearchLabel);
            this.Controls.Add(this.dobSearchLabel);
            this.Controls.Add(this.searchRulesLabel);
            this.Controls.Add(this.searchForPatientsLabel);
            this.Name = "PatientVisitsUserControl";
            this.Size = new System.Drawing.Size(996, 586);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rightClickToDeleteLabel;
        private System.Windows.Forms.Label doubleClickOptionToViewPatientLabel;
        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.Button viewOrEditPatientDetailsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.DateTimePicker dobSearchPicker;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameSearchLabel;
        private System.Windows.Forms.Label dobSearchLabel;
        private System.Windows.Forms.Label searchRulesLabel;
        private System.Windows.Forms.Label searchForPatientsLabel;
    }
}
