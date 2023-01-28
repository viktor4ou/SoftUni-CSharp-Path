namespace Program
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 17; i <= n; i ++)
            {
                if (IsNumberContainsOddDigit(i) && IsNumberDevidableByEight(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsNumberDevidableByEight(int n)
        {
            if (SumOfAllDigits(n) % 8 == 0)
            {
                return true;
            }
            return false;
        }

        static bool IsNumberContainsOddDigit(int n)
        {
            while (n != 0)
            {
                if (((n % 10) % 2) != 0)
                {
                    return true;
                }
                n /= 10;
            }
            return false;
        }
        static int SumOfAllDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }



    }
}