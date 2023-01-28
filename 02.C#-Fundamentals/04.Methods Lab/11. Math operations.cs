using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string typeOfOperation = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(ResultAfterCalculation( firstNumber, typeOfOperation, secondNumber));

        }
        static int ResultAfterCalculation( int firstNumber, string typeOfOperation, int secondNumber)
        {
            int result = 0;
            if (typeOfOperation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (typeOfOperation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (typeOfOperation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (typeOfOperation == "/")
            {
                result = firstNumber / secondNumber;
            }
            return result;
        }

    }
}