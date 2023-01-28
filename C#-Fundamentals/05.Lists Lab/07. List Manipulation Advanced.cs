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
            bool changes = false;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputParams = input.Split();

                string command = inputParams[0];
                if (command == "Add")
                {
                    changes = true;
                    int number = int.Parse(inputParams[1]);
                    products.Add(number);
                }
                else if (command == "Remove")
                {
                    changes = true;
                    int number = int.Parse(inputParams[1]);
                    products.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    changes = true;
                    int index = int.Parse(inputParams[1]);
                    products.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    changes = true;
                    int index = int.Parse(inputParams[2]);
                    int number = int.Parse(inputParams[1]);
                    products.Insert(index, number);
                }
                else if (command == "Contains")
                {
                    int number = int.Parse(inputParams[1]);
                    if (products.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", products.Where(x => x % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", products.Where(x => x % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(products.Sum());
                }
                else if (command == "Filter")
                {
                    string condition = inputParams[1];
                    int number = int.Parse(inputParams[2]);
                    if (condition == ">")
                    {

                        Console.WriteLine(string.Join(" ", products.Where(x => x > number)));
                    }
                    else if (condition == "<")
                    {

                        Console.WriteLine(string.Join(" ", products.Where(x => x < number)));
                    }
                    else if (condition == "<=")
                    {

                        Console.WriteLine(string.Join(" ", products.Where(x => x <= number)));
                    }
                    else if (condition == ">=")
                    {

                        Console.WriteLine(string.Join(" ", products.Where(x => x >= number)));
                    }
                }
            }
            if (changes)
            {
                Console.WriteLine(String.Join(" ", products));
            }
        }
    }
}