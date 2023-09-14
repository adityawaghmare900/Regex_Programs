using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ValidFirstName
    {
        public void firstName()
        {
            Console.Write("Enter your name: ");
            string firstname=Console.ReadLine();
            string namePattarn = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regex=new Regex(namePattarn);
            if (regex.IsMatch(firstname))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name is valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Name is not valid");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
