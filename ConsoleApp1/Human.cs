using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterClass
{
    class Human
    {

        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine($"My name is {firstName} {lastName}.");
            Console.WriteLine($"I have {eyeColor} eyes and am {age} years old.");
        }
    }
}
