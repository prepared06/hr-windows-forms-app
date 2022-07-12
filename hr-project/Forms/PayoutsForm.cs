using hr_project.Data;
using hr_project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hr_project.Forms
{
    public partial class PayoutsForm : Form
    {
        public PayoutsForm()
        {
            InitializeComponent();
        }
        private void outSalarySum(string category)
        {
            using (var context = new hrDBContext())
            {
                decimal salarySum = 0;
                decimal premiumSum = 0;
                List<Employee> employees = null;

                if (category == "All")
                {
                    employees = context.Employees.ToList<Employee>();
                }
                else
                {
                    employees = context.Employees.Include(i=>i.Department).
                    Where(i=>i.Department.DepartmentName == category).ToList<Employee>();
                }
                foreach (var employee in employees)
                {
                    salarySum += (decimal)employee.Salary;
                    switch (employee.KPI)
                    {
                        case 'A':
                            premiumSum += salarySum - (salarySum * 20 / 100);
                            break;
                        case 'B':
                            premiumSum += salarySum - (salarySum * 30 / 100);
                            break;
                        case 'C':
                            premiumSum += salarySum - (salarySum * 40 / 100);
                            break;
                    }
                }
                SumLabel.Text = "$ " + salarySum.ToString();
                AmountBonusesLabel.Text = "$" + premiumSum.ToString();
                SumBonusesAndSalLabel.Text = "$" + (salarySum + premiumSum).ToString();
            }
            
        }
        private void PayoutsForm_Load(object sender, EventArgs e)
        {
            using (var context = new hrDBContext())
            {
                DepartmentComboBox.Items.Clear();

                var allDepartments = context.Departments.
                    ToList<Department>();

                DepartmentComboBox.Items.Add("All");
                DepartmentComboBox.SelectedItem = "All";

                outSalarySum("All");

                foreach (var department in allDepartments)
                {
                    DepartmentComboBox.Items.Add(department.DepartmentName);
                }
            }
        }

        private void departmentComboBox_TextChanged(object sender, EventArgs e)
        {
            outSalarySum(DepartmentComboBox.SelectedItem.ToString());
        }
    }
}
