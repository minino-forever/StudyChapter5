using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    struct Point
    {
        public int X;

        public int Y;

        public void Increment()
        {
            X++;
            Y++;
        }

        public void Decrement()
        {
            Y--;
            X--;
        }

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public void Display() => Console.WriteLine($"X = {X}, Y = {Y}");
    }
}
