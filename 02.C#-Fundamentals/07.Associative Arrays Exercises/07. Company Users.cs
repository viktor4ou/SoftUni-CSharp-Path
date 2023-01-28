using System.Threading.Channels;

namespace Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" -> ");

                string companyName = cmdArgs[0];
                string id = cmdArgs[1];

                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                    company[companyName].Add(id);
                }
                else if (company.ContainsKey(companyName))
                {
                    List<string> members = company[companyName];
                    if (members.Contains(id))
                    {
                        continue;
                    }
                    else
                    {
                        company[companyName].Add(id);
                    }
                }
            }

            foreach (var companyName in company)
            {
                Console.WriteLine(companyName.Key);
                List<string> members = companyName.Value;
                foreach (var id in members)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
       
    }
}