using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Addition(out i);
            Console.WriteLine("Out param i value is {0}", i);
        }

        public static void Addition(out int i)
        {
            i = 30;
            i += 8;
        }
    }
}
