using System;
using System.Collections.Generic;

namespace CSharpMasterClass
{
    public class Section12_EventsAndDelegates
    {

        public static void Section12Main()
        {
            //DelegatesExample();
            //OurDelegatesExample();
            CodingExercise();

        }

        public static void CodingExercise()
        {
            Console.WriteLine($"{ApplyOperation(5, 3, Multiply)}");
        }

        public delegate float OperationDelegate(float num1, float num2);
        
        static public float Add(float num1, float num2) {
            return num1 + num2;
        }
        
        static public float Subtract(float num1, float num2) {
            return num1 - num2;
        }
        
        static public float Multiply(float num1, float num2) {
            return num1 * num2;
        }
        
        static public float Divide(float num1, float num2) {
            if (num2 != 0){
                return num1 / num2;
            } else {
                return 0; //of course, should be an error
            }
        }
        
        static public float ApplyOperation(float num1, float num2, OperationDelegate operation) {
            return operation(num1, num2);
        }

        //delegate type that takes a person object and returns a bool
        public delegate bool FilterDelegate(Person p);


        public static void OurDelegatesExample()
        {
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);
        }

        //displays the list of people that pass the filter condition (returns true)
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            //check if person passes the filter
            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine($"{p.Name}, {p.Age} years old");
                }
            }
        }

        //filters
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }


        public static void DelegatesExample()
        {
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli"};

            Console.WriteLine("---Before---");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            int removedNames = names.RemoveAll(filter); //example of using a delegate

            Console.WriteLine("---After---");
            Console.WriteLine($"{removedNames} names were removed.");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }


        static bool filter(string s)
        {
            // return whether the string s contains the letter 'i'
            return s.Contains("i");
        }
    }
}

