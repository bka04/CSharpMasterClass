using System;
using System.Collections.Generic;

namespace CSharpMasterClass
{
    public class Section10_Polymorphism
    {
        public static void Section10Main()
        {

            AbstractExample();
            //Example1();
            //WriteTextFileExample();
            //ReadTextFileExample();
        }

        // Notes on interfaces vs abstract classes

        // Definition:
        // abstract class - incomplete class (can't be instantiated) provides a blueprint for derived classes
        // interfaces - contract. Defines an ability that a class has. Cannot contain method definitions - only declarations
        //      use this when not all derived classes will have this ability

        // Differences:
        // interface
        //      not implemented
        //      can't have constructor
        //      contains only method declaration (not definitions)
        //      no fields
        //      classes can implement more than one interface
        //      classes must implement all of its members (properties, methods)
        //      what an object CAN DO
        // abstract class
        //      either partially implemented or not implemented at all
        //      can have constructors
        //      may contain method definitions, fields
        //      classes can extend (inherit) one class only
        //      classes must implement abstract members only
        //      what an object IS


        public static void AbstractExample()
        {
            // Shape shape1 = new Shape(); // can't do this because it is an abstract class
            Cube cube = new Cube(4.45);
            // cube1.GetInfo();
            Sphere sphere = new Sphere(3.89);
            // sphere1.GetInfo();

            Shape[] shapes = { cube, sphere };
            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                
                Cube iceCube = shape as Cube; //create as a Cube
                if (iceCube == null)
                {
                    Console.WriteLine("This shape is not a cube.");
                }

                if(shape is Cube)
                {
                    Console.WriteLine("This shape is a cube.");
                }

                object cube1 = new Cube(7); // object which contains a Cube
                Cube cube2 = (Cube)cube1; // cast it to a Cube

                Console.WriteLine($"{cube2.Name} has a volume of {cube2.Volume()}");

            }
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

            bmwZ3.SetCarIDInfo(1234, "Denis Panjuta");
            audiA3.SetCarIDInfo(1235, "Frank White");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails(); // from the BMW class (new keyword hides Car2)

            Car2 carB = (Car2)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            myM3.Repair();

        }

        public static void WriteTextFileExample()
        {
            string[] lines = { "first line", "second line", "third line" };

            System.IO.File.WriteAllLines(@"/Users/brentaronsen/Projects/CSharpMasterClass/ConsoleApp1/TextFile2.txt", lines);


        }

        public static void ReadTextFileExample()
        {
            string text = System.IO.File.ReadAllText(@"/Users/brentaronsen/Projects/CSharpMasterClass/ConsoleApp1/TextFile.txt");

            Console.WriteLine("Textfile contains following text: {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"/Users/brentaronsen/Projects/CSharpMasterClass/ConsoleApp1/TextFile.txt");

            Console.WriteLine("Contents of TextFile.txt: ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
        }

    }
}
