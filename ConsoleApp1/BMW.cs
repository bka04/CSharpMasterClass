using System;
namespace CSharpMasterClass
{
    public class BMW : Car2 // could also seal the BMW class to prevent further inheritance (eg M3)
    {
        public string Model { get; set; }
        private string brand = "BMW";

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        public new void ShowDetails() //hides the Car2.ShowDetails()
        {
            Console.WriteLine($"HP: {HP}, Color: {Color}, Model: {Model}, Brand: {brand}");
        }

        public sealed override void Repair() // sealed - can't override any further. Can only seal override methods.
        {
            Console.WriteLine($"The BMW {Model} was repaired!");
        }
    }
}

