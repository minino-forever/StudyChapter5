namespace FunWithRefTypeValTypeParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Send A Person By Value***********");

            Person fred = new Person("Fred", 44);

            Console.WriteLine("\nBefore by value call, Person is:");

            fred.Display();

            SendAPersonByValue(fred);

            Console.WriteLine("\nAfter by value call, Person is:");

            fred.Display();

            Console.WriteLine("\n*********Passing Person object by Reference ****\n");

            Person met = new Person("Met", 22);

            Console.WriteLine("Before by ref call, Person is:");

            met.Display();

            SendAPersonByReference(ref met);

            Console.WriteLine("After by ref call, Person is:");

            met.Display();
        }

        static void SendAPersonByValue(Person p)
        {
            p.personAge = 33;
            p.personName = "Gogi";
            p = new Person("Nick", 32);
        }

        static void SendAPersonByReference(ref Person p)
        {
            p.personAge = 3331;
            p.personName = "Gogigaga";
            p = new Person("Nick", 29);
        }
    }
}
