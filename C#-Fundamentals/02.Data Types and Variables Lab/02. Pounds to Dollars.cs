namespace Program
{
    using System;
    public class Program
    {
        static void Main()
        {
            double pounds = double.Parse(Console.ReadLine());
            double dollars = (double)(pounds * 1.31);
            Console.WriteLine($"{dollars:f3}");
        }
    }
}