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
            if (arr.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }       
                              
            int leftSum = 0;  
            int rightSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                rightSum = 0;
                for (int r = i + 1; r < arr.Length; r++)
                {
                    rightSum += arr[r];
                }
                leftSum = 0;
                for (int l = i - 1; l >= 0; l--)
                {
                    leftSum += arr[l];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                
            }
            Console.WriteLine("no");
        }
    }
}
