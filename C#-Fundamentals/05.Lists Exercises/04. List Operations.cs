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
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputParams = input.Split();

                string command = inputParams[0];
                string secondCommand = inputParams[1];
                if (command == "Add")
                {
                    int number = int.Parse(inputParams[1]);
                    numbers.Add(number);
                    
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);
                    if (IsOutBounds(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, number);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(inputParams[1]);
                    if (IsOutBounds(numbers,index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (secondCommand == "left")
                {
                    int count =int.Parse (inputParams[2]);
                    ShiftListLeft(numbers,count);
                }
                else if (secondCommand == "right")
                {
                    int count = int.Parse(inputParams[2]);
                    ShiftListRight(numbers,count);
                }
            }
            ListPrint(numbers);
        }
        static bool IsOutBounds(List<int> numbers, int index)
        {
            if (index < 0 || index > numbers.Count)
            {
                return true;

            }

            return false;
        }
        static void ListPrint(List<int> numbers)
        {
            Console.WriteLine(string.Join(" ",numbers));
        }
        static void ShiftListLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.Add(firstNumber);
                numbers.RemoveAt(0);
            }
        }
        static void ShiftListRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.Insert(0, lastNumber);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }
    }
}