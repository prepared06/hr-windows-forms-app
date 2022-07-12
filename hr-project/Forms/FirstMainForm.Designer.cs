namespace hr_project
{
    partial class FirstMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainDataOutGrid = new System.Windows.Forms.DataGridView();
            this.IdEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonuses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmentsFormButton = new System.Windows.Forms.Button();
            this.PositionsFormButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.PayoutsButton = new System.Windows.Forms.Button();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataOutGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDataOutGrid
            // 
            this.MainDataOutGrid.AllowUserToAddRows = false;
            this.MainDataOutGrid.AllowUserToDeleteRows = false;
            this.MainDataOutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataOutGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmployee,
            this.Name,
            this.Surname,
            this.MiddleName,
            this.PhoneNumber,
            this.Address,
            this.Salary,
            this.Position,
            this.Department,
            this.KPI,
            this.Bonuses});
            this.MainDataOutGrid.Location = new System.Drawing.Point(160, 27);
            this.MainDataOutGrid.Name = "MainDataOutGrid";
            this.MainDataOutGrid.RowTemplate.Height = 25;
            this.MainDataOutGrid.Size = new System.Drawing.Size(959, 435);
            this.MainDataOutGrid.TabIndex = 1;
            this.MainDataOutGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataOutGrid_CellDoubleClick);
            // 
            // IdEmployee
            // 
            this.IdEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdEmployee.HeaderText = "IdEmployee";
            this.IdEmployee.Name = "IdEmployee";
            this.IdEmployee.ReadOnly = true;
            this.IdEmployee.Visible = false;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // KPI
            // 
            this.KPI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KPI.HeaderText = "KPI";
            this.KPI.Name = "KPI";
            this.KPI.ReadOnly = true;
            // 
            // Bonuses
            // 
            this.Bonuses.HeaderText = "Bonuses";
            this.Bonuses.Name = "Bonuses";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(12, 46);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(121, 23);
            this.departmentComboBox.TabIndex = 2;
            this.departmentComboBox.TextChanged += new System.EventHandler(this.departmentComboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter by Departament";
            // 
            // DepartmentsFormButton
            // 
            this.DepartmentsFormButton.Location = new System.Drawing.Point(12, 98);
            this.DepartmentsFormButton.Name = "DepartmentsFormButton";
            this.DepartmentsFormButton.Size = new System.Drawing.Size(121, 23);
            this.DepartmentsFormButton.TabIndex = 4;
            this.DepartmentsFormButton.Text = "Departments";
            this.DepartmentsFormButton.UseVisualStyleBackColor = true;
            this.DepartmentsFormButton.Click += new System.EventHandler(this.DepartmentFormsButton_Click);
            // 
            // PositionsFormButton
            // 
            this.PositionsFormButton.Location = new System.Drawing.Point(12, 127);
            this.PositionsFormButton.Name = "PositionsFormButton";
            this.PositionsFormButton.Size = new System.Drawing.Size(121, 23);
            this.PositionsFormButton.TabIndex = 5;
            this.PositionsFormButton.Text = "Positions";
            this.PositionsFormButton.UseVisualStyleBackColor = true;
            this.PositionsFormButton.Click += new System.EventHandler(this.PositionsFormButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(12, 156);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(121, 23);
            this.AddEmployeeButton.TabIndex = 6;
            this.AddEmployeeButton.Text = "Add employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // PayoutsButton
            // 
            this.PayoutsButton.Location = new System.Drawing.Point(12, 185);
            this.PayoutsButton.Name = "PayoutsButton";
            this.PayoutsButton.Size = new System.Drawing.Size(121, 23);
            this.PayoutsButton.TabIndex = 7;
            this.PayoutsButton.Text = "Payouts";
            this.PayoutsButton.UseVisualStyleBackColor = true;
            this.PayoutsButton.Click += new System.EventHandler(this.PayoutsButton_Click);
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Location = new System.Drawing.Point(12, 214);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(121, 23);
            this.GenerateReportButton.TabIndex = 8;
            this.GenerateReportButton.Text = "Generate report";
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // FirstMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 465);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.PayoutsButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.PositionsFormButton);
            this.Controls.Add(this.DepartmentsFormButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.MainDataOutGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //this.Name = "FirstMainForm";
            this.Load += new System.EventHandler(this.Loading);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataOutGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView MainDataOutGrid;
        private ComboBox departmentComboBox;
        private Label label1;
        private Button DepartmentsFormButton;
        private Button PositionsFormButton;
        private Button AddEmployeeButton;
        private Button PayoutsButton;
        private Button GenerateReportButton;
        private SaveFileDialog saveFileDialog1;
        private DataGridViewTextBoxColumn IdEmployee;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn MiddleName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn KPI;
        private DataGridViewTextBoxColumn Bonuses;
    }
}