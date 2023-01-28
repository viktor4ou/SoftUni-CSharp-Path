using System;
using System.Collections.Generic;
using System.Linq;

namespace Т03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parckingInfo = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = 
                    Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = cmdArgs[0];
                string name = cmdArgs[1];

                if (command == "register")
                {
                    string licensePlateNumber = cmdArgs[2];

                    if (parckingInfo.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parckingInfo[name]}");
                    }
                    else
                    {
                        parckingInfo.Add(name,licensePlateNumber);
                        Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!parckingInfo.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        parckingInfo.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }

            }

            foreach (var person in parckingInfo)
            {
                Console.WriteLine($"{person.Key} => {person.Value}");
            }
        }
       
    }
}