using System;
namespace CSharpMasterClass
{
    public class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat(); // use the eat method of the parent class (Animal)
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof.");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}

