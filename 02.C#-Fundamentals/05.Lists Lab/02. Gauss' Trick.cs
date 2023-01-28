namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();
            for (int i = 0; i < numbers.Count / 2 ; i++)
            {
                Console.Write(numbers[i] + numbers[numbers.Count - 1 - i] + " ");
            }
            if (numbers.Count % 2 != 0)
            {
                Console.Write(numbers[numbers.Count / 2] + " ");
            }
        }
    }
}