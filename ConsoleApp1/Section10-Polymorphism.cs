using System;
using System.Collections.Generic;

namespace CSharpMasterClass
{
    public class Section10_Polymorphism
    {
        public static void Section10Main()
        {
            Example1();
        }

        public static void Example1()
        {
            var cars = new List<Car2>
            {
                new Audi(200, "blue", "A4"), // can use child class here
                new BMW(250, "red", "M3")
            };

            foreach(var car in cars)
            {
                car.Repair(); // because of the virtual/override, calls BMW.Repair() and Audi.Repair()
            }

            Car2 bmwZ3 = new BMW(200, "black", "Z3");
            Car2 audiA3 = new Audi(100, "green", "A3");
            bmwZ3.ShowDetails(); // from the Car2 class, NOT BMW
            audiA3.ShowDetails();

            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails(); // from the BMW class (new keyword hides Car2)

            Car2 carB = (Car2)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            myM3.Repair();

        }



    }
}
