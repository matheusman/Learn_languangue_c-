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
				HashSet<string> products = new HashSet<string>();
				while (!sr.EndOfStream) {
					string lines = sr.ReadLine();
					products.Add(lines.Split(",")[0]);
				}
				System.Console.WriteLine(products.Count);
			}
		}


	}
}