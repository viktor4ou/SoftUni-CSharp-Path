namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputParams = input.Split();

                string command = inputParams[0];
                if (command == "Delete")
                {
                    int element = int.Parse(inputParams[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else if (command == "Insert")
                {
                    int element = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);
                    numbers.Insert(index,element);
                }

            }
            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}