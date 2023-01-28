namespace Program
{
    using System;

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int lastDigit = 0;
            int sumOfLastDigits = 0;
            for (int i = 1; i <= n; i++)
            {
                sumOfLastDigits = 0;
                int digit = i;
                while (digit > 0)
                {

                    lastDigit = digit % 10;
                    sumOfLastDigits += lastDigit;
                    lastDigit /= 10;
                    digit /= 10;
                }
                Console.WriteLine(sumOfLastDigits == 5 || sumOfLastDigits == 7 || sumOfLastDigits == 11 ? $"{i} -> True" : $"{i} -> False");


            }
        }
    }
}