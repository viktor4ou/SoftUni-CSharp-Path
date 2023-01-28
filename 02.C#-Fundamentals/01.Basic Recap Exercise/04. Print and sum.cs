namespace Print_and_sum
{
    using System;

    public class Print_and_sum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = n; i <= n2; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");


        }
    }
}