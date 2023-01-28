using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(n));
        }
        static int GetMultipleOfEvenAndOdds(int n)
        {
            int result = 0;
            result = GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
            return result;
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sumOfEvenDigits = 0;
            int numberCopy = n;
            while (numberCopy > 0)
            {
                int lastDigit = numberCopy % 10;
                numberCopy /= 10;
                if (lastDigit % 2 == 0)
                {
                    sumOfEvenDigits += lastDigit;
                    lastDigit /= 10;
                }
            }
            return sumOfEvenDigits;
        } 
        static  int GetSumOfOddDigits(int n)
        {
            int sumOfOddDigits = 0;
            int numberCopy = n;
            while (numberCopy > 0)
            {
                int lastDigit = numberCopy % 10;
                numberCopy /= 10;
                if (lastDigit % 2 != 0)
                {
                    sumOfOddDigits += lastDigit;
                    lastDigit /= 10;
                }
            }
            return sumOfOddDigits;
        }
    }
}
