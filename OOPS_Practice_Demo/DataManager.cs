using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
    internal class Employee
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int DepartmentId { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }

    internal class Department
    {
        public int ID { get; set; }
        public string? DepartmentName { get; set; }
    }

    internal static class DataManager
    {
        internal static List<Employee> GetData()
        {
            return new List<Employee>
            {
                new Employee { ID = 1, FirstName = "John", LastName = "Smith", Age = 35, DepartmentId = 1 , Salary = 25000},
                new Employee { ID = 2, FirstName = "Ava", LastName = "Jones", Age = 35, DepartmentId = 1 , Salary = 27500},
                new Employee { ID = 3, FirstName = "William", LastName = "Brown", Age = 22, DepartmentId = 3 , Salary = 25500},
                new Employee { ID = 4, FirstName = "Lily", LastName = "Miller", Age = 26, DepartmentId = 4 , Salary = 23500},
                new Employee { ID = 5, FirstName = "Emily", LastName = "Jones", Age = 35, DepartmentId = 2 , Salary = 28000},
                new Employee { ID = 6, FirstName = "Jabob", LastName = "Miller", Age = 36, DepartmentId = 2, Salary = 55000},
                new Employee { ID = 7, FirstName = "John", LastName = "Brown", Age = 30, DepartmentId = 1 , Salary = 26500},
                new Employee { ID = 8, FirstName = "John", LastName = "Smith", Age = 33, DepartmentId = 4 , Salary = 45000}
            };
        }

        internal static List<Department> GetDepartment()
        {
            return new List<Department>
            {
                new Department { ID = 1, DepartmentName = "IT"},
                new Department { ID = 2, DepartmentName = "Management"},
                new Department { ID = 3, DepartmentName = "Finance"},
                new Department { ID = 4, DepartmentName = "Marketing"},
            };
        }
    }
}
