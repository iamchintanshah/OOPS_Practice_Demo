using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
    public class IListVsIQueryable
    {
        public static void Main_IListVsIQueryable()
        {
            // IList Demo
            IList<string> strIList = new List<string> { "Chintan", "Jekin" };
            strIList.Insert(0, "Keval");

            var linqObj = (from item in strIList
                           where item.Contains("C")
                           select item);

            foreach (var item in linqObj)
            {
                Console.WriteLine(item);
            }

            // IQueryable Demo
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee(){ID = 1, FirstName = "James", LastName = "Male"},
                new Employee(){ID = 2, FirstName = "Sara", LastName = "Female"},
                new Employee(){ID = 3, FirstName = "Steve", LastName = "Male"},
                new Employee(){ID = 4, FirstName = "Pam", LastName = "Female"}
            };

            IQueryable<Employee> objEmployee = (from emp in employeeList
                                                where emp.ID > 2
                                                select emp).AsQueryable();

            foreach (var emp in objEmployee)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }


        }
    }


}
