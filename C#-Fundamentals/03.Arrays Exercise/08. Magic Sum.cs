using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i];
                for (int k = i + 1; k < arr.Length; k++)
                {
                    sum +=   arr[k];
                    if (sum == n)
                    {
                        Console.Write($"{arr[i]} {arr[k]}");
                        Console.WriteLine();
                        
                    }
                    else 
                    {
                        sum -= arr[k];
                    }

                }
            }
           
        }
    }
}
