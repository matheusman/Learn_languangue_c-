using System.Drawing;
namespace Course.Entitie
{
	class Circle : Shape
	{
		public Color Color { get; set; }
		public double Radius { get; set; }
		public Circle(Color color, double radius) : base(color)
		{
			Radius = radius;
		}


	public override double Area()
	{
			return 5.0;
	}
  }
}