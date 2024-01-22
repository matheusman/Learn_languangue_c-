using System.Runtime.InteropServices;

namespace Course.Model {
	public class Product : IComparable {
		public string Name { get; set; }
		public int Number { get; set; }

		public Product (string name, int number) {
			Name = name;
			Number = number;
		}

		public int CompareTo (object obj) {
			if (!(obj is Product)) {
				throw new InvalidComObjectException("this object is type product");
			}
			Product value = obj as Product;
			return Name.CompareTo(value.Name);
		}
	}
}