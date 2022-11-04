using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterClass
{
    class Section3_FunctionsMethods
    {
        public static void Section3Main()
        {
            //int sum = Add(3, 76);
            //Console.WriteLine(sum);

            //string friend = "Bob";
            //GreetFriend(friend);

            //string s = "HeY ThErE !";
            //s = LowUpper(s);
            //Console.WriteLine(s);
            //Count(s);

            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            //Console.WriteLine(Calculate());

            //TryCatchExample();

            Operators();

        }

        private static void Operators()

        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny);

            // increment and pre-increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);   // displays                   1
            Console.WriteLine("num is {0}", num++); // displays then increments   1
            Console.WriteLine("num is {0}", ++num); // incrememnts then displays  3

            // decrement and pre-decrement operators
            num--;
            Console.WriteLine("num is {0}", num);   // displays                   2
            Console.WriteLine("num is {0}", num--); // displays then decrements   2
            Console.WriteLine("num is {0}", --num); // decrememnts then displays  0

        }



        private static void TryCatchExample()
        {
            // example 2

            int num1 = 5;
            int num2 = 0;
            int result;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero!");
            }

            // example 1

            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception encountered! Do better!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too big or small for Int32!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Cannot be null, good person!");
            }
            catch (Exception)
            {
                Console.WriteLine("Nah.");
            }
            finally
            {
                Console.WriteLine("This is called regardless of error.");
            }
        }

        public static int Calculate()
        {
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());

            return num1 + num2;
        }

        public static string LowUpper(string text)
        {
            return $"{text.ToLower()}{text.ToUpper()}";
        }

        public static void Count(string text)
        {
            Console.WriteLine($"The amount of characters is {text.Length}.");
        }

        private static void GreetFriend(string name)
        {
            Console.WriteLine($"Hi {name}, my friend!");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}
