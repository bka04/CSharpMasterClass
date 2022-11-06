using System;
namespace CSharpMasterClass
{
    public class Section5_Loops
    {
        
        public static void Section5Main()
        {
            // Exercise4Loops();
            // Exercise5BreakContinue();
            Challenge();

        }

        private static void Challenge()
        {
            double sumOfScores = 0;
            int numberOfScores = 0;

            string enteredScore = "";
            while (enteredScore != "-1")
            {
                Console.WriteLine("Enter the next score. Enter '-1' to quit and get the average score.");
                enteredScore = Console.ReadLine();

                if (enteredScore == "-1") // done entering scores
                {
                    break;
                }

                // check to see if the entered score was valid. If not, display error message. If so, add to the sum.
                (bool valid, double score, string errorMessage) = ValidateEntry(enteredScore);
                if (valid)
                {
                    numberOfScores++;
                    sumOfScores += score;
                } else
                {
                    Console.WriteLine(errorMessage);
                }
            }

            //after scores have been entered, display the average
            if (numberOfScores == 0) //avoid divide by zero errors
            {
                Console.WriteLine("You didn't enter any scores. Goodbye.");
            } else
            {
                double averageScore = sumOfScores / numberOfScores;
                Console.WriteLine("The average score is {0}", averageScore);
            }

        }

        //Try to parse the entry into an integer from 0 to 20.
        private static (bool valid, double score, string errorMessage) ValidateEntry(string entry)
        {
            double score = -1; // default for invalid score
            string defaultMessage = "Enter a number between 0 and 20, or -1 to quit.";
            try
            {
                score = double.Parse(entry);
                if (score < 0 || score > 20)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                return (false, score, $"Format exception: {defaultMessage}");
            }
            catch (ArgumentOutOfRangeException)
            {
                return (false, score, $"Out of range exception: {defaultMessage}");
            }
            catch (Exception)
            {
                return (false, score, $"Exception encountered: : {defaultMessage}");
            }

            return (true, score, "");
        }




        private static void Exercise5BreakContinue()
        {
            int i = -10;

            while (true)
            {

                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 10)
                {
                    break;
                }
                if (i % 6 == 0)
                {
                    break;
                }
                Console.WriteLine(i++);
            }
        }

        private static void Exercise4Loops()
        {
            WhileLoop();
            ForLoop();
        }

        private static void WhileLoop()
        {
            int i = 3;
            while (i > -4)
            {
                Console.WriteLine(i);
                i--;
            }
        }

        private static void ForLoop()
        {
            for (int i = -3; i < 4; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

