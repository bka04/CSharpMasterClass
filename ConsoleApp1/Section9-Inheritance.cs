using System;
using System.Collections.Generic;

namespace CSharpMasterClass
{
    public class Section9_Inheritance
    {
        public static void Section9Main()
        {
            // InheritanceExample();
            // InheritanceExample2();
            // InheritanceExample3();
            // InheritanceExample4();
            // InterfaceExample();
            // InterfaceExample2();
            // IEnumerableExample();
            IEnumerableExample2();
        }

        public static void IEnumerableExample2()
        {
            List<int> numberList = new List<int>() { 8, 6, 2 };
            int[] numberArray = new int[] { 1, 7, 1, 3 };
            Console.WriteLine(" ");
            CollectionSum(numberList);
            Console.WriteLine(" ");
            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                sum += num;
            }

            Console.WriteLine($"Sum is {sum}");

        }

        public static void IEnumerableExample()
        {
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This is a List<int>");
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("");

            unknownCollection = GetCollection(2);
            Console.WriteLine("This is a Queue<int>");
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("");

            unknownCollection = GetCollection(5);
            Console.WriteLine("This is an Array of type int");
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }


        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
            {
                return numbersList;
            } else if (option == 2)
            {
                return numbersQueue;
            } else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }

        public static void InterfaceExample2()
        {
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            Car damagedCar = new Car(80f, "Blue");

            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();
        }

        public static void InterfaceExample()
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);
            Console.WriteLine(t2.Equals(t1));
        }

        public static void InheritanceExample4()
        {
            Employee2 theEmployee = new Employee2("cashier", "Jack", 40000);
            Boss theBoss = new Boss("manager", "Jane", 85000, "Prius");
            Trainee theTrainee = new Trainee("intern", "Jose", 30000, "9-11", "12-5:30");

            theBoss.Lead();
            theTrainee.Work();
        }

        public static void InheritanceExample3()
        {
            Post post1 = new Post("Thanks for the birhtday wishes", true, "Denis");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", true, "Denis", "www.shoes.com");
            Console.WriteLine(imagePost1);

            VideoPost videoPost1 = new VideoPost("FailVideo", "Denis", true, "www.google.com/fail", 10);
            Console.WriteLine(videoPost1);

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video.");
            Console.ReadKey();
            videoPost1.Stop();
        }

        public static void InheritanceExample2()
        {
            Dog echo = new Dog("Echo", 5);
            echo.Eat();
            echo.MakeSound();
            echo.Play();
            echo.IsHappy = false;
            echo.Play();
            
        }

        public static void InheritanceExample()
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.ListenRadio();
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Samsung");
            myTV.SwitchOn();
            myTV.WatchTV();
        }

    }
}

