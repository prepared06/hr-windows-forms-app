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
    public partial class EmployeeForm : Form
    {
        protected int _idEmployee;
        public EmployeeForm()
        {
            InitializeComponent();
        }
        public EmployeeForm(int idEmployee)
        {
            InitializeComponent();
            _idEmployee = idEmployee;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

            using (var context = new hrDBContext())
            {
                var employee = context.Employees.
                    Include(e => e.Department).
                    Include(e => e.JobTitle).
                    FirstOrDefault(x => x.Id==this._idEmployee);

                var allDepartments = context.Departments.ToList<Department>();
                var allPositions = context.Positions.ToList<Position>();

                foreach (var department in allDepartments)
                {
                    DepartmentComboBox.Items.Add(department.DepartmentName);
                }
                foreach(var position in allPositions)
                {
                    PositionComboBox.Items.Add(position.JobTitle);
                }

                if (employee == null)
                {
                    MessageBox.Show("something going wrong");
                    this.Close();
                }

                NameTextBox.Text = employee.Name;
                SurnameTextBox.Text = employee.Surname;
                MiddleNameTextBox.Text = employee.MiddleName;
                PhoneNumberTextBox.Text = employee.PhoneNumber;
                AddressTextBox.Text = employee.Address;
                SalaryTextBox.Text = employee.Salary.ToString();

                PositionComboBox.SelectedItem = employee.JobTitle.JobTitle;
                DepartmentComboBox.SelectedItem = employee.Department.DepartmentName;

                KPIValueComboBox.SelectedItem = employee.KPI.ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var context = new hrDBContext())
            {
                
                var position = context.
                    Positions.
                    FirstOrDefault(i=>i.JobTitle== PositionComboBox.SelectedItem.ToString());

                var department = context.
                    Departments.
                    FirstOrDefault(i=>i.DepartmentName== DepartmentComboBox.SelectedItem.ToString());
                
                var employee = new Employee()
                {
                    Id = this._idEmployee,
                    Name = NameTextBox.Text,
                    Surname = SurnameTextBox.Text,
                    MiddleName = MiddleNameTextBox.Text,
                    PhoneNumber = PhoneNumberTextBox.Text,
                    Address = AddressTextBox.Text,
                    Salary = (float)Convert.ToDouble(SalaryTextBox.Text),
                    JobTitle = position,
                    Department = department,
                    KPI = Convert.ToChar(KPIValueComboBox.SelectedItem)
                };

                context.Employees.Update(employee);
                context.SaveChanges();

                DialogResult = DialogResult.OK;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (var context = new hrDBContext())
            {
                var employee = context.Employees.
                   Include(e => e.Department).
                   Include(e => e.JobTitle).
                   FirstOrDefault(x => x.Id == this._idEmployee);

                context.Employees.Remove(employee);
                context.SaveChanges();

                DialogResult = DialogResult.OK;
            }
        }
    }
}
