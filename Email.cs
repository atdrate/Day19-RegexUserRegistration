using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistr19
{
    internal class Email
    {
        public static void ValidateEmail()
        {
            Console.WriteLine("Enter EmailID");
            string email = Console.ReadLine();

            string pattern = @"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,5)(\.[a-z]{2})?$";

            if (Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("Email Id is valid");
            }
            else
            {
                Console.WriteLine("Email Id is not valid");
            }
        }
    }
}
