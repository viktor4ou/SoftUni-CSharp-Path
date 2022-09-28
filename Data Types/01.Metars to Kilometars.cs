namespace Metars_to_Kilometars
{
    using System;
    public class Metars_to_Kilometars
    {
        static void Main()
        {
            int metars = int.Parse(Console.ReadLine());
            double kilometars = (double)(metars / 1000.0);
            Console.WriteLine($"{kilometars:f2}");
        }
    }
}