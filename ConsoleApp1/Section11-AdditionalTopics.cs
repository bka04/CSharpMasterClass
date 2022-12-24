using System;
namespace CSharpMasterClass
{

    enum Day { Mo, Tu, We, Th, Fr, Sa, Su }; // enums at namespace level
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec }

    public class Section11_AdditionalTopics
    {
        public static void Section11Main()
        {

            //StructsExample();
            //EnumsExample();
            //MathExample();
            //RandomExample();
            DateTimeExample();

        }

        public static void DateTimeExample()
        {
            DateTime dateTime = new DateTime(1988, 5, 31);

            Console.WriteLine($"My birthday is {dateTime}");

            // write today on screen
            Console.WriteLine($"{DateTime.Today}");
            //write current time
            Console.WriteLine($"{DateTime.Now}");

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine($"Tomorrow will be {tomorrow}");
            Console.WriteLine($"Tomorrow is {tomorrow.DayOfWeek}");

            //display the time: x o'clock and y minutes and z seconds
            DateTime now = DateTime.Now;
            Console.WriteLine($"{now.Hour} o'clock and {now.Minute} minutes and {now.Second} seconds");
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        public static void RandomExample()
        {
            Random dice = new Random();
            int numEyes;

            for(int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }
        }

        public static void MathExample()
        {
            Console.WriteLine($"Ceiling: {Math.Ceiling(12.3)}");
            Console.WriteLine($"Floor: {Math.Floor(12.3)}");

            int num1 = 13;
            int num2 = 9;

            Console.WriteLine($"Lower of num1 {num1} and num2 {num2} is {Math.Min(num1, num2)}");
            Console.WriteLine($"Higher of num1 {num1} and num2 {num2} is {Math.Max(num1, num2)}");
        }

        public static void EnumsExample()
        {
            Day friday = Day.Fr;
            Day sunday = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(friday == a);

            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);

            Console.WriteLine((int)Month.Feb);
            Console.WriteLine((int)Month.Aug);
        }

        // structs are like classes but value types whereas classes are reference types
        // structs have to have a value
        public static void StructsExample()
        {
            Game game1;

            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";
            game1.Display(); // only works when fully defined

        }

        // Access modifiers
        //   private - only accessible inside a class or struct
        //   public - accessible from everywhere
        //   protected - accessible from the class and all classes that derive from it
        //   internal - accessible from its assembly (same namespace/project)
        //  start more restrictive and ease only if needed

    }

    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;


        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        public void Display()
        {
            Console.WriteLine($"Game 1's name is: {name}");
            Console.WriteLine($"Game 1 was developed by: {developer}");
            Console.WriteLine($"Game 1's rating is: {rating}");
            Console.WriteLine($"Game 1's was released on: {releaseDate}");
        }
    }
}

