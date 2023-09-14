using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LastValidName
{
    internal class LastValidName
    {
        public static void firstValid()
        {
            Console.WriteLine("enter first name");
            string firstname = Console.ReadLine();
            string checkPattarn = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regex = new Regex(checkPattarn);
            if (regex.IsMatch(firstname))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("first name is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("first name is invalid");
                Console.ResetColor();
            }
        }

        public static void lastValid() 
        {
            Console.WriteLine("enter the last Name");
            string lastname=Console.ReadLine();
            string checkPattarn = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regex= new Regex(checkPattarn);
            if(regex.IsMatch(lastname))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Last name is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Last name is invalid");
                Console.ResetColor();
            }
        }
    }
}
