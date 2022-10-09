using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreFunctionalProgramming
{
    internal class ComputeQuotientAndReminder
    {
        public static void compute()
        {
            int quotient;
            int reminder;
            Console.WriteLine("Enter a divident ");
            int divident=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a diviser ");
            int diviser=Convert.ToInt32(Console.ReadLine());

            quotient=divident / diviser;
            reminder=divident % diviser;

            Console.WriteLine("the quotient is : "+quotient);
            Console.WriteLine("the reminder is : "+quotient);


        }
    }
}
