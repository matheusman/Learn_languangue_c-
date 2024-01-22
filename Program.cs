using System.IO;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;

namespace Course
{
	class Program
	{
		public static void Main(string[] args)
		{
			try {

				string line = WriteInConsole("Coloque seu tempo de horario em que esta no brasil: ");
				DateTime dateTime = DateTime.Parse(line);

				if (!(dateTime is DateTime)) {
					throw new FormatException("Coloque uma exeção correta");
				}

				string text = "text1.txt";
				string path = Path.GetFullPath("./" + text);
				File.WriteAllLines(path, [dateTime.ToString(), DateTime.Now.ToString()]);
				using (FileStream fs = new FileStream(path, FileMode.CreateNew)) {
					File.Copy(path.Replace(text, "text2.txt"), path);
				}

			} catch (FormatException e) {
				Console.WriteLine("Deu um erro " + e.Message);
			} catch (IOException e) {
				Console.WriteLine("File is not exists" + e.Message);
			}

		}

		public static string WriteInConsole (string value) {
			Console.Write(value);
			string read = Console.ReadLine();
			return read;
		}
	}
}