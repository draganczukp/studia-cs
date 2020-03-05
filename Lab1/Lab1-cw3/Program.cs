using System;
using System.IO;

namespace lab1_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = ".";
			if (args.Length > 0 && args[0] != null && args[0] != "")
			{
				path = args[0];
			}

			var files = Directory.GetFiles(path);

			foreach (var file in files)
			{
				Console.WriteLine(file);
			}

		}
	}
}