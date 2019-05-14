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
            
            Console.WriteLine("1 - Calculate Circle area");
            Console.WriteLine("2 - Calculate Square area");
            Console.WriteLine("3 - Calculate Circle and Square area <- (Second Task is here)");
            int condition = EnterIntegerValueFromConsole();




            if (condition == 1)
            {
                Console.WriteLine("Please enter a circle radius: ");
                // radius = EnterDoubleValue();
				Circle circle1 = new Circle(EnterDoubleValue());
                Console.WriteLine("Circle area is " + circle1.GetCircleArea());
				Console.Read();

            }
            else if (condition == 2)
            {
                Console.WriteLine("Please enter a square side: ");
                // side = EnterDoubleValue();
				Square square1 = new Square(EnterDoubleValue());
                Console.WriteLine("Square area is " + square1.GetSquareArea());
                Console.Read();

            }
            else if (condition == 3)
            {

                Console.WriteLine("Please enter a circle radius: ");
                // radius = EnterDoubleValue();
				Circle circle2 = new Circle(EnterDoubleValue());
                Console.WriteLine("Please enter a square side: ");
				// side = EnterDoubleValue();
				Square square2 = new Square(EnterDoubleValue());


                Console.WriteLine("Circle area is " + circle2.GetCircleArea());
                Console.WriteLine("Square area is " + square2.GetSquareArea());
                Console.WriteLine();

                Console.WriteLine("Do you fancy to know if it's possible to fit ");
                Console.WriteLine("1 - Circle into Square");
                Console.WriteLine("2 - Square into Circle");
                Console.WriteLine("All other digits - Exit");
                int enterCondition = EnterIntegerValueFromConsole();

                if (enterCondition == 1)
                {
                    if (circle2.Radius <= (square2.Side / 2))
                    {
                        Console.WriteLine("Yep");
						Console.Read();

					}
					else
                    {
                        Console.WriteLine("Nope");
						Console.Read();

					}
				}
                else if (enterCondition == 2)
                {
					if (circle2.Radius >= (square2.Side / Math.Sqrt(2)))
                    {
                        Console.WriteLine("Yep");
						Console.Read();

					}
					else
                    {
                        Console.WriteLine("Nope");
						Console.Read();

					}
				}
                else
                {
                    Console.WriteLine("Have a nice day!)");
                    Console.Read();
                }



            }
            else
            {
                Console.WriteLine("You've entered invalid number");
                Console.Read();
            }
        }
        private static int EnterIntegerValueFromConsole()
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
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
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

