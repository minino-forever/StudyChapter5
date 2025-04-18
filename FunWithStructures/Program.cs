namespace FunWithStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******A First Look at Structures****\n");

            Point myPoint;

            Point myPoint2 = new Point();

            Point myPoint3 = new Point(20, 30);

            ReadOnlyPoint myReadOnlyPoint = new ReadOnlyPoint(2, 3);

            PointWithReadOnly myPointWithReadOnly = new PointWithReadOnly(50, 60, "black point");

            var s = new DisposableRefStruct(22, 33);

            myPoint.X = 349;

            myPoint.Y = 76;

            myPoint.Display();

            myPoint.Increment();

            myPoint.Display();

            myPoint.Decrement();

            myPoint.Display();

            myPoint2.Display();

            myPoint3.Display();

            myReadOnlyPoint.Display();

            myPointWithReadOnly.Display();

            s.Display();

            s.Dispose();

            s.Display();
        }
    }
}
