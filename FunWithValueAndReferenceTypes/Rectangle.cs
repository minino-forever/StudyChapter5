using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithValueAndReferenceTypes
{
    struct Rectangle
    {
        public ShapeInfo RectInfo;

        public int RectTop, RectBottom, RectLeft, RectRight;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            RectInfo = new ShapeInfo(info);
            RectTop = top;
            RectBottom = bottom;
            RectLeft = left;
            RectRight = right;
        }

        public void Display() => 
            Console.WriteLine($"String = {RectInfo.InfoString}, Top = {RectTop}," +
                $" Bottom = {RectBottom}, Left = {RectLeft}, Right = {RectRight}");
    }
}
