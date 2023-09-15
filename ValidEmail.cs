using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidEmail
{
    internal class ValidEmail
    {
        public void validEmail()
        {
            Console.WriteLine("Enter the email Id");
            string checkPattarn = "[a-z]{1,}([-.+]{1}){0,1}([0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.][a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}";
            string email = Console.ReadLine();
            Regex regex = new Regex(checkPattarn);
            if (regex.IsMatch(email))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valid email");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid email");
                Console.ResetColor();
            }
        }
    }
}
    
