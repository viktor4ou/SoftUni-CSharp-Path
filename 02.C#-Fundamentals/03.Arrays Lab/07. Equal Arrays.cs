using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    Environment.Exit(0);
                }
                else
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
