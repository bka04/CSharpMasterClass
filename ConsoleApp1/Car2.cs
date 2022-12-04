using System;
namespace CSharpMasterClass
{
    public class Car2
    {

        public int HP { get; set; }
        public string Color { get; set; }

        public Car2(int hp, string color)
        {
            HP = hp;
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"HP: {HP}, Color: {Color}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}

