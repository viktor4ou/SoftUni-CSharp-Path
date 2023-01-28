
namespace Vending_Machine
{
    using System;

    public class Vending_Machine
    {
        static void Main()
        {
            string startCommand = "Start";
            string command;
            double sumOfCoins = 0;

            while ((command = Console.ReadLine()) != startCommand)
            {
                if (command == "0.1")
                {
                    sumOfCoins += 0.1;
                }
                else if (command == "0.2")
                {
                    sumOfCoins += 0.2;
                }
                else if (command == "0.5")
                {
                    sumOfCoins += 0.5;
                }
                else if (command == "1")
                {
                    sumOfCoins += 1;
                }
                else if (command == "2")
                {
                    sumOfCoins += 2;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {command}");
                }
            }
            string food = string.Empty;
            while ((food = Console.ReadLine()) != "End")
            {
                if (food == "Nuts")
                {

                    if (sumOfCoins >= 2.0)
                    {
                        sumOfCoins -= 2.0;

                        food = food.ToLower();
                        Console.WriteLine($"Purchased {food}");

                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");

                    }
                }
                else if (food == "Water")
                {
                    if (sumOfCoins >= 0.7)
                    {
                        sumOfCoins -= 0.7;
                        food = food.ToLower();
                        Console.WriteLine($"Purchased {food}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (food == "Crisps")
                {
                    if (sumOfCoins >= 1.5)
                    {
                        sumOfCoins -= 1.5;
                        food = food.ToLower();
                        Console.WriteLine($"Purchased {food}");

                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (food == "Soda")
                {
                    if (sumOfCoins >= 0)
                    {
                        sumOfCoins -= 0.8;
                        food = food.ToLower();
                        Console.WriteLine($"Purchased {food}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (food == "Coke")
                {

                    if (sumOfCoins >= 1.0)
                    {
                        sumOfCoins -= 1.0;
                        food = food.ToLower();
                        Console.WriteLine($"Purchased {food}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            if (sumOfCoins >= 0)
            {
                Console.WriteLine($"Change: {sumOfCoins:f2}");
            }

        }
    }
}