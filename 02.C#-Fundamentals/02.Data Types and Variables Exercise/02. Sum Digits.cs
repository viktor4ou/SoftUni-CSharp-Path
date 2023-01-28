namespace Program
{
    using System;

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string numberLenght = n.ToString();
            int sum = 0;
            int lastDigit = 0;
            int numberCopy = n;
            for (int i = 0; i <= numberLenght.Length - 1; i++)
            {
                lastDigit =numberCopy % 10;
                sum +=lastDigit;
                numberCopy/=10;
                lastDigit/=10;
            }
            Console.WriteLine(sum);
        }
    }
}