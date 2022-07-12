namespace hr_project.Forms
{
    partial class DepartamentsForm
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
            this.DepartmentsGridView = new System.Windows.Forms.DataGridView();
            this.DepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DapartmentNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddDepartmentButton = new System.Windows.Forms.Button();
            this.DepartmentAddingTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartmentsGridView
            // 
            this.DepartmentsGridView.AllowUserToAddRows = false;
            this.DepartmentsGridView.AllowUserToDeleteRows = false;
            this.DepartmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartmentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentId,
            this.Department});
            this.DepartmentsGridView.Location = new System.Drawing.Point(176, 12);
            this.DepartmentsGridView.Name = "DepartmentsGridView";
            this.DepartmentsGridView.RowTemplate.Height = 25;
            this.DepartmentsGridView.Size = new System.Drawing.Size(253, 308);
            this.DepartmentsGridView.TabIndex = 0;
            this.DepartmentsGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DepartmentsGridView_CellMouseClick);
            // 
            // DepartmentId
            // 
            this.DepartmentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartmentId.HeaderText = "DepartmentId";
            this.DepartmentId.Name = "DepartmentId";
            this.DepartmentId.Visible = false;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.ChangeButton);
            this.groupBox1.Controls.Add(this.DapartmentNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department name";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(19, 116);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(124, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(19, 87);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(124, 23);
            this.ChangeButton.TabIndex = 1;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DapartmentNameTextBox
            // 
            this.DapartmentNameTextBox.Location = new System.Drawing.Point(19, 44);
            this.DapartmentNameTextBox.Name = "DapartmentNameTextBox";
            this.DapartmentNameTextBox.Size = new System.Drawing.Size(124, 23);
            this.DapartmentNameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddDepartmentButton);
            this.groupBox2.Controls.Add(this.DepartmentAddingTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 143);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add";
            // 
            // AddDepartmentButton
            // 
            this.AddDepartmentButton.Location = new System.Drawing.Point(19, 65);
            this.AddDepartmentButton.Name = "AddDepartmentButton";
            this.AddDepartmentButton.Size = new System.Drawing.Size(124, 23);
            this.AddDepartmentButton.TabIndex = 1;
            this.AddDepartmentButton.Text = "Add";
            this.AddDepartmentButton.UseVisualStyleBackColor = true;
            this.AddDepartmentButton.Click += new System.EventHandler(this.AddDepartmentButton_Click);
            // 
            // DepartmentAddingTextBox
            // 
            this.DepartmentAddingTextBox.Location = new System.Drawing.Point(19, 22);
            this.DepartmentAddingTextBox.Name = "DepartmentAddingTextBox";
            this.DepartmentAddingTextBox.Size = new System.Drawing.Size(124, 23);
            this.DepartmentAddingTextBox.TabIndex = 0;
            // 
            // DepartamentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 324);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DepartmentsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DepartamentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Departaments";
            this.Load += new System.EventHandler(this.DepartamentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DepartmentsGridView;
        private DataGridViewTextBoxColumn DepartmentId;
        private DataGridViewTextBoxColumn Department;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button AddDepartmentButton;
        private TextBox DepartmentAddingTextBox;
        private Label label1;
        private Button DeleteButton;
        private Button ChangeButton;
        private TextBox DapartmentNameTextBox;
    }
}