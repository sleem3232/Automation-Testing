using System;

namespace CalcNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetTheSum getTheSum = new GetTheSum
            {
                number1 = 5,
                number2 = 15
            };
            int Calc = getTheSum.sum();
            if (Calc==30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TestSuccsed");
            }
            if (Calc != 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Faild");
            }
            Console.WriteLine($"{Calc}");
            Console.ReadKey();
        }
    }
}
