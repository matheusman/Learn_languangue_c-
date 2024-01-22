using System;
using Course.Model;

namespace Course
{
	class Program
	{
		public static void Main(string[] args)
		{
			string path = @"D:\Downloads\Course_c#\text.txt";
			using (StreamReader sr = File.OpenText(path)) {
				List<Product> list = new List<Product>();
				while (!sr.EndOfStream) {
					string line = sr.ReadLine();
					string[] split = line.Split(",");
					string name = split[0];
					int number = int.Parse(split[1]);
					list.Add(new Product(name, number));
				}
				string max = Max(list);
				System.Console.WriteLine(max);
			}
		}

		public static string Max (List<Product> list) {
			Product maxArr = list[0];
			for (int e = 0; e < list.Count(); e++) {
				int num = list[e].Name.CompareTo(maxArr.Name);
				if (num > 0) {
					maxArr = list[e];
				}
			}

			return maxArr.Name;
		}

	}
}