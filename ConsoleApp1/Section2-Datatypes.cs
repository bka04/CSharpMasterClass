using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterClass
{
    class Section2_Datatypes
    {
        public static void StringChallenge()
        {
            Console.WriteLine("Enter a string here: ");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the character to search: ");
            char charToSearch = Console.ReadLine()[0];

            int index = inputString.IndexOf(charToSearch);
            if (index == -1)
            {
                Console.WriteLine($"'{charToSearch}' was not found in '{inputString}'");
            }
            else { Console.WriteLine($"'{charToSearch}' is at index {index} in '{inputString}'"); }

            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            TextInfo myTI = new CultureInfo("en-us", false).TextInfo;
            string fullName = myTI.ToTitleCase($"{firstName} {lastName}");
            string fullName2 = myTI.ToTitleCase(string.Format("{0} {1}", firstName, lastName));
            string fullName3 = myTI.ToTitleCase(firstName + " " + lastName);
            Console.WriteLine(fullName);
            Console.WriteLine(fullName2);
            Console.WriteLine(fullName3);
        }

        public static void DataTypesAndVariables()
        {
            //see https://learn.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/ms228360(v=vs.90)
            byte myByte = 255;
            sbyte mySByte = -128;
            int myInt = 3234;
            uint myUInt = 34534534;
            short myShort = -32767;
            ushort myUShort = 65535;
            long myLong = 938475938;
            ulong myULong = 3453453453453;
            float myFloat = 234.342F;
            double myDouble = 454.3453453453;
            char myChar = 't';
            bool myBool = false;
            string myString = "hello";
            decimal myDecimal = 23423.3433M;

            string anotherString = "3453";
            int intFromString = int.Parse(anotherString);
            Console.WriteLine($"Converted {anotherString} to an integer: {intFromString}");

        }

        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string brentsBday = "April 24";

        public static void Constants()
        {
            Console.WriteLine($"My birthday is on {brentsBday}");
        }
    }
}
