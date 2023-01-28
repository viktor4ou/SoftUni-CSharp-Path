namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).ToList();
            list.Reverse();
            List<int> numbers = new List<int>();

            foreach (var num in list)
            {
                numbers.AddRange(num.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", numbers));


        }

    }
}