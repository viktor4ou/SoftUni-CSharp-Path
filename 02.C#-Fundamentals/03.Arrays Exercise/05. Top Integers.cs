using System;
using System.Linq;

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
            for (int i = 0; i < arr.Length; i++)
            {
                bool isTopInt = true;
                int curNumber = arr[i];
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (curNumber <= arr[k])
                    {
                        isTopInt = false;
                        break;
                    }
                       
                }
                if (isTopInt)
                {
                    Console.Write(curNumber + " ");
                }
            }
        }
    }
}
