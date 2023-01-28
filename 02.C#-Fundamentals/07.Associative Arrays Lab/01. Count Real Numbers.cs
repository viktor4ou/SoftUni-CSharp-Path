namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            SortedDictionary<double , int> result = new SortedDictionary<double , int>();

            foreach (double number in numbers)
            {
                if (result.ContainsKey(number))
                {
                    result[number]++;
                }
                else
                {
                    result.Add(number, 1);
                }
            }
            foreach (var (key,value) in result)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
    
}