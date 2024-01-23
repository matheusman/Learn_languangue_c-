using System;

namespace Course
{
	class Program
	{
		public static void Main(string[] args)
		{
			string path = @"D:\Downloads\Course_c#\text.txt";
			using (FileStream fs = File.OpenRead(path))
			{
				using (StreamReader sr = new StreamReader(fs))
				{
					Dictionary<string, int> person = new Dictionary<string, int>();
					while (!sr.EndOfStream)
					{
						string line = sr.ReadLine().Replace(" ", "");
						string[] split = line.Split(",");
						string name = split[0];
						int number = int.Parse(split[1]);
						if (person.ContainsKey(name))
						{
							person[name] = person[name] + number;
						}
						else
						{
							person.Add(name, number);
						}
					}
				};
			}
		}


	}
}