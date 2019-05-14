using System;

namespace Task1_2
{
	public class Circle
	{
		private double _radius = 0;
		private const double _piNumber = 3.141592653589793238462643383279;
		public double Radius
		{ get	{ return _radius; }
		  set	{
		  if (value > 0 && value < double.MaxValue)
		  {
					_radius = value;
		  }
		  else
		  {
					Console.WriteLine("Radius should be double positive");
		  }

		  }
		
		}

		public Circle (double radius)
		{
			Radius = radius;
		}

		public double GetCircleArea()
		{
			double circleArea = +_piNumber * _radius * _radius;
			return circleArea;
		}

	}
}
