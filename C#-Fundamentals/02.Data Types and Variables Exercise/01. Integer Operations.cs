namespace Program
{
    using System;

    public class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(((firstNumber + secondNumber) / thirdNumber) * fourthNumber);
        }
    }
}