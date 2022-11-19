using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpMasterClass
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }

    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary { get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }

    class Section7_Collections
    {
        public static void Section7Main()
        {
            // Arrays();
            // ForEachLoops();
            // MultiDimensionalArrays();
            // NestedForLoops();
            // TicTacToeChecker();
            // JaggedArrays(); //array or multiple arrays within an array
            // JaggedArrayChallenge();
            // ArraysAsParams();
            // Params();
            // ArrayLists();
            // Lists();
            // Hashtables();
            // HashtablesChallenge();
            // Dictionaries();
            Console.WriteLine(DictionaryCodingExercise(2));
            Console.WriteLine(DictionaryCodingExercise(37));

        }

        public static string DictionaryCodingExercise(int intKey)
        {
            Dictionary<int, string> bestDictionaryEver = new Dictionary<int, string>()
            {
                {0, "zero"},
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" }
            };

            string bestValueEver;
            if (bestDictionaryEver.TryGetValue(intKey, out bestValueEver))
            {
                return bestValueEver;
            } else
            {
                return "nope";
            }
        }


        public static void Dictionaries()
        {
            // key - value. Dictionary is for consistent data types (all keys are same; all values are same)
            //Dictionary<int, string> myDictionary = new Dictionary<int, string>() {
            //    { 1, "one" },
            //    { 2, "two"},
            //    { 3, "three"}
            //};

            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernest", 22, 8),
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }


            // Update
            string keyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(keyToUpdate))
            {
                employeesDirectory[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);
            }


            // Remove
            string keyToRemove = "Intern";
            if (employeesDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("Employee with Role/Key {0} was removed!", keyToRemove);
            }

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);

                Console.WriteLine($"Key: {keyValuePair.Key}");
                Employee employeeValue = keyValuePair.Value;
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salaray: {2}", employeeValue.Name, employeeValue.Role, employeeValue.Salary);

            }

            Console.WriteLine("");
            string key = "CEO";
            if(employeesDirectory.ContainsKey(key))
            {
                Employee empl = employeesDirectory[key]; // get value from key
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salaray: {2}", empl.Name, empl.Role, empl.Salary);
            }

            Employee result = null;
            if (employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salaray: {2}", result.Name, result.Role, result.Salary);
            } else
            {
                Console.WriteLine("Key does not exist");
            }
            
        }

        public static void HashtablesChallenge()
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            // add students from array into hashtable
            Hashtable studentsTable = new Hashtable();
            foreach (Student student in students)
            {
                if (studentsTable.ContainsKey(student.Id)) {
                    Console.WriteLine("Sorry, a student with the same ID already exists.");
                    Console.WriteLine("");
                } else
                {
                    studentsTable.Add(student.Id, student);
                }
            }

            // display students in hashtable
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"Student ID:{value.Id}");
                Console.WriteLine($"Student Name:{value.Name}");
                Console.WriteLine($"Student GPA:{value.GPA}");
                Console.WriteLine("");
            }
        }

        public static void Hashtables()
        {
            // key - value. Hashtable is for different data types. You don't have to stick to the same like dictionaries
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // retrieve individual item with known ID
            // Student storedStudent1 = (Student)studentsTable[1];
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            // retrieve all values from a Hashtable using DictionaryEntry
            foreach(DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student ID:{temp.Id}");
                Console.WriteLine($"Student Name:{temp.Name}");
                Console.WriteLine($"Student GPA:{temp.GPA}");
                Console.WriteLine("");
            }

            // shortcut! Use studentsTable.Values
            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"Student ID:{value.Id}");
                Console.WriteLine($"Student Name:{value.Name}");
                Console.WriteLine($"Student GPA:{value.GPA}");
                Console.WriteLine("");
            }



        }

        
        public static void Lists()
        {
            // Examples
            var numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(15);
            numbers.Clear();

            var moreNumbers = new List<int> { 5, 10, 15, 20, 25, 30 };

            foreach (int i in moreNumbers)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < moreNumbers.Count; i++)
            {
                Console.WriteLine(moreNumbers[i]);
            }

            // Exercise
            var solutionList = CodingExercise9();
            foreach (int i in solutionList)
            {
                Console.Write($"{i} ");
            }
        }

        private static List<int> CodingExercise9()
        {
            var myList = new List<int>();

            for (int i = 100; i <= 170; i += 2)
            {
                myList.Add(i);
            }

            return myList;
        }

        public static void ArrayLists()
            // Microsoft does not recommend to use this for new development. Use List<Object> instead for heterogeneous collection of objects.
            // For homogenous collection of objects, use List<T>
        {
            ArrayList myArrayList = new ArrayList(); // with indefinite amount of objects
            ArrayList myArrayList2 = new ArrayList(100); // with defined amount of objects

            myArrayList.Add(345);
            myArrayList.Add(new int[] { 3, 4, 5 });
            myArrayList.Add(13);
            myArrayList.Add(100);
            myArrayList.Add("Hello");
            myArrayList.Add(13.37);

            myArrayList.Remove(13); // delete element with specific value from arraylist
            myArrayList.RemoveAt(1); // delete element at specific position
            Console.WriteLine($"The array list has {myArrayList.Count} elements.");

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } else if (obj is double)
                {
                    sum += (double)obj;
                } else if (obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine($"Sum is {sum}");


        }

        public static void Params()
        {

            int min = MinV2(3, 2352, -40, 23, 65767, -5);
            Console.WriteLine(min);

            // Console.WriteLine("Price is {0}, pi is {1}, at is {2}", 32, 3.14, '@');
            //ParamsMethod("This", "is", "a", "lot", "of", "strings", "and", "it", "just", "keeps", "going", "...");

            //int price = 50;
            //float pi = 3.14f;
            //char at = '@';
            //string book = "The Hobbit";

            //ParamsMethod2(price, pi, at, book);
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue; // highest possible value an integer can have
            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }


        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
            Console.WriteLine("");
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            //for each loop to go through the array of objects
            foreach(object obj in stuff)
            {
                //print each object followed by a space
                Console.WriteLine(obj + " ");
            }
        }


        public static void ArraysAsParams()
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);

            foreach(int grade in studentsGrades)
            {
                Console.WriteLine(grade);
            }

            Console.WriteLine($"The average is {averageResult}");


            int[] happiness = new int[] { 3, 6, 4, 5, 5 };
            SunIsShining(happiness);
            foreach (int happyScore in happiness)
            {
                Console.WriteLine(happyScore);
            }

        }

        private static void SunIsShining(int[] happinessArray)
        {
            for (int i = 0; i < happinessArray.Length; i++)
            {
                happinessArray[i] += 2;
            }
        }


        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;
            return average;
        }



        public static void JaggedArrayChallenge()
        {
            string[][] friends = new string[][]
            {
                new string[] {"Bob", "Joe" },
                new string[] {"Sherry", "Mary" }
            };

            Console.WriteLine($"{friends[0][0]} and {friends[0][1]}, meet {friends[1][0]} and {friends[1][1]}.");
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
