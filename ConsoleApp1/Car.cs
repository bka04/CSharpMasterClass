using System;
using System.Collections.Generic;

namespace CSharpMasterClass
{
    public class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }

        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color)
        {
            Speed = speed;
            Color = color;

            DestructionSound = "CarDestructionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}

