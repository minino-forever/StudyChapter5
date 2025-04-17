namespace FunWithEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Fun with enums****\n");

            EmpTypeEnum emp = EmpTypeEnum.Contractor;

            AskForBonus(emp);

            EmpTypeEnum emp2 = EmpTypeEnum.Grunt;

            AskForBonus(emp2);

            Console.WriteLine($"\nEmpTypeEnum uses a {Enum.GetUnderlyingType(emp.GetType())} for storage\n");

            Console.WriteLine($"\nEmpTypeEnum uses a {Enum.GetUnderlyingType(typeof(EmpTypeEnum))} for storage\n");

            Console.WriteLine($"{emp.ToString()} = {(int)emp}\n");

            DayOfWeek day = DayOfWeek.Monday;

            ConsoleColor cc = ConsoleColor.Gray;

            EvaluateEnum(emp2);

            EvaluateEnum(day);

            EvaluateEnum(cc);
        }

        enum EmpTypeEnum
        {
            Manager = 10,
            Grunt = 1,
            Contractor =100,
            VicePresident = 9
        }

        static void AskForBonus(EmpTypeEnum e)
        {
            switch (e)
            {
                case EmpTypeEnum.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpTypeEnum.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                    case EmpTypeEnum.Contractor:
                    Console.WriteLine("You already get enought cash...");
                    break;
                    case EmpTypeEnum.VicePresident:
                    Console.WriteLine("Very good! Sir!");
                    break;
            }
        }

        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine($"=> Information about {e.GetType().Name}\n");

            Console.WriteLine($"Underlying srorage type: {Enum.GetUnderlyingType(e.GetType())}");

            Array enumData = Enum.GetValues(e.GetType());

            Console.WriteLine($"This enum has {enumData.Length} memebers.");

            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine($"Name: {enumData.GetValue(i)}, Value: {enumData.GetValue(i):D}");
            }

            Console.WriteLine(Environment.NewLine);
        }
    }
}
