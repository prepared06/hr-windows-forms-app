namespace hr_project.Forms
{
    partial class PositionsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.PositionNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddPositionButton = new System.Windows.Forms.Button();
            this.PositionAddingTextBox = new System.Windows.Forms.TextBox();
            this.PositionsGridView = new System.Windows.Forms.DataGridView();
            this.PositionsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.ChangeButton);
            this.groupBox1.Controls.Add(this.PositionNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 159);
            this.groupBox1.TabIndex = 2;
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
            // PositionNameTextBox
            // 
            this.PositionNameTextBox.Location = new System.Drawing.Point(19, 44);
            this.PositionNameTextBox.Name = "PositionNameTextBox";
            this.PositionNameTextBox.Size = new System.Drawing.Size(124, 23);
            this.PositionNameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddPositionButton);
            this.groupBox2.Controls.Add(this.PositionAddingTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 143);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add";
            // 
            // AddPositionButton
            // 
            this.AddPositionButton.Location = new System.Drawing.Point(19, 65);
            this.AddPositionButton.Name = "AddPositionButton";
            this.AddPositionButton.Size = new System.Drawing.Size(124, 23);
            this.AddPositionButton.TabIndex = 1;
            this.AddPositionButton.Text = "Add";
            this.AddPositionButton.UseVisualStyleBackColor = true;
            this.AddPositionButton.Click += new System.EventHandler(this.AddPositionButton_Click);
            // 
            // PositionAddingTextBox
            // 
            this.PositionAddingTextBox.Location = new System.Drawing.Point(19, 22);
            this.PositionAddingTextBox.Name = "PositionAddingTextBox";
            this.PositionAddingTextBox.Size = new System.Drawing.Size(124, 23);
            this.PositionAddingTextBox.TabIndex = 0;
            // 
            // PositionsGridView
            // 
            this.PositionsGridView.AllowUserToAddRows = false;
            this.PositionsGridView.AllowUserToDeleteRows = false;
            this.PositionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PositionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PositionsId,
            this.Position});
            this.PositionsGridView.Location = new System.Drawing.Point(176, 12);
            this.PositionsGridView.Name = "PositionsGridView";
            this.PositionsGridView.RowTemplate.Height = 25;
            this.PositionsGridView.Size = new System.Drawing.Size(253, 308);
            this.PositionsGridView.TabIndex = 2;
            this.PositionsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PositionsGridView_CellClick);
            // 
            // PositionsId
            // 
            this.PositionsId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PositionsId.HeaderText = "PositionstId";
            this.PositionsId.Name = "PositionsId";
            this.PositionsId.Visible = false;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // PositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 321);
            this.Controls.Add(this.PositionsGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PositionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Positions";
            this.Load += new System.EventHandler(this.PositionsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PositionsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button DeleteButton;
        private Button ChangeButton;
        private TextBox PositionNameTextBox;
        private GroupBox groupBox2;
        private Button AddPositionButton;
        private TextBox PositionAddingTextBox;
        private DataGridView PositionsGridView;
        private DataGridViewTextBoxColumn PositionsId;
        private DataGridViewTextBoxColumn Position;
    }
}