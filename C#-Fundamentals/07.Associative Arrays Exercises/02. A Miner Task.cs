namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> miner = new Dictionary<string, int>();

            string command;
            while ((command = Console.ReadLine()) != "stop")
            {
                string ore = command;
                int quantity = int.Parse(Console.ReadLine());

                if (miner.ContainsKey(ore))
                {
                    miner[ore] += quantity;
                }
                else if (!miner.ContainsKey(ore))
                {
                    miner.Add(ore,quantity);
                }
            }

            foreach (var character in miner)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}