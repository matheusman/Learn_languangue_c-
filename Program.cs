using System;
using System.Collections.Generic;
using Course.Model;

namespace Course
{
	class Program
	{
		public static void Main(string[] args)
		{
			string path = @"D:\Downloads\Course_c#\text.txt";
			using( StreamReader file = File.OpenText(path)) {
				file.LearnFileToEndAndPrint();
			}
		}
	}

	class Product {
		public string Name { get; set; }
		public int Age { get; set; }

		public Product( string name, int age ) {
			Name = name;
			Age = age;
		}
	}
}