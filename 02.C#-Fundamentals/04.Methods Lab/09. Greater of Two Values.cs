using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            string value = Console.ReadLine();
            string firstComponent = Console.ReadLine();
            string secondComponent = Console.ReadLine();
            Console.WriteLine(Compare(value,firstComponent,secondComponent));

            
        }

        static string Compare(string value, string firstComponent, string secondComponent)
        {
            string result = string.Empty;
            if (value == "int")
            {
                result = intCompare(firstComponent, secondComponent, result);
            }
            else if (value == "char")
            {
                result = charCompare(firstComponent, secondComponent, result);
            }
            else if (value == "string")
            {
                result = StringComapre(firstComponent, secondComponent, result);
            }
            return result;
        }

         static string intCompare(string firstComponent, string secondComponent, string result)
        {
            int firstNumber = int.Parse(firstComponent);
            int secondNumber = int.Parse(secondComponent);
            if (firstNumber > secondNumber)
            {
                result = firstComponent;
            }
            else if (firstNumber < secondNumber)
            {
                result = secondComponent;
            }

            return result;
        }

         static string charCompare(string firstComponent, string secondComponent, string result)
        {
            char firstChar = char.Parse(firstComponent);
            char secondChar = char.Parse(secondComponent);
            int firstCharToAscii = (int)firstChar;
            int secondCharToAscii = (int)secondChar;
            if (firstCharToAscii > secondCharToAscii)
            {
                result = firstComponent;
            }
            else if (firstCharToAscii < secondCharToAscii)
            {
                result = secondComponent;
            }

            return result;
        }

         static string StringComapre(string firstComponent, string secondComponent, string result)
        {
            int resultFromComparingStrings = firstComponent.CompareTo(secondComponent);

            if (resultFromComparingStrings < 0)
            {
                result = secondComponent;
            }
            else if (resultFromComparingStrings > 0)
            {
                result = firstComponent;
            }

            return result;
        }
    }
}
