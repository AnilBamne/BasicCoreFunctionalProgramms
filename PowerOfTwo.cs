using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BasicCoreFunctionalProgramming
{
    internal class PowerOfTwo
    {
        public static void computePower()
        {
            Console.WriteLine("enter a num :");

            int power = 0;
            //take a comand line argument N
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the power of 2 table for " + N + " is :");
            for (int i = 1; i <= N; i++)
            {
                power = 2 * i;

                Console.WriteLine(power);
            }
            
        }
            


    }
}
