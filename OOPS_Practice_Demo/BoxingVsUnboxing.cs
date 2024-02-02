using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
    internal class BoxingVsUnboxing
    {
        public static void Main_BoxingVsUnboxing(string[] args)
        {
            int num = 100;
            object obj = num; // Boxing
            Console.WriteLine("Boxing {0}", obj);

            int i = (int)obj; // Unboxing
            Console.WriteLine("UnBoxing {0}", i);
        }
    }
}
