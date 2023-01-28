namespace Program
{
    using System;
    

    public class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            decimal sum = 0;
            for (int i = 1; i <= number; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());
                sum += numbers;
            }
            Console.WriteLine(sum);
        }
    }
}