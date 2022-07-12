using hr_project.Data;
using hr_project.Forms;
using hr_project.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text;

namespace hr_project
{
    public partial class FirstMainForm : Form
    {
        public FirstMainForm()
        {
            InitializeComponent();
        }
        private string getPremium(char KPI, float salary)
        {
            switch (KPI)
            {
                case 'A':
                    return (salary-(salary*20/100)).ToString();
                case 'B':
                    return (salary - (salary * 30 / 100)).ToString();
                case 'C':
                    return (salary - (salary * 40 / 100)).ToString();
                default:return "0";
            }
        }
        private void populateMainDataGrid()
        {
            MainDataOutGrid.Rows.Clear();
            MainDataOutGrid.AutoGenerateColumns = false;

            using (var context = new hrDBContext())
            {
                var allEmployees = context.Employees.
                    Include(e => e.Department).
                    Include(e => e.JobTitle).
                    ToList<Employee>();

                for (int i = 0; i < allEmployees.Count; i++)
                {
                    string[] row = {
                    allEmployees[i].Id.ToString(),
                    allEmployees[i].Name,
                    allEmployees[i].Surname,
                    allEmployees[i].MiddleName,
                    allEmployees[i].PhoneNumber,
                    allEmployees[i].Address,
                    "$"+allEmployees[i].Salary.ToString(),
                    allEmployees[i].JobTitle.JobTitle,
                    allEmployees[i].Department.DepartmentName,
                    allEmployees[i].KPI.ToString(),
                    "$"+getPremium(allEmployees[i].KPI,allEmployees[i].Salary)
                    };
                    MainDataOutGrid.Rows.Add(row);
                }
            }
        }
        private void populateDepartmentComboBox()
        {
            using (var context = new hrDBContext())
            {
                departmentComboBox.Items.Clear();

                var allDepartments = context.Departments.ToList<Department>();

                departmentComboBox.Items.Add("All");
                departmentComboBox.SelectedItem = "All";

                foreach (var department in allDepartments)
                {
                    departmentComboBox.Items.Add(department.DepartmentName);
                }
            }   
        }
        private void Loading(object sender, EventArgs e)
        {
            populateMainDataGrid();
            populateDepartmentComboBox();
        }

        private void departmentComboBox_TextChanged(object sender, EventArgs e)
        {
            string tag = departmentComboBox.SelectedItem.ToString();
            if(tag == "All")
            {
                populateMainDataGrid();
                return;
            }
            using (var context = new hrDBContext())
            {
                var selectedByDeparments = context.Employees.
                    Include(e => e.Department).
                    Include(e => e.JobTitle).Where(x=>x.Department.DepartmentName==tag).
                    ToList<Employee>();

                MainDataOutGrid.Rows.Clear();

                for (int i = 0; i < selectedByDeparments.Count; i++)
                {
                    string[] row = {
                    selectedByDeparments[i].Id.ToString(),
                    selectedByDeparments[i].Name,
                    selectedByDeparments[i].Surname,
                    selectedByDeparments[i].MiddleName,
                    selectedByDeparments[i].PhoneNumber,
                    selectedByDeparments[i].Address,
                    selectedByDeparments[i].Salary.ToString(),
                    selectedByDeparments[i].JobTitle.JobTitle,
                    selectedByDeparments[i].Department.DepartmentName,
                    selectedByDeparments[i].KPI.ToString()
                    };
                    MainDataOutGrid.Rows.Add(row);
                }
            }

        }

        private void MainDataOutGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            
            var idEmployee=Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

            EmployeeForm employeeForm = new EmployeeForm(idEmployee);

            if (DialogResult.OK == employeeForm.ShowDialog())
            {
                populateMainDataGrid();
                populateDepartmentComboBox();
            }
            
        }

        private void DepartmentFormsButton_Click(object sender, EventArgs e)
        {
            DepartamentsForm departamentsForm = new DepartamentsForm();

            departamentsForm.ShowDialog();
            populateMainDataGrid();
            populateDepartmentComboBox();
            
        }

        private void PositionsFormButton_Click(object sender, EventArgs e)
        {
            PositionsForm positionsForm = new PositionsForm();

            positionsForm.ShowDialog();
            populateMainDataGrid();
            populateDepartmentComboBox();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeAddForm employeeAddForm = new EmployeeAddForm();

            if (DialogResult.OK == employeeAddForm.ShowDialog())
            {
                populateMainDataGrid();
                populateDepartmentComboBox();
            } 
        }

        private void PayoutsButton_Click(object sender, EventArgs e)
        {
            PayoutsForm payoutsForm = new PayoutsForm();
            payoutsForm.ShowDialog();
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {     
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Word document (*.doc)|*.doc|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    for(int i=0;i<MainDataOutGrid.Rows.Count;i++)
                    {
                        for(int j = 0; j < MainDataOutGrid.Rows[i].Cells.Count; j++)
                        {
                            string data = MainDataOutGrid.Columns[j].Name + ": " + 
                                MainDataOutGrid.Rows[i].Cells[j].Value.ToString()+"\n";
                            byte[] buffer = Encoding.Default.
                                GetBytes(data);
                            myStream.Write(buffer, 0, buffer.Length);
                        }
                        byte[] ending = Encoding.Default.
                                GetBytes("\n");
                        myStream.Write(ending, 0, ending.Length);
                    }

                    myStream.Close();
                    MessageBox.Show("Report has been generated");
                }
            }
        }
    }
}