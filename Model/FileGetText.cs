using System.Reflection.Metadata;

namespace Course.Model {
	public static class FileExtend {
		public static List<string> LearnFileToEndAndPrint(this StreamReader value) {
			List<string> lines = new List<string>();
			while(!value.EndOfStream) {
				string line = value.ReadLine();
				if (line == null) {
					throw new NullReferenceException("This value its not defined");
				}
				lines.Add(line);
			}
			return lines;
		}
	}
}