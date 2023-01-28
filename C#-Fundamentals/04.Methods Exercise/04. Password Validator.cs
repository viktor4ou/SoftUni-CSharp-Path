using System;
using System.ComponentModel;
using System.Linq;


namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            if (IsPasswordAlphanumeric(password) && IsPasswordLengthValid(password) && IsPasswordContaningTwoDigits (password))    
            {
                Console.WriteLine("Password is valid");
            }

            if (!IsPasswordLengthValid(password))   
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!IsPasswordAlphanumeric(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!IsPasswordContaningTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        static bool IsPasswordLengthValid(string password)
        {
            bool isPasswordLengthValid = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                isPasswordLengthValid = true;
            }

            return isPasswordLengthValid;
        }
        static bool IsPasswordAlphanumeric(string password)
        {
            bool isValidAlphanumeric = false;

            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return isValidAlphanumeric = false;
                }
            }
            return isValidAlphanumeric = true;
        }
        static bool IsPasswordContaningTwoDigits(string password)
        {
            int digitCounter = 0;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitCounter++;
                }
            }
            if (digitCounter >= 2)
            {
                return true;

            }
            return false;
        }


    }
}