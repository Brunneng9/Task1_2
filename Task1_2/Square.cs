using System;

namespace Task1_2
{
	class Square
	{
		private double _side;
		public double Side { get { return _side; }
		set
		{
		if(value > 0)
		{
					_side = value;
		}
		else
		{
					Console.WriteLine("Side should be double positive");
		}
		}
		}

		public Square (double side)
		{
			Side = side;
		}

		public  double GetSquareArea()
		{
			double squareArea = Side * Side;
			return squareArea;
		}
	}
}
