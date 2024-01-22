using System.IO;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;

namespace Course
{
	class Program
	{
		public static void Main(string[] args)
		{
			string path = @"D:\Downloads\Course_c#";
			string folderName = @"\newFolder";
			Directory.CreateDirectory(path + folderName);
			string name = WriteInConsole("Coloque um nome do arquivo");
			using (FileStream fs = File.Create(path + "\\" + name)) {
				File.AppendAllText(path, "Testando o metodo");
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