using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class FizzBuzz
    {
        public string Fizz_Buzz(int i)
        {
            if (i % 15 == 0)
                return "fizzbuzz";
            if (i % 3 == 0)
                return "fizz";
            if (i % 5 == 0)
                return "buzz";
            return i.ToString();

        }
    }
}
