using System.Drawing;

namespace Course.Entites
{
	class Circle : Shape
	{
		public Color color { get; set; }
		public double Radius { get; set; }
		public Circle(double radius, Color color) : base(color)
		{
			Radius = radius;
		}

		public override double Area()
		{
			return Radius * 3.14;
		}


	}
}