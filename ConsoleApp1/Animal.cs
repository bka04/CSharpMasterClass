using System;
namespace CSharpMasterClass
{
    public class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        //virtual - can be overwritten by child classes
        public virtual void MakeSound()
        {

        }

        //can override but don't have to
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating.");
            } else
            {
                Console.WriteLine($"{Name} is not hungry.");
            }

        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }
    }
}

