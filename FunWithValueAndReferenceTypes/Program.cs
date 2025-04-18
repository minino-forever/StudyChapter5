namespace FunWithValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Value types and reference****");

            ValueTypeAssignment();

            ReferenceTypeAssignment();

            ValueTypeContainingRefType();
        }

        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assignment value types\n");

            Point p1 = new Point(10, 10);

            Point p2 = p1;

            p1.Display();

            p2.Display();

            p1.X = 100;

            Console.WriteLine("\n=> Changed p1.X\n");

            p1.Display();

            p2.Display();
        }

        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("\nAssignment reference types\n");

            PointRef p1 = new PointRef(10, 10);

            PointRef p2 = p1;

            p1.Display();

            p2.Display();

            p1.X = 100;

            Console.WriteLine("\n=> Changed p1.X\n");

            p1.Display(); 
            
            p2.Display();
        }

        static void ValueTypeContainingRefType()
        {
            Console.WriteLine("\n-> Creating r1\n");

            Rectangle r1 = new Rectangle("First Rect", 12, 123, 23, 234);

            Console.WriteLine("-> Assigning r2 to r1");

            Rectangle r2 = r1;

            r1.Display();

            r2.Display();

            Console.WriteLine("-> Changing values of r2");

            r2.RectInfo.InfoString = "This is new info!";

            r2.RectBottom = 4444;

            r1.Display();

            r2.Display();
        }
    }
}
