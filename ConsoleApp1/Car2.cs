using System;
namespace CSharpMasterClass
{
    public class Car2
    {

        public int HP { get; set; }
        public string Color { get; set; }

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

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

