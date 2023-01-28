namespace Program
{
    using System;

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] =int.Parse (Console.ReadLine());
                sum += numbers[i];
            }
            foreach (int  number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }

    }
}