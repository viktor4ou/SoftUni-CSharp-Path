using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {      
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Printer(row);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                Printer(i);
            }

        }

        private static void Printer(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

    }
}
