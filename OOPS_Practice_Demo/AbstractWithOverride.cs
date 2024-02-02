using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
    internal class AbstractWithOverride
    {
        public static void Main_AbstractWithOverride(String[] args)
        {
            Pig objPig = new Pig();
            objPig.animalSound(); // Calling the abstract method
            objPig.sleep(); // Calling the regular method
            
        }
    }

    abstract class Animals
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig: Animals
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says wee wee");
        }
    }
}
