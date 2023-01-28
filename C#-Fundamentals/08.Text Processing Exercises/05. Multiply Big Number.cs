namespace TextProcessing
{
    using System;
    using System.Text;
    public class Program
    {
        static void Main()
        {
            string firstNumber = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            if (multiplyer == 0 || firstNumber == "0")
            {
                Console.WriteLine(0);
                Environment.Exit(1);
            }

            int reminder = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int lastDigit = int.Parse(firstNumber[i].ToString());
                int product = lastDigit * multiplyer + reminder;
                reminder = product / 10;
                lastDigit /= 10;
                sb.Insert(0,product % 10);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb);
        }
    }
}