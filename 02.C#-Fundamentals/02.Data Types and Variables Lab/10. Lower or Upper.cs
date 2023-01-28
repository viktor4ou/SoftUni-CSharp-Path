namespace Program
{
    using System;

    public class Program
    {
        static void Main()
        {
            char ch = char.Parse(Console.ReadLine());

            if (char.IsUpper(ch))
            {
                Console.WriteLine("upper-case");
                
            }
            else
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}