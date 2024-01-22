using System.IO;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;

namespace Course
{
	class Program
	{
		public static void Main(string[] args)
		{
			string folderName = @"D:\Downloads\Course_c#\newFolder";
			string sourcePath = @"D:\Downloads\Course_c#\newFolder\text.txt";
			string rootPath = @"D:\Downloads\Course_c#\newFolder\text1.txt";
			Directory.CreateDirectory(folderName);
			using ( FileStream fs = new FileStream(sourcePath, FileMode.Create)) {
				using (StreamWriter sw = new StreamWriter(fs)) {
					sw.WriteLine("asidjioasjdio");
				}
			}

			using (StreamWriter sw = new StreamWriter(rootPath)) {
				sw.WriteLine("asdasd");
			}

		}

		public static string WriteInConsole(string value)
		{
			Console.Write(value);
			string read = Console.ReadLine();
			return read;
		}
	}
}