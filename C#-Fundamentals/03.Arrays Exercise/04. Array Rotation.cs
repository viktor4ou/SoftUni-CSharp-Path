using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int rotationCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationCount; i++)
            {
                int firstNumberOfArr = arr[0];

                for (int j = 1; j < arr.Length ; j++)
                {
                    arr[j - 1] = arr[j]; 
                }
                arr[arr.Length -1]=firstNumberOfArr;
            }
            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
