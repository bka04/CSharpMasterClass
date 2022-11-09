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
            ForEachLoops();
            // MultiDimensionalArrays();


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

            Console.WriteLine($"Central value is {array2D[1,1]}");

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
