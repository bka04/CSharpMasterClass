using System;
namespace CSharpMasterClass
{
    public class Audi : Car2
    {
        public string Model { get; set; }
        private string brand = "Audi";

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"HP: {HP}, Color: {Color}, Model: {Model}, Brand: {brand}");
        }

        public override void Repair()
        {
            Console.WriteLine($"The Audi {Model} was repaired!");
        }
    }
}

