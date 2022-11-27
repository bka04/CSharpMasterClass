using System;
namespace CSharpMasterClass
{
    public class Section9_Inheritance
    {
        public static void Section9Main()
        {
            // InheritanceExample();
            // InheritanceExample2();
            // InheritanceExample3();
            InheritanceExample4();
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

