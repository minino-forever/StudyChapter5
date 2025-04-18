using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    readonly struct ReadOnlyPoint
    {
        public int X { get; }
        public int Y { get; }

        public void Display()=> Console.WriteLine($"X = {X}, Y = {Y}");

        public ReadOnlyPoint(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
    }
}
