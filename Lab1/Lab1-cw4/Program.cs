using System;

namespace lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                string output = input.Replace(args[0], args[1]);
                Console.WriteLine(output);
            }
        }
    }
}
