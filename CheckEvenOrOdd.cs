using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreFunctionalProgramming
{
    internal class CheckEvenOrOdd
    {
        public static void checkEvenOdd()
        {
            Console.WriteLine("Enter  a number ");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine("the number is Even number");
            }
            else
            {
                Console.WriteLine("the number is Odd number");
            }
        }
    }
}
