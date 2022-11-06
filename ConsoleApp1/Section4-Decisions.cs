using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterClass
{
    class Section4_Decisions
    {
        static string username;
        static string password;

        public static void Section4Main()
        {
            TernaryExample();

            // Register();
            // Login();

            // Check(-2);
            // TryParseExample();

        }

        private static void TernaryExample()
        {
            int temp = 101;
            string stateOfMatter;

            stateOfMatter = (temp < 0) ? "solid" : (temp > 100) ? "gas" : "liquid";
            Console.WriteLine(stateOfMatter);
        }

        public static void Register()
        {
            Console.WriteLine("Enter username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            password = Console.ReadLine();
            Console.WriteLine("Registration complete");
            Console.WriteLine("--------------------------");
        }

        public static void Login()
        {

            Console.WriteLine("Enter username");
            if(username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Logged in successfully");
                } else
                {
                    Console.WriteLine("Password WRONG");
                }
            } else
            {
                Console.WriteLine($"Username WRONG");
            }

        }

        public static void NestedCheck(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3.");
            } else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7.");
            } else if (number % 2 == 0)
            {
                Console.WriteLine("Even number.");
            } else
            {
                Console.WriteLine("Odd number.");
            }
        }

        public static void Check(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            } else
            {
                Console.WriteLine("Odd");
            }
        }

        private static void TryParseExample()
        {
            Console.WriteLine("What's the temp?");
            string temperature = Console.ReadLine();
            int number;

            if (int.TryParse(temperature, out number))
            {
                if (number > 50)
                {
                    Console.WriteLine("warm enough");
                }
                else
                {
                    Console.WriteLine("pretty chilly");
                }
            }
            else
            {
                Console.WriteLine("enter a numeric temp");
            }
        }
        
    }
}
