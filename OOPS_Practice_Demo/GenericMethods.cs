using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
    internal class GenericMethods
    {
        public static void Main_GenericMethods(string[] args)
        {
            Console.WriteLine(Sum(5, 6.5));
            Console.WriteLine(Sum(4.5, 6.5));
            Console.WriteLine(Sum("Niva", " Shah"));
        }

        public static T Sum<T>(T data1, T data2)
        {
            dynamic a = data1;
            dynamic b = data2;
            return a + b;
        }
    }





}
