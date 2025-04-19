namespace FunWithNaullableValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Fun with Nullable Value Types ****\n");

            DatabaseReader dr = new DatabaseReader();

            int? i = dr.GetIntFromDatabase();

            if (i != null)
            {
                Console.WriteLine($"Value of 'i' is: {i.Value}");
            }
            else
            {
                Console.WriteLine("Value of 'i' is undefined!");
            }

            bool? b = dr.GetBoolFromDatebase();

            if (b != null)
            {
                Console.WriteLine($"Vlaue of 'b' is: {b.Value}");
            }
            else
            {
                Console.WriteLine("Value of 'b' undefined!");
            }
        }

        static void LocalNullableVariables()
        {
            int? nuallableInt = 10;

            double? nuallableDouble = 3.14;

            bool? nuallableBool = null;

            char? nuallableChar = 'a';

            int?[] arrayOfNullableInts = new int?[10];
        }

        static void LocalNullableVariablesUsingNullable()
        {
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
        }
    }
}
