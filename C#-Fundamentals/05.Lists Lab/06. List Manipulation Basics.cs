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
            string input;
            while ((input = Console.ReadLine())!= "end")
            {
                string[] inputParams = input.Split();

                string command = inputParams[0];

                if (command == "Add")
                {
                    int number = int.Parse(inputParams[1]);
                    products.Add(number);
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(inputParams[1]);
                    products.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(inputParams[1]);
                    products.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(inputParams[2]);
                    int number = int.Parse(inputParams[1]);
                    products.Insert(index, number);
                }

            }
            Console.WriteLine(string.Join(" ",products));
            
        }
    }
}