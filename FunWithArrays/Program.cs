using System.Security.Cryptography;

namespace FunWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Fun with Arrays********");

            SimpleArrays();

            ArrayInitilization();

            DeclareImplicitArrays();

            ArrayObject();

            RectMultidimensionalArray();

            JaggedMultidimensionalArray();

            int[] myInt = { 12, 12, 42, 24 };
            PrintArray(myInt);

            string[] myString = GetStringArray();
            foreach (string item in myString)
            {
                Console.WriteLine(item);
            }

            SystemArrayFunctionality();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array creation");

            //Array Int32 created and writed
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }

            //Array created String
            string[] booksOnDotNet = new string[100];
        }

        static void ArrayInitilization()
        {
            Console.WriteLine("\n=> Array Initilization\n");

            string[] stringArray = new string[]
            {
                "One", "Two", "Three"
            };

            Console.WriteLine($"stringArray has {stringArray.Length} elements.");

            bool[] boolArray = { false, true, false };

            Console.WriteLine($"boolArray has {boolArray.Length} elements.");

            int[] intArray = new int[4] { 21, 34, 45, 45 };

            Console.WriteLine($"intArray has {intArray.Length} elements.");

            Console.WriteLine(Environment.NewLine);
        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initilization.");

            var a = new[] { 1, 2, 3, 4, 5 };

            Console.WriteLine($"a is: {a.ToString()}");

            var b = new[] {1, 1.5, 2, 2.5};

            Console.WriteLine($"b is {b.ToString()}");

            var c = new[] {"Hello", null, "world"};

            Console.WriteLine($"c is {c.ToString()}");

            Console.WriteLine(Environment.NewLine);
        }

        static void ArrayObject()
        {
            Console.WriteLine("=> Array of Objects.");

            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(2025, 03, 31);
            myObjects[3] = "From and Void";

            foreach (object o in myObjects)
            {
                Console.WriteLine($"Type: {o.GetType()}, Value: {o}");
            }

            Console.WriteLine(Environment.NewLine);
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");

            int[,] myMatrix;

            myMatrix = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged Multidimensional Array");

            int[][] myJagArray = new int[5][];

            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(Environment.NewLine);
        }

        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine($"Item {i} is {myInts[i]}");
            }

            Console.WriteLine(Environment.NewLine);
        }

        static string[] GetStringArray()
        {
            string[] theString = { "Hello", "From", "GetStringArray" };

            return theString;
        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("\n=> Working with System.Array.\n");

            string[] gothicBannds = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            Console.WriteLine("-> Here is the array:");

            for (int i = 0; i < gothicBannds.Length; i++)
            {
                Console.WriteLine(gothicBannds[i] + " ");
            }

            Console.WriteLine("\n");

            Array.Reverse(gothicBannds);

            Console.WriteLine("-> The reversed array:");

            for (int i = 0; i < gothicBannds.Length; i++)
            {
                Console.WriteLine(gothicBannds[i] + " ");
            }

            Console.WriteLine("-> Cleared out all but one...:");

            Array.Clear(gothicBannds, 1, 2);

            for (int i = 0; i < gothicBannds.Length; i++)
            {
                Console.WriteLine(gothicBannds[i] + " ");
            }

            Console.WriteLine("\n");
        }
    }
}
