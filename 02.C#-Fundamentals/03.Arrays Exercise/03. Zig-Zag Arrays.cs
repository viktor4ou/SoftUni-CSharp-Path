using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                int firstNumber = numbers[0];
                int secondNumber = numbers[1];

                if (i % 2 == 0)
                {
                    
                    firstArr[i] = firstNumber;
                    secondArr[i] = secondNumber;
                }
                else
                {
                    
                    firstArr[i] = secondNumber;
                    secondArr[i] = firstNumber;
                }
            }
            Console.WriteLine(String.Join(" ",firstArr));
            Console.WriteLine(String.Join(" ",secondArr));

        }
    }
}
