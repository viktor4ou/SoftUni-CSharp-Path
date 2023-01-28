using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            double numberBase = double.Parse(Console.ReadLine());
            double numberPower = double.Parse(Console.ReadLine());
            Console.WriteLine(PowerNumber (numberBase,numberPower));
        }
        static double PowerNumber(double numberBase, double numberPower)
        {
            double poweredNumber = Math.Pow (numberBase,numberPower);
            return poweredNumber;
        }
    }
}
