namespace Program
{
    using System;

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfAscii = 0;
            for (int i = n; i > 0 ; i--)
            {
                
                char getChar= char.Parse(Console.ReadLine());
                sumOfAscii += (int)(getChar);
            }
            Console.WriteLine($"The sum equals: {sumOfAscii}");
        }

    }
}