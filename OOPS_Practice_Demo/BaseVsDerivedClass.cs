using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
    class BaseVsDerivedClass
    {
        public static void Main_BaseVsDerivedClass(String[] args)
        {
            //BaseClass objBase = new BaseClass();
            ChildClass objDerived = new ChildClass();
        }
    }

    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Base class");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("Derived class");
        }
    }

}
