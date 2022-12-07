using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterClass
{
    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }

        public override double Volume()
        {
            return Math.PI * (Math.Pow(Radius, 3)) * 4 / 3;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The sphere's radius is {Radius} and its volume is {Volume()}.");
        }
    }
}
