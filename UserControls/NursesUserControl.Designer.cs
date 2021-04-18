
namespace SmartClinic.UserControls
{
    partial class NursesUserControl
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
            this.searchMessageLabel = new System.Windows.Forms.Label();
            this.nursesGroupBox = new System.Windows.Forms.GroupBox();
            this.setCredentialsButton = new System.Windows.Forms.Button();
            this.nursesDataGridView = new System.Windows.Forms.DataGridView();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newNurseButton = new System.Windows.Forms.Button();
            this.appointmentSearchResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nurseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasCredentialsSetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nursesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nursesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchMessageLabel
            // 
            this.searchMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.searchMessageLabel.Location = new System.Drawing.Point(885, 20);
            this.searchMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchMessageLabel.Name = "searchMessageLabel";
            this.searchMessageLabel.Size = new System.Drawing.Size(268, 30);
            this.searchMessageLabel.TabIndex = 26;
            // 
            // nursesGroupBox
            // 
            this.nursesGroupBox.Controls.Add(this.searchMessageLabel);
            this.nursesGroupBox.Controls.Add(this.setCredentialsButton);
            this.nursesGroupBox.Controls.Add(this.nursesDataGridView);
            this.nursesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nursesGroupBox.Location = new System.Drawing.Point(3, 107);
            this.nursesGroupBox.Name = "nursesGroupBox";
            this.nursesGroupBox.Size = new System.Drawing.Size(1202, 661);
            this.nursesGroupBox.TabIndex = 23;
            this.nursesGroupBox.TabStop = false;
            this.nursesGroupBox.Text = "Nurses";
            // 
            // setCredentialsButton
            // 
            this.setCredentialsButton.AutoSize = true;
            this.setCredentialsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setCredentialsButton.Enabled = false;
            this.setCredentialsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCredentialsButton.Location = new System.Drawing.Point(725, 594);
            this.setCredentialsButton.Name = "setCredentialsButton";
            this.setCredentialsButton.Size = new System.Drawing.Size(444, 47);
            this.setCredentialsButton.TabIndex = 14;
            this.setCredentialsButton.Text = "Update Access Credentials";
            this.setCredentialsButton.UseVisualStyleBackColor = true;
            this.setCredentialsButton.Click += new System.EventHandler(this.SetCredentialsButton_Click);
            // 
            // nursesDataGridView
            // 
            this.nursesDataGridView.AllowUserToAddRows = false;
            this.nursesDataGridView.AllowUserToDeleteRows = false;
            this.nursesDataGridView.AutoGenerateColumns = false;
            this.nursesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nursesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nurseIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.hasCredentialsSetDataGridViewCheckBoxColumn});
            this.nursesDataGridView.DataSource = this.nurseBindingSource;
            this.nursesDataGridView.Location = new System.Drawing.Point(20, 53);
            this.nursesDataGridView.MultiSelect = false;
            this.nursesDataGridView.Name = "nursesDataGridView";
            this.nursesDataGridView.ReadOnly = true;
            this.nursesDataGridView.RowHeadersWidth = 82;
            this.nursesDataGridView.RowTemplate.Height = 33;
            this.nursesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nursesDataGridView.Size = new System.Drawing.Size(1160, 523);
            this.nursesDataGridView.TabIndex = 14;
            this.nursesDataGridView.SelectionChanged += new System.EventHandler(this.NursesDataGridView_SelectionChanged);
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataSource = typeof(SmartClinic.Model.Nurse);
            // 
            // newNurseButton
            // 
            this.newNurseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newNurseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNurseButton.Location = new System.Drawing.Point(23, 32);
            this.newNurseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newNurseButton.Name = "newNurseButton";
            this.newNurseButton.Size = new System.Drawing.Size(250, 47);
            this.newNurseButton.TabIndex = 24;
            this.newNurseButton.Text = "New Nurse";
            this.newNurseButton.UseVisualStyleBackColor = true;
            this.newNurseButton.Click += new System.EventHandler(this.NewNurseButton_Click);
            // 
            // appointmentSearchResultBindingSource
            // 
            this.appointmentSearchResultBindingSource.DataSource = typeof(SmartClinic.Model.AppointmentSearchResult);
            // 
            // nurseIdDataGridViewTextBoxColumn
            // 
            this.nurseIdDataGridViewTextBoxColumn.DataPropertyName = "NurseId";
            this.nurseIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.nurseIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nurseIdDataGridViewTextBoxColumn.Name = "nurseIdDataGridViewTextBoxColumn";
            this.nurseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hasCredentialsSetDataGridViewCheckBoxColumn
            // 
            this.hasCredentialsSetDataGridViewCheckBoxColumn.DataPropertyName = "HasCredentialsSet";
            this.hasCredentialsSetDataGridViewCheckBoxColumn.HeaderText = "Has Access Credentials";
            this.hasCredentialsSetDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.hasCredentialsSetDataGridViewCheckBoxColumn.Name = "hasCredentialsSetDataGridViewCheckBoxColumn";
            this.hasCredentialsSetDataGridViewCheckBoxColumn.ReadOnly = true;
            this.hasCredentialsSetDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hasCredentialsSetDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NursesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newNurseButton);
            this.Controls.Add(this.nursesGroupBox);
            this.Name = "NursesUserControl";
            this.Size = new System.Drawing.Size(1236, 791);
            this.Load += new System.EventHandler(this.NursesUserControl_Load);
            this.nursesGroupBox.ResumeLayout(false);
            this.nursesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nursesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentSearchResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label searchMessageLabel;
        private System.Windows.Forms.GroupBox nursesGroupBox;
        private System.Windows.Forms.Button setCredentialsButton;
        private System.Windows.Forms.DataGridView nursesDataGridView;
        private System.Windows.Forms.BindingSource appointmentSearchResultBindingSource;
        private System.Windows.Forms.Button newNurseButton;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasCredentialsSetDataGridViewCheckBoxColumn;
    }
}
