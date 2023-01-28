using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main(string[] args)
        {
            string [] arrOfStrings = Console.ReadLine().Split().ToArray();

            for (int i = arrOfStrings.Length - 1; i >= 0; i--)
            {
                Console.Write(arrOfStrings[i] + " ");
            }
        }
    }
}
