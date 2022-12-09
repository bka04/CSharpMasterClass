using System;
namespace CSharpMasterClass
{
    public class Section11_AdditionalTopics
    {
        public static void Section11Main()
        {

            StructsExample();

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

            Console.WriteLine($"Game 1's name is: {game1.name}");
            Console.WriteLine($"Game 1 was developed by: {game1.developer}");
            Console.WriteLine($"Game 1's rating is: {game1.rating}");
            Console.WriteLine($"Game 1's was released on: {game1.releaseDate}");
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
    }
}

