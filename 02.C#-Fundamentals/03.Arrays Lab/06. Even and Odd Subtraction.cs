using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            int diff =  0;
            for (int i = 0; i < numbers.Length; i++)
            {
                    int currNumber = numbers[i];
                if (currNumber % 2 == 0)
                {
                    sumEven += currNumber;
                }
                else
                {
                    sumOdd += currNumber;
                }
            }
            diff = sumEven - sumOdd;
            Console.WriteLine(diff);
        }
    }
}
