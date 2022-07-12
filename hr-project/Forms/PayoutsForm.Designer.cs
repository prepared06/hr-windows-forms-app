namespace hr_project.Forms
{
    partial class PayoutsForm
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
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SumBonusesAndSalLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountBonusesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(69, 37);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(133, 23);
            this.DepartmentComboBox.TabIndex = 1;
            this.DepartmentComboBox.TextChanged += new System.EventHandler(this.departmentComboBox_TextChanged);
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(225, 40);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(0, 15);
            this.SumLabel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SumBonusesAndSalLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AmountBonusesLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DepartmentComboBox);
            this.groupBox1.Controls.Add(this.SumLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "The amount of money set aside for the salaries of all employees";
            // 
            // SumBonusesAndSalLabel
            // 
            this.SumBonusesAndSalLabel.AutoSize = true;
            this.SumBonusesAndSalLabel.Location = new System.Drawing.Point(199, 100);
            this.SumBonusesAndSalLabel.Name = "SumBonusesAndSalLabel";
            this.SumBonusesAndSalLabel.Size = new System.Drawing.Size(0, 15);
            this.SumBonusesAndSalLabel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sum of bonuses and salaries";
            // 
            // AmountBonusesLabel
            // 
            this.AmountBonusesLabel.AutoSize = true;
            this.AmountBonusesLabel.Location = new System.Drawing.Point(173, 76);
            this.AmountBonusesLabel.Name = "AmountBonusesLabel";
            this.AmountBonusesLabel.Size = new System.Drawing.Size(0, 15);
            this.AmountBonusesLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "The amount of bonuses ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "In";
            // 
            // PayoutsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 151);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PayoutsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payouts";
            this.Load += new System.EventHandler(this.PayoutsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox DepartmentComboBox;
        private Label SumLabel;
        private GroupBox groupBox1;
        private Label label1;
        private Label AmountBonusesLabel;
        private Label label2;
        private Label SumBonusesAndSalLabel;
        private Label label3;
    }
}