namespace Program
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            int longestSequenceOfNumbers = 0;
            int element = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }

                if (counter > longestSequenceOfNumbers)
                {
                    longestSequenceOfNumbers = counter;
                    element = numbers[i];
                }
            }
            for (int i = 0; i <= longestSequenceOfNumbers; i++)
            {
                Console.Write(element + " ");
            }

        }

    }
}