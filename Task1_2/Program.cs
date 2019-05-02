using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task1_2
{
    class CircleAndSquareAreaCalculator
    {

        static void Main(string[] args)
        {
            double side;
            double radius;
            

            Console.WriteLine("1 - Calculate Circle area");
            Console.WriteLine("2 - Calculate Square area");
            Console.WriteLine("3 - Calculate Circle and Square area <- (Second Task is here)");
            int condition = EnterIntValue();




            if (condition == 1)
            {
                Console.WriteLine("Please enter a circle radius: ");
                radius = EnterDoubleValue();

                Console.WriteLine("Circle area is " + MathHelper.CircleArea(radius));
                Console.Read();

            }
            else if (condition == 2)
            {
                Console.WriteLine("Please enter a square side: ");
                side = EnterDoubleValue();

                Console.WriteLine("Square area is " + MathHelper.SquareArea(side));
                Console.Read();

            }
            else if (condition == 3)
            {

                Console.WriteLine("Please enter a circle radius: ");
                radius = EnterDoubleValue();

                Console.WriteLine("Please enter a square side: ");
                side = EnterDoubleValue();


                Console.WriteLine("Circle area is " + MathHelper.CircleArea(radius));
                Console.WriteLine("Square area is " + MathHelper.SquareArea(side));
                Console.WriteLine();

                Console.WriteLine("Do you fancy to know if it's possible to fit ");
                Console.WriteLine("1 - Circle into Square");
                Console.WriteLine("2 - Square into Circle");
                Console.WriteLine("All other digits - Exit");
                int enterCondition = EnterIntValue();

                if (enterCondition == 1)
                {
                    if (radius <= (side / 2))
                    {
                        Console.WriteLine("Yep");
                    }
                    else
                    {
                        Console.WriteLine("Nope");
                    }
                }
                else if (enterCondition == 2)
                {
                    if (radius <= (Math.Sqrt(2 * MathHelper.SquareArea(side)) / 2))
                    {
                        Console.WriteLine("Yep");
                    }
                    else
                    {
                        Console.WriteLine("Nope");
                    }
                }
                else
                {
                    Console.WriteLine("Have a nice day!)");
                    Console.Read();
                    return;
                }



            }
            else
            {
                Console.WriteLine("You've entered invalid number");
                Console.Read();
            }
        }
        private static int EnterIntValue()
        {
            int value;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Value should be integer");
                }
            }
            return value;
        }
        private static double EnterDoubleValue()
        {
            double value;
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Value should be number");
                }
            }
            return value;
        }
    }



}

