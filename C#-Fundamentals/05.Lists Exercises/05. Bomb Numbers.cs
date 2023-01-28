namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            List<int> bomb = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
            int indexOfBombNumber = numbers.IndexOf(bomb[0]);

            while (true)
            {
                indexOfBombNumber = numbers.IndexOf(bomb[0]);
                int count = bomb[1];
                for (int i =  indexOfBombNumber + bomb[1]; i > indexOfBombNumber; i--)
                {
                    if (i > numbers.Count - 1)
                    {
                        i--;
                    }
                    else
                    {
                        numbers.RemoveAt(i);
                    }
                }
                
                indexOfBombNumber = numbers.IndexOf(bomb[0]);
                for (int i = indexOfBombNumber - 1; i >= indexOfBombNumber - bomb[1]; i--)
                {
                    
                    if (i < 0)
                    {
                        break;
                    }
                    else
                    {
                        numbers.RemoveAt(i);
                    }
                }
                numbers.Remove(bomb[0]);
                
                indexOfBombNumber = numbers.IndexOf(bomb[0]);
                if (indexOfBombNumber == -1)
                {
                    break;
                }
            }


            Console.WriteLine(ListPrint(numbers));
        }

        static int ListPrint(List<int> numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

    }
}