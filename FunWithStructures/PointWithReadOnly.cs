using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    struct PointWithReadOnly
    {
        public int X;
        public readonly int Y;
        public readonly string Name;

        public readonly void Display() =>Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");

        public PointWithReadOnly(int posX, int yPos, string name)
        {
            X = posX;
            Y = yPos;
            Name = name;
        }
    }
}
