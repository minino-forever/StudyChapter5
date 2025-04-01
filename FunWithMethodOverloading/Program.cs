using System;
using FunWithMethodOverloading;
using static FunWithMethodOverloading.AddOperations;

namespace FunWithMethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Fun With Method Overloading*********\n");

            Console.WriteLine(Add(10, 10));

            Console.WriteLine(Add(10.11, 10.11));

            Console.WriteLine(Add(100_000_111, 100_112_212));
        }
    }
}
