using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordCheck
{
    internal class PasswordCheck
    {
        public static void minumum8charater()
        {
            Console.WriteLine("Enter the password");
            string password= Console.ReadLine();
            string checkPattarn = "^[a-zA-Z]{8}";
            Regex regex = new Regex(checkPattarn);
            if(regex.IsMatch(password)) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Validate Password");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Password, Password should be 8 characters");
                Console.ResetColor();
            }
        }

        public static void shouldHave1UpperCase()
        {
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            string checkPattarn = "^[A-Z]{1}[a-zA-Z]{7}";
            Regex regex = new Regex(checkPattarn);
            if (regex.IsMatch(password))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Validate Password");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Password, should have 1 upper case and minimum 8 charactes");
                Console.ResetColor();
            }
        }

        public static void shouldHave1NumericNumber()
        {
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            string checkPattarn = "^[A-Z]{1}[0-9]*[a-zA-Z]{2}";
            Regex regex = new Regex(checkPattarn);
            if (regex.IsMatch(password))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Validate Password");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Password, should have 1 upper case and 1 numeric");
                Console.ResetColor();
            }
        }

        public static void shouldHave1SpecialCharacter()
        {
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            string checkPattarn = "^[A-Z]{1}&*()]*[0-9]*[a-zA-Z]{2}";
            Regex regex = new Regex(checkPattarn);
            if (regex.IsMatch(password))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Validate Password");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Password, should have 1 upper case, 1 numeric and 1 special Character");
                Console.ResetColor();
            }
        }

        public static void AllInOneCases()
        {
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            string checkPattarn = "^([a-zA-Z0-9])*[!@#$%^&*](2)([a-zA-Z0-9])*$";
            Regex regex = new Regex(checkPattarn);
            if (regex.IsMatch(password))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Validate Password");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Password, should have 1 upper case, 1 numeric and 1 special Character");
                Console.ResetColor();
            }
        }
    }
}
