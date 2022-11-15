using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterClass
{
    class Section7_Collections
    {
        public static void Section7Main()
        {
            // Arrays();
            // ForEachLoops();
            // MultiDimensionalArrays();
            // NestedForLoops();
            // TicTacToeChecker();
            JaggedArrays(); //array or multiple arrays within an array


        }

        public static void JaggedArrays()
        {
            int[][] jaggedArray = new int[3][]; // 3 arrays within the array

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            // alternative way:
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 },
                new int[] { 13, 21 }
            };

            // Console.WriteLine($"Middle value of first entry is: {jaggedArray2[0][2]}");

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                for (int j = 0; j < jaggedArray2[i].Length; j++) {
                    Console.WriteLine($"Element {j} of array {i}: {jaggedArray2[i][j]}"); 
                }
            }

            foreach(int[] intArray in jaggedArray2)
            {
                foreach(int i in intArray)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public static void TicTacToeChecker()
        {
            string[,] boardToCheck = new string[,]
            {
                {"X", "O", "X"},
                {"O", "X", "O" },
                {"O", "X", "X" }
            };

            bool winner = Checker(boardToCheck);
            Console.WriteLine($"There is{(winner ? null : " not")} a winner!");
        }

        public static bool Checker(string[,] board)
        {
            //check horizontal and vertical
            for (int i = 0; i < 3; i++)
            {
                //horizontal
                if (CheckThreeStrings(board[i, 0], board[i, 1], board[i, 2]))
                {
                    return true;
                }
                //vertical
                if (CheckThreeStrings(board[0, i], board[1, i], board[2, i]))
                {
                    return true;
                }
            }

            //check diagonals
            if (
                CheckThreeStrings(board[0, 0], board[1, 1], board[2, 2]) ||
                CheckThreeStrings(board[2, 0], board[1, 1], board[0, 2])
                )
            { 
                return true;
            }

            return false;
        }

        public static bool CheckThreeStrings(string string1, string string2, string string3)
        {
            if (string1 == "")
            {
                return false;
            }
            return ((string1 == string2) && (string2 == string3));
        }

        static int[,] matrix =
        {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
        };

        private static void NestedForLoops()
        {
            //loop through rows
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //loop through columns
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Row index: {i}, column index: {j} = {matrix[i, j]}");
                }
            }
        }

        private static void MultiDimensionalArrays()
        {
            // declare 2d array
            string[,] matrix;

            // 3d array
            int[,,] threeD;

            // 2d array
            int[,] array2D = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine($"Central value of 2d array is {array2D[1,1]}");

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" },
                    {"Hi there", "What's up" }
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"Another one", "last entry" }
                }
            };

            Console.WriteLine($"Value in 3d array: {array3D[0, 2, 0]}");


            string[,] array2DString = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            array2DString[1, 1] = "chicken";

            foreach (string str in array2DString)
            {
                Console.WriteLine(str);
            }

            int dimensions = array2DString.Rank;
            Console.WriteLine("Number of dimensions: {0}", dimensions);
            

        }

        private static void ForEachLoops()
        {
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 10;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine(nums[j]);
            }

            foreach(int k in nums)
            {
                Console.WriteLine(k);
            }

            string[] friends = { "Tiffany", "Kelsey", "Nicole", "Mike", "Zach" };
            foreach (string friend in friends)
            {
                Console.WriteLine($"Hello, {friend}");
            }

            string[] eFriends = friends.Where(friend => friend.Contains("e")).ToArray();
            foreach(string friend in eFriends)
            {
                Console.WriteLine(friend);
            }

        }

        private static void Arrays()
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("grades at index 0 is {0}", grades[0]);

            //string input = Console.ReadLine();
            //grades[0] = int.Parse(input);
            //Console.WriteLine("grades at index 0 is {0}", grades[0]);

            // another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // third way
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);





        }
    }
}
