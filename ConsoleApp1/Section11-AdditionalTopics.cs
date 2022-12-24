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
            EnumsExample();

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

