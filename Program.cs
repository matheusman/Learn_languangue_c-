using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Course.Model;

namespace Course
{
	class Program
	{

		public static List<Product> products = new List<Product>();
		public static void Main(string[] args)
		{
			string path = @"D:\Downloads\Course_c#\text.txt";
			using( StreamReader file = File.OpenText(path)) {
				List<string> lines = file.LearnFileToEndAndPrint();
				foreach(string line in lines) {
					string[] split = line.Split(",");
					string name = split[0];
					int number = int.Parse(split[1]);
					products.Add(new Product(name, number));
				}
			}

			double media = products.Select(p => p.Number).DefaultIfEmpty(0).Average();
			IEnumerable<string> p = products.Where(p => p.Number < media).Select(p => p.Name);
			System.Console.WriteLine(media);
			foreach( string i in p) {
				System.Console.WriteLine(i);
			}

		}
	}
}