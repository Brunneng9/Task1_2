using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    public class MathHelper
    {

        public const double piNumber = 3.141592653589793238462643383279;

        public static double CircleArea(double radius)
        {

            double area = piNumber * radius * radius;
            return area;
        }

        public static double SquareArea(double side)
        {
            double area = side * side;
            return area;
        }
    }
}
