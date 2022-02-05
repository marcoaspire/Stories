using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace story2
{
    class Program
    {
        static Boolean ValidatePassword(String password)
        {
           if (password.Length < 8 || password.Contains(" ") || !password.Any(char.IsLetterOrDigit) || !password.Any(char.IsDigit)
                || !password.Any(char.IsLower) || !password.Any(char.IsUpper))
                return false;
            return true;
        }
        static void Main(string[] args)
        {
            //Validate the Password of the User. 
            string password;
            Console.WriteLine("Enter the password to be validated:");
            password = Console.ReadLine();
            if (ValidatePassword(password))
                Console.WriteLine("Password is valid");
            else
                Console.WriteLine("Password is invalid");
            Console.ReadKey();
        }
    }
}
