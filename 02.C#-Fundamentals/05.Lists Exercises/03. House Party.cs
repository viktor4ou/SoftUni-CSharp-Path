namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()

        {
            int n = int.Parse(Console.ReadLine());
            List<string> partyList = new List<string>();
            while (n > 0)
            {
                string input = Console.ReadLine();
                string[] inputParams = input.Split();

                string command = inputParams[0];

                if (inputParams.Length == 3)
                {
                    if (partyList.Contains(command))
                    {
                        Console.WriteLine($"{command} is already in the list!");
                    }
                    else
                    {
                        partyList.Add(command);
                    }
                }

                else if (inputParams.Length == 4)
                {
                    if (!partyList.Contains(command))
                    {
                        Console.WriteLine($"{command} is not in the list!");
                    }
                    else
                    {
                        partyList.Remove(command);
                    }
                }
                n--;
            }
            Console.WriteLine(String.Join(Environment.NewLine, partyList));

        }
    }
}