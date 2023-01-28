using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
        }

        private static void PrintMatrix(int n)
        {
            for (int i = 1; i < n * n; i += n)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }


    }
}