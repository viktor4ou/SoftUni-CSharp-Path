using System;
using System.Linq;


namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                int number = int.Parse(command);
                int nCopy = number;
                int reversedNumber = 0;
                int sum = 0;
                while (nCopy > 0)
                {
                    reversedNumber = nCopy % 10;
                    sum = (sum* 10) + reversedNumber;
                    nCopy /= 10;
                }
                if (number == sum)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }
        }
        

    }
}