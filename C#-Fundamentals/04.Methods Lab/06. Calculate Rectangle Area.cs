using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfARectangle(firstNumber, secondNumber));
        }
        static int AreaOfARectangle(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
