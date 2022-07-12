using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hr_project.Models;

namespace hr_project.Data
{
    public static class DbInitializer
    {
        public static void Initialize()
        {
            using (var context = new hrDBContext()) 
            {
                if (context.Employees.Any()
                && context.Departments.Any()
                && context.Positions.Any())
                {
                    return;   // DB has been seeded
                }

                //init departments
                Department ITDepartment = new Department()
                {
                    DepartmentName="IT",
                    Employees=new List<Employee>()
                };
                Department Reserch = new Department()
                {
                    DepartmentName = "Reserch",
                    Employees = new List<Employee>()
                };
                Department HR = new Department()
                {
                    DepartmentName = "HR",
                    Employees = new List<Employee>()
                };
                Department Bookkeeper = new Department()
                {
                    DepartmentName = "Bookkeeper",
                    Employees = new List<Employee>()
                };
                //init positions

                Position BookkeeperSenior = new Position()
                {
                    JobTitle = "Bookkeeper Senior",
                    Employees = new List<Employee>()
                };
                
                Position HRSenior = new Position()
                {
                    JobTitle = "HR senior",
                    Employees = new List<Employee>()
                };
                Position HRJunior = new Position()
                {
                    JobTitle = "HR Junior",
                    Employees = new List<Employee>()
                };
                //init employees
                Employee AshleyJohnson = new Employee()
                {
                    Name = "Ashley",
                    MiddleName = "Alicia",
                    Surname = "Johnson",
                    PhoneNumber = "1 888-452-1505",
                    Address = "751 Midway Rd SE",
                    Salary=4000,
                    KPI ='C',
                    JobTitle= HRJunior,
                    Department=HR
                };
                Employee NatalieJenkins = new Employee()
                {
                    Name = "Natalie",
                    MiddleName = "Brenda",
                    Surname = "Jenkins",
                    PhoneNumber = "1 888-452-1505",
                    Address = "3416 159th St Urbandale, Iowa",
                    Salary = 6000,
                    KPI = 'A',
                    JobTitle = BookkeeperSenior,
                    Department = Bookkeeper
                };

                context.Employees.Add(AshleyJohnson);
                context.Employees.Add(NatalieJenkins);

                context.Positions.Add(BookkeeperSenior);
                context.Positions.Add(HRSenior);
                context.Positions.Add(HRJunior);

                context.Departments.Add(ITDepartment);
                context.Departments.Add(Reserch);
                context.Departments.Add(HR);
                context.Departments.Add(Bookkeeper);

                context.SaveChanges();
            }
        }
    }
}
