using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MobileFormat
{
    internal class PreDefinedMobileFormat
    {
        public static void mobileFormat()
        {
            Console.WriteLine("Enter the number");
            string mobileNumber = Console.ReadLine();
            string CheckPattarn = "^+[1-9]{2}[: :][0-9]{10}$";
            Regex regex = new Regex(CheckPattarn);
            if (regex.IsMatch(mobileNumber))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("mobile format is correct");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mobile Format is not correct");
                Console.ResetColor();
            }
        }
    }
}