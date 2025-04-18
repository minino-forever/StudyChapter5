using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    ref struct DisposableRefStruct
    {
        public int X;

        public readonly int Y;

        public readonly void Display() => Console.WriteLine($"X = {X}, Y = {Y}");

        public DisposableRefStruct(int posX, int posY)
        {
            X = posX;

            Y = posY;

            Console.WriteLine("Created!");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposed!");
        }
    }
}
