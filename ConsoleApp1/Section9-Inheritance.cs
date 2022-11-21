using System;
namespace CSharpMasterClass
{
    public class Section9_Inheritance
    {
        public static void Section9Main()
        {
            // InheritanceExample();
            // InheritanceExample2();
            InheritanceExample3();
        }

        public static void InheritanceExample3()
        {
            Post post1 = new Post("Thanks for the birhtday wishes", true, "Denis");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", true, "Denis", "www.shoes.com");
            Console.WriteLine(imagePost1);
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

