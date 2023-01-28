using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            string typeOfOperation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(ResultAfterCalculation(typeOfOperation, firstNumber, secondNumber)); 
            
        }
       static int ResultAfterCalculation(string typeOfOperation, int firstNumber, int secondNumber)
        {
            int result = 0;
            if (typeOfOperation == "add")
            {
                result = firstNumber + secondNumber;
            }
            else if (typeOfOperation == "subtract")
            {
                result = firstNumber - secondNumber;
            }
            else if (typeOfOperation == "multiply")
            {
                result = firstNumber * secondNumber;
            }
            else if (typeOfOperation == "divide")
            {
                result = firstNumber / secondNumber;
            }
            return result;
        }

    }
}
