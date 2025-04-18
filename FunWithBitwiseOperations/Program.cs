namespace FunWithBitwiseOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========Fun With Bitwise Operations=========\n");

            Console.WriteLine($"6 & 4 = {6 & 4} | {Convert.ToString((6 & 4), 2)}");

            Console.WriteLine($"6 | 4 = {6 | 4} | {Convert.ToString((6 | 4), 2)}");

            Console.WriteLine($"6 ^ 4 = {6 ^ 4} | {Convert.ToString((6 ^ 4), 2)}");

            Console.WriteLine($"6 << 4 = {6 << 4} | {Convert.ToString((6 << 1), 2)}");

            Console.WriteLine($"6 >> 4 = {6 >> 4} | {Convert.ToString((6 >> 1), 2)}");

            Console.WriteLine($"~6 = {~6} | {Convert.ToString(~((short)6), 2)}");

            Console.WriteLine($"Int.MaxValue {Convert.ToString((int.MaxValue), 2)}");

            Console.WriteLine(Environment.NewLine);

            ContactPreferenceEnum emailAndPhone = ContactPreferenceEnum.Email | ContactPreferenceEnum.Phone;

            Console.WriteLine($"None? {(emailAndPhone | ContactPreferenceEnum.None) == emailAndPhone}");

            Console.WriteLine($"Email? {(emailAndPhone | ContactPreferenceEnum.Email) == emailAndPhone}");

            Console.WriteLine($"Phone? {(emailAndPhone | ContactPreferenceEnum.Phone) == emailAndPhone}");

            Console.WriteLine($"Ponyexpress? {(emailAndPhone | ContactPreferenceEnum.Ponyexpress) == emailAndPhone}");
        }
    }
}
