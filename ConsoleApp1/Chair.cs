using System;
namespace CSharpMasterClass
{
    public class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }

        public Chair(string color, string material)
        {
            Color = color;
            Material = material;
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}

