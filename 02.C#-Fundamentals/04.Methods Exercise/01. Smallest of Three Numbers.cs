using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());// 2
            int b = int.Parse(Console.ReadLine());// 5
            int c = int.Parse(Console.ReadLine());// 3
            Console.WriteLine(SmallestNumber(a, b, c));
        }


        static int SmallestNumber(int a, int b, int c)
        {
            int smallestNumber = int.MaxValue;
            if (a < smallestNumber)
                smallestNumber = a;

            if (b < smallestNumber)
                smallestNumber = b;

            if (c < smallestNumber)
                smallestNumber = c;
            return smallestNumber;
        }


    }
}