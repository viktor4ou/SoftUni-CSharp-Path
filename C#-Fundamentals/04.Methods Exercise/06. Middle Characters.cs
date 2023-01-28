using System;

namespace T06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleChars(input);
        }

        static void PrintMiddleChars(string input)
        {
            string middleChars = string.Empty;

            int middleCharPosition = 0;

            if (input.Length % 2 != 0)
            {
                middleCharPosition = input.Length / 2; 
                middleChars = input[middleCharPosition].ToString();
            }

            else
            {
                middleCharPosition = input.Length / 2 - 1; 
                middleChars = input[middleCharPosition].ToString() + input[middleCharPosition + 1];
            }

            Console.WriteLine(middleChars);
        }
    }
}