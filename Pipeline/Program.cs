using System.Numerics;

namespace Pipeline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number one : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number two : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(addition(num1, num2));
        }
        static string addition(int num1, int num2)
        {
            int answer = num1 + num2;
            return "The answer is " + num1 + " + " + num2 + " = " + answer;
        }
    }
}
