using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hr_project.Models
{
    internal class Position
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        //one position has many employees
        public ICollection<Employee> Employees { get; set; }
    }
}
