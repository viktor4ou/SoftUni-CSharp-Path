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
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (firstList.Count != 0 || secondList.Count != 0)
            {
                if (firstList.Count == 0 || secondList.Count == 0)
                {
                    break;

                }
                if (firstList[0] > secondList[0])
                {
                    firstList.Add(firstList[0]);
                    firstList.Add(secondList[0]);
                    firstList.RemoveAt(0);
                    secondList.RemoveAt(0);
                }
                else if (firstList[0] < secondList[0])
                {
                    secondList.Add(secondList[0]);
                    secondList.Add(firstList[0]);
                    firstList.RemoveAt(0);
                    secondList.RemoveAt(0);
                }
                else if (firstList[0] == secondList[0])
                {
                    firstList.RemoveAt(0);
                    secondList.RemoveAt(0);
                }
            }

            bool secondListIsBigger = false;
            bool firstListIsBigger = false;
            if (firstList.Count > secondList.Count)
            {
                firstListIsBigger = true;
            }
            else if (firstList.Count < secondList.Count)
            {
                secondListIsBigger = true;
            }
            if (firstListIsBigger)
            {
                int sum = 0;
                foreach (int number in firstList)
                {
                    sum += number;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");

            }
            else if (secondListIsBigger)
            {

                int sum = 0;
                foreach (int number in secondList)
                {
                    sum += number;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }

        }
    }
}