using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithValueAndReferenceTypes
{
    internal class PointRef
    {
        public int X;

        public int Y;

        public PointRef(int posX, int posY)
        {
            X = posX;
            Y = posY;
        }

        public void Display() => Console.WriteLine($"X = {X}, Y = {Y}");
    }
}
