namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<int> products = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            products.RemoveAll(x => x < 0);
            products.Reverse();
            if (products.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(String.Join(" ", products));
            
        }
    }
}