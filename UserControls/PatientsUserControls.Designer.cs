
namespace SmartClinic.UserControls
{
    partial class PatientsUserControls
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
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.viewOrEditPatientDetailsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.dobSearchPicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameSearchLabel = new System.Windows.Forms.Label();
            this.dobSearchLabel = new System.Windows.Forms.Label();
            this.searchRulesLabel = new System.Windows.Forms.Label();
            this.searchForPatientsLabel = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.AllowUserToResizeRows = false;
            this.patientDataGridView.AutoGenerateColumns = false;
            this.patientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DateOfBirth,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.patientDataGridView.DataSource = this.patientBindingSource;
            this.patientDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.patientDataGridView.Location = new System.Drawing.Point(20, 19);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            this.patientDataGridView.RowHeadersWidth = 51;
            this.patientDataGridView.RowTemplate.Height = 24;
            this.patientDataGridView.Size = new System.Drawing.Size(955, 292);
            this.patientDataGridView.TabIndex = 1;
            this.patientDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRow_DoubleClick);
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePatientButton.Location = new System.Drawing.Point(811, 325);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(166, 35);
            this.deletePatientButton.TabIndex = 24;
            this.deletePatientButton.Text = "Delete Patient";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            // 
            // viewOrEditPatientDetailsButton
            // 
            this.viewOrEditPatientDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrEditPatientDetailsButton.Location = new System.Drawing.Point(556, 325);
            this.viewOrEditPatientDetailsButton.Name = "viewOrEditPatientDetailsButton";
            this.viewOrEditPatientDetailsButton.Size = new System.Drawing.Size(249, 35);
            this.viewOrEditPatientDetailsButton.TabIndex = 23;
            this.viewOrEditPatientDetailsButton.Text = "View / Edit Patient Details";
            this.viewOrEditPatientDetailsButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(428, 435);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(125, 35);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(428, 382);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(125, 35);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(137, 484);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(262, 30);
            this.lastNameTextBox.TabIndex = 20;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(137, 437);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(262, 30);
            this.firstNameTextBox.TabIndex = 19;
            // 
            // dobSearchPicker
            // 
            this.dobSearchPicker.Checked = false;
            this.dobSearchPicker.CustomFormat = "mm/dd/yyyy";
            this.dobSearchPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobSearchPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobSearchPicker.Location = new System.Drawing.Point(137, 387);
            this.dobSearchPicker.Name = "dobSearchPicker";
            this.dobSearchPicker.ShowCheckBox = true;
            this.dobSearchPicker.Size = new System.Drawing.Size(262, 30);
            this.dobSearchPicker.TabIndex = 18;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(19, 484);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 25);
            this.lastNameLabel.TabIndex = 17;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameSearchLabel
            // 
            this.firstNameSearchLabel.AutoSize = true;
            this.firstNameSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameSearchLabel.Location = new System.Drawing.Point(19, 437);
            this.firstNameSearchLabel.Name = "firstNameSearchLabel";
            this.firstNameSearchLabel.Size = new System.Drawing.Size(112, 25);
            this.firstNameSearchLabel.TabIndex = 16;
            this.firstNameSearchLabel.Text = "First Name:";
            // 
            // dobSearchLabel
            // 
            this.dobSearchLabel.AutoSize = true;
            this.dobSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobSearchLabel.Location = new System.Drawing.Point(70, 387);
            this.dobSearchLabel.Name = "dobSearchLabel";
            this.dobSearchLabel.Size = new System.Drawing.Size(61, 25);
            this.dobSearchLabel.TabIndex = 15;
            this.dobSearchLabel.Text = "DOB:";
            // 
            // searchRulesLabel
            // 
            this.searchRulesLabel.AutoSize = true;
            this.searchRulesLabel.Location = new System.Drawing.Point(21, 354);
            this.searchRulesLabel.Name = "searchRulesLabel";
            this.searchRulesLabel.Size = new System.Drawing.Size(378, 17);
            this.searchRulesLabel.TabIndex = 14;
            this.searchRulesLabel.Text = "Search by DOB, first and last name, or DOB and last name";
            // 
            // searchForPatientsLabel
            // 
            this.searchForPatientsLabel.AutoSize = true;
            this.searchForPatientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchForPatientsLabel.Location = new System.Drawing.Point(16, 325);
            this.searchForPatientsLabel.Name = "searchForPatientsLabel";
            this.searchForPatientsLabel.Size = new System.Drawing.Size(184, 25);
            this.searchForPatientsLabel.TabIndex = 13;
            this.searchForPatientsLabel.Text = "Search For Patients";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.FillWeight = 19F;
            this.DateOfBirth.HeaderText = "DOB";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.searchMessageLabel.Location = new System.Drawing.Point(134, 538);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(427, 23);
            this.searchMessageLabel.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientId";
            this.dataGridViewTextBoxColumn1.FillWeight = 15F;
            this.dataGridViewTextBoxColumn1.HeaderText = "PID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.FillWeight = 34.391F;
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.FillWeight = 34.391F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn5.FillWeight = 19F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Street1";
            this.dataGridViewTextBoxColumn6.FillWeight = 34.391F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Address 1";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Street2";
            this.dataGridViewTextBoxColumn7.FillWeight = 34.391F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Address 2";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn8.FillWeight = 34.391F;
            this.dataGridViewTextBoxColumn8.HeaderText = "City";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn9.FillWeight = 15F;
            this.dataGridViewTextBoxColumn9.HeaderText = "State";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(SmartClinic.Model.Patient);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Double-click in any row to view or edit a patient\'s details.";
            // 
            // PatientsUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchMessageLabel);
            this.Controls.Add(this.deletePatientButton);
            this.Controls.Add(this.viewOrEditPatientDetailsButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.dobSearchPicker);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameSearchLabel);
            this.Controls.Add(this.dobSearchLabel);
            this.Controls.Add(this.searchRulesLabel);
            this.Controls.Add(this.searchForPatientsLabel);
            this.Controls.Add(this.patientDataGridView);
            this.Name = "PatientsUserControls";
            this.Size = new System.Drawing.Size(996, 586);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.Button viewOrEditPatientDetailsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.DateTimePicker dobSearchPicker;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameSearchLabel;
        private System.Windows.Forms.Label dobSearchLabel;
        private System.Windows.Forms.Label searchRulesLabel;
        private System.Windows.Forms.Label searchForPatientsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.Label label1;
    }
}
