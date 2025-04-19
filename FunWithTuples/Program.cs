namespace FunWithTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string, int, string) values = ("a", 5, "s");

            Console.WriteLine($"First item: {values.Item1}");

            Console.WriteLine($"Second item: {values.Item2}");

            Console.WriteLine($"Third item: {values.Item3}");

            Console.WriteLine("\n->Inferred Tuple Names");

            var foo = new { Prop1 = "First", Prop2 = "second" };

            var bar = (foo.Prop1, foo.Prop2);

            Console.WriteLine($"{bar.Prop1}; {bar.Prop2}");

            ToplesEqualityInequality();

            var samples = FillTheseValues();

            Console.WriteLine("\nParametr Tuples");

            Console.WriteLine($"Int is: {samples.a}");

            Console.WriteLine($"Int is: {samples.b}");

            Console.WriteLine($"Int is: {samples.c}");

            Console.WriteLine("\n->SpliName Method");

            var (first, _, sur) = SplitNames();

            Console.WriteLine($"{first} {sur}");

            Console.WriteLine("\n->Switch Toples");

            //var (_, _) = RockPaperScissors(string s, string ss);

            string firstRock = "rock", secondPaper = "paper";

            RockPaperScissors(firstRock, secondPaper);
        }

        public static void ToplesEqualityInequality()
        {
            Console.WriteLine("\n=> Toples Equality/Inequality");

            var left = (a: 5, b: 6);

            (int? a, int? b) nullableMembers = (5, 6);

            Console.WriteLine(left == nullableMembers);

            (long a, long b) longTuple = (5, 6);

            Console.WriteLine(left == longTuple);

            (long a, int b) lomgFirst = (5, 6);

            (int a, long b) lomgSecond = (5, 6);

            Console.WriteLine(lomgFirst == lomgSecond);
        }

        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 5;
            b = "six";
            c = false;
        }

        static (int a, string b, bool c) FillTheseValues()
        {
            return (9, "second", true);
        }

        static (string firstName, string secondName, string surName) SplitNames()
        {
            return ("Bob", "Junior", "Black");
        }

        static string RockPaperScissors(string first, string second)
        {
            return (first, second) switch
            {
                ("rock", "paper") => "Paper wins.",
                ("rock", "scissors") => "Rock wins.",
                ("paper", "rock") => "Paper wins.",
                ("paper", "scissors") => "Scissors wins.",
                ("scissors", "rock") => "Rock wins.",
                ("scissors", "paper") => "Scissors wins.",
                (_, _) => "Tie."
            };
        }
    }
}
