using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
    class OverloadVsOverride
    {
        public static void Main_OverloadVsOverride(String[] args)
        {
            Calculation objCal = new Calculation();
            var sumInt = Calculation.sum(5, 10);
            var sumDouble = objCal.sum(5.5, 6.8);
            var sumFloat = objCal.sum(19.6f, 20.8f);
            Console.WriteLine("Integer sum: {0}", sumInt);
            Console.WriteLine("Double sum: {0}", sumDouble);
            Console.WriteLine("Float sum: {0}", sumFloat);
            
            Dog d = new Dog();
            d.eat();

        }
    }

    class Calculation
    {
        public static int sum(int x, int y)
        {
            return x + y;
        }

        public double sum(double x, double y)
        {
            return x + y;
        }

        public float sum(float x, float y)
        {
            return x + y;
        }
    }

    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Overriding Eating bread...");
        }
    }

}
