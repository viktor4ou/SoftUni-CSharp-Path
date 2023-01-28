using System;
using System.ComponentModel;
using System.Linq;


namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int tirthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(FirstNumberAddWithSecondNumber(firstNumber,secondNumber) - tirthNumber); 
        }
        static int FirstNumberAddWithSecondNumber(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}