using System;

namespace _1st_october
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) - 1;
            string[] daysOfWeek =
           {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (n >= 0 && n < daysOfWeek.Length)
            {
                Console.WriteLine(daysOfWeek[n]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
