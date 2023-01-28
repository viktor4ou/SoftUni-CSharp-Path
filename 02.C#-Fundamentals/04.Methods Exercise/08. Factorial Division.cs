using System;
using System.Linq;


namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{FactorialSum(num1 , num2):f2}");
        }
        static double FactorialSum(int num1, int num2)
        {
            double sum1 = 1;
            double sum2 = 1;

            for (int i = 1; i <= num1; i++)
            {
                sum1 *= i ;
            }
            for (int j = 1; j <= num2; j++)
            {
                sum2 *= j;
            }
            double result = sum1 / sum2;
            return result;
        }

    }
}