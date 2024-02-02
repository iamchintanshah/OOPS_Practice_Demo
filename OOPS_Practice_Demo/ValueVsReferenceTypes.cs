using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
    internal class ValueVsReferenceTypes
    {
        public static void Main_ValueVsReferenceTypes(string[] args)
        {
            //IEnumerable<int> result = from value in Enumerable.Range(1, 5)
            //                          select value;

            //foreach (int item in result)
            //{
            //    Console.WriteLine($"Ienumerable: {item}");
            //}

            // Reference types example
            Employee emp1 = new Employee();
            emp1.FirstName = "Chintan";

            Employee emp2 = emp1;
            emp2.FirstName = "Niva";

            Console.WriteLine(emp1.FirstName); // It will print Niva instead of Chintan as

            // Value types example
            int a = 5;
            int b = a;
            b = 10;

            Console.WriteLine("a=> {0}", a);

        }
    }
}
