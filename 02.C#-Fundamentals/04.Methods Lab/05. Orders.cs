using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine($"{PriceCalculatior(product, quantity):f2}");
        }

        static double PriceCalculatior(string product, int quantity)
        {
            double sum = 0;
            if (product == "coffee")
            {
                sum = quantity * 1.50;
            }
            else if (product == "water")
            {
                sum = quantity * 1.00;
            }
            else if (product == "coke")
            {
                sum = quantity * 1.40;
            }
            else if (product == "snacks")
            {
                sum = quantity * 2.00;
            }

            return sum;
        }

    }
}
