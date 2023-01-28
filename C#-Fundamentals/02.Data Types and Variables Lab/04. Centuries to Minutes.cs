namespace Program
{
    using System;

    public class Program
    {
        static void Main()
        {
            int ceturies = int.Parse(Console.ReadLine());
            int years = ceturies * 100;
            double days = (int)(years * 365.2422);
            double hours = (int) (days * 24);
            double minutes = (int)(hours * 60);
            Console.WriteLine($"{ceturies} centuries = {years:f0} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes");
        }
    }
}