using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Story
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two User objects and check whether they are equal. 
            string[] user ;
            Console.WriteLine("Enter user 1 details:");
            user=Console.ReadLine().Split(',');
            User u1 = new User(user[0],user[1],user[2]);
            Console.WriteLine("Enter user 2 details:");
            user = Console.ReadLine().Split(',');
            User u2 = new User(user[0], user[1], user[2]);


            //User u1 = new User("Harry", "harry@gmail.com", "harry123");
            // User u2 = new User("Harry", "harry@gmail.com", "harry123"); 
            //Harry,harry@gmail.com,harry123
            Console.WriteLine("\nUser 1");
            Console.WriteLine(u1.ToString());
            Console.WriteLine("\nUser 2");
            Console.WriteLine(u2.ToString());

            if (u1.Equals(u2))
                Console.WriteLine("User 1 and User 2 are the same");
            else
            Console.WriteLine("User 1 and User 2 are different");
            
            Console.ReadKey();

        }
    }
}
