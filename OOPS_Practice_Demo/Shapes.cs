using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice_Demo
{
	//This is parent interace
    public interface IShape
    {

    }

    public interface I2DShape : IShape
    {
        public double Getarea();
    }

    public interface I3DShape : IShape
    {
        public double GetVolume();
}

    public class Circle : I2DShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Getarea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : I2DShape
    {
        public double Length { get; set;}
        public double Breadth { get; set; }

        public double Getarea()
        {
            return Length * Breadth;
        }
    }

    public class Cube : I3DShape
    {
        public double Side { get; set; }

        public double GetVolume()
        {
            return Side * Side * Side;
        }
    }
}
