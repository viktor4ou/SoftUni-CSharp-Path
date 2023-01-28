namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();
            List<int> secondList = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count,secondList.Count); i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }
            if (firstList.Count > secondList.Count)
            {                              
                for (int i = secondList.Count ; i <=firstList.Count - 1; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else if ( secondList.Count > firstList.Count)
            {
                for (int i = firstList.Count; i <= secondList.Count - 1; i++)
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}