using hr_project.Data;
using hr_project.Models;
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
    public partial class EmployeeAddForm : Form
    {
        public EmployeeAddForm()
        {
            InitializeComponent();

            using (var context = new hrDBContext())
            {
                var allDepartments = context.Departments.ToList<Department>();
                var allPositions = context.Positions.ToList<Position>();

                foreach (var department in allDepartments)
                {
                    DepartmentComboBox.Items.Add(department.DepartmentName);
                }
                DepartmentComboBox.SelectedItem = allDepartments[0].DepartmentName;
                foreach (var position in allPositions)
                {
                    PositionComboBox.Items.Add(position.JobTitle);
                }
                PositionComboBox.SelectedItem = allPositions[0].JobTitle;
                KPIValueComboBox.SelectedItem = "A";
            }  
        }

        private void SaveEmployeeButton_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text =="" ||
               SurnameTextBox.Text =="" ||
               MiddleNameTextBox.Text=="" ||
               PhoneNumberTextBox.Text == "" ||
               AddressTextBox.Text == "" ||
               SalaryTextBox.Text == "") 
            {
                MessageBox.Show("Put correct data please");
                return;
            }

            using (var context = new hrDBContext())
            {
                var position = context.
                    Positions.
                    FirstOrDefault(i => i.JobTitle == PositionComboBox.SelectedItem.ToString());

                var department = context.
                    Departments.
                    FirstOrDefault(i => i.DepartmentName == DepartmentComboBox.SelectedItem.ToString());

                Employee newEmployee = new Employee()
                {
                    Name = NameTextBox.Text,
                    Surname = SurnameTextBox.Text,
                    MiddleName = SurnameTextBox.Text,
                    PhoneNumber = PhoneNumberTextBox.Text,
                    Address = AddressTextBox.Text,
                    Salary = (float)Convert.ToDouble(SalaryTextBox.Text),
                    Department = department,
                    JobTitle = position,
                    KPI = Convert.ToChar(KPIValueComboBox.SelectedItem)
                };

                context.Employees.Add(newEmployee);
                context.SaveChanges();

                DialogResult = DialogResult.OK;
            }
        }
    }
}
