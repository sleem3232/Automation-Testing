using System;

namespace Calc2numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetTheSum getTheSum = new GetTheSum
            {
                number1 = 10,
                number2 = 20,

            };
            int Calc = getTheSum.GetTheSum2Num();
            Console.WriteLine($"the sum of 2 number of int is {Calc}");
            if (Calc == 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Succed");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Faild");
            }
            getTheSum.number1 = 15;
            Calc = getTheSum.GetTheSum2Num();
            if (Calc == 30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Test Succed");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Test Faild");
            }
            Console.ReadKey();

        
    }
    }
}
