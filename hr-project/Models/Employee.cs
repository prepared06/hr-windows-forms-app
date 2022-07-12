using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_project.Models
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public float Salary { get; set; }
        public char KPI { get; set; }

        //one employee has one position
        public int CurrentJobTitleId { get; set; }
        public Position JobTitle { get; set; }

        //one employee has one department
        public int CurrentDepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
