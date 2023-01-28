using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            NumberType(n);
        }
        static void NumberType(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero. ");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
        }
    }
}
