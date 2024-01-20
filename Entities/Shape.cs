using System.Drawing;

namespace Course.Entites {
	abstract class Shape {
		public Color Color { get; set; }

		public Shape (Color color) {
			Color = color;
		}
		public abstract double Area();
	}
}