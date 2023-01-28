namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputParams = input.Split();

                string command = inputParams[0];
                if (command == "Add")
                {
                    int number = int.Parse(inputParams[1]);
                    wagons.Add(number);
                }
                else
                {
                    int passengers = int.Parse(inputParams[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((wagons[i] + passengers) <= maxCapacityOfWagon)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", wagons));

        }
    }
}