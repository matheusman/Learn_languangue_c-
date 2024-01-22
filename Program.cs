using System.Drawing;
using System.IO;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;
using Course.Entitie;

namespace Course
{
	class Program
	{
		public static void Main(string[] args)
		{
			Circle circle = new Circle(Color.Black, 3.10);
			double num = circle.Area();
			System.Console.WriteLine(num);
		}

	}
}