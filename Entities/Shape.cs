using System.Drawing;
using Course.Interface;

namespace Course.Entitie {
	abstract class Shape : IArea {
		public Color Color { get; set; }
		public Shape (Color color) {
			Color = Color;
		}
		public abstract double Area();
	}
}