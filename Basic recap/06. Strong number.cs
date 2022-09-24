namespace Strong_Number
{
    using System;

    public class Strong_Number
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int nCopy = n;
            int sum = 1;
            int facturialSum = 0;
            while (nCopy > 0)
            {
                int lastDigit = nCopy % 10;
                nCopy /= 10;
                sum = 1;
                for (int i = 2; i <= lastDigit; i++)
                {

                    sum *= i;
                }
                facturialSum += sum;
            }
            if (n == facturialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}