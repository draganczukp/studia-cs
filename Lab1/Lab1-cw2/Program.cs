using System;
using System.Collections;

namespace Lab1_cw2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Parametry wejściowe:");
			foreach (var arg in args)
			{
				Console.WriteLine(arg);
			}

			Console.WriteLine("Zmienne środowiskowe");

			var env = System.Environment.GetEnvironmentVariables();

			foreach (DictionaryEntry v in env)
			{
				Console.WriteLine(v.Key + " = " + v.Value);
			}

		}
	}
}
