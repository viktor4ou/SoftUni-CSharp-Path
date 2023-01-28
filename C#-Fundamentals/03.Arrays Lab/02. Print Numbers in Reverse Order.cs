using System;

namespace _1st_october
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }
            for (int j = arr.Length - 1; j >= 0; j--)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}
