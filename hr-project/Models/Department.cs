using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_project.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        //one department has many employees
        public ICollection<Employee> Employees { get; set; }
    }
}
