using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Class1
    {
        static void aa(string[] args)
        {

            string permission = "Admin|Mannager";
            int level = 20;
            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }

            }
            else if (permission.Contains("Mannager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }

            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }



        }
    }
}
