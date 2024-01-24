using System.Reflection.Metadata.Ecma335;

namespace Course.Model {
	public class Product {
		public string Name { get; set; }
		public int Number { get; set; }

		public Product (string name, int number) {
			Name = name;
			Number = number;
		}
	}
}