namespace Course.Model {
	public static class FileExtend {
		public static List<string> LearnFileToEndAndPrint(this StreamReader value) {
			List<string> lines = new List<string>();
			while(!value.EndOfStream) {
				string line = value.ReadLine();
				lines.Add(line);
				System.Console.WriteLine(line);
			}
			return lines;
		}
	}
}