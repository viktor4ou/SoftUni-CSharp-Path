namespace Triples_of_Latin_Letters
{
    using System;
    public class Triples_of_Latin_Letters
    {
        static void Main()
        {
            int waterTankCapacity = 255;
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int addedWater = int.Parse(Console.ReadLine());
                sum += addedWater;
                if (sum > waterTankCapacity)
                {
                    sum -= addedWater;
                    Console.WriteLine("Insufficient capacity!");
                }

            }
            Console.WriteLine(sum);
        }
    }
}