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
    public partial class DepartamentsForm : Form
    {
        private int? _idDepartment=null;
        public DepartamentsForm()
        {
            InitializeComponent();
        }

        private void DepartamentsForm_Load(object sender, EventArgs e)
        {
            using (var context = new hrDBContext())
            {
                var departments = context.Departments.ToList<Department>();

                DepartmentsGridView.Rows.Clear();

                foreach (var department in departments)
                {
                    string[] dataOut =
                    {
                        department.Id.ToString(),
                        department.DepartmentName
                    };
                    DepartmentsGridView.Rows.Add(dataOut);
                }
            }
        }

        private void AddDepartmentButton_Click(object sender, EventArgs e)
        {
            if(DepartmentAddingTextBox.Text=="")
            {
                MessageBox.Show("Enter some name of department before adding");
                return;
            }
            using (var context = new hrDBContext())
            {
                Department department = new Department()
                {
                    DepartmentName = DepartmentAddingTextBox.Text
                };

                context.Departments.Add(department);
                context.SaveChanges();

                DepartamentsForm_Load(sender, e);  
            }
        }

        private void DepartmentsGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            _idDepartment = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

            DapartmentNameTextBox.Text= Convert.ToString(dgv.CurrentRow.Cells[1].Value);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if(_idDepartment is null)
            {
                MessageBox.Show("Pick some departmet in grid");
                return;
            }

            using (var context = new hrDBContext())
            {
                var department = context.
                    Departments.FirstOrDefault(i => i.Id == _idDepartment); 

                department.DepartmentName = DapartmentNameTextBox.Text;

                context.Departments.Update(department);
                context.SaveChanges();

                DepartamentsForm_Load(sender,e);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_idDepartment is null)
            {
                MessageBox.Show("Pick some departmet in grid");
                return;
            }
            using (var context = new hrDBContext())
            {
                var department = context.
                    Departments.FirstOrDefault(i => i.Id == _idDepartment);

                context.Departments.Remove(department);
                context.SaveChanges();

                DapartmentNameTextBox.Text = "";
                _idDepartment = null;

                DepartamentsForm_Load(sender, e);
            }
        }
    }
}
