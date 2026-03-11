namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("   ,___  / /\n  /   /-/-/-\n /    -/-/- \n(___/ / /   ");

            Console.WriteLine("Enter two numbers to calculate the sum");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 + number2);

            Console.WriteLine("Concatenate two strings");
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();
            Console.WriteLine(str1 + str2);
        }
    }
}