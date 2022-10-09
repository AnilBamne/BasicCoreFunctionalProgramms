using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreFunctionalProgramming
{
    internal class LeapYear
    {
        public static void checkLeapYear()
        {
            Console.WriteLine("enter a 4 digit year number");
            int year = Convert.ToInt32(Console.ReadLine());
            
            
        if (year % 4 == 0 || year % 100 != 0 || year % 400 == 0)
        {
        Console.WriteLine(year + "  This is a leap year");
        }
        else
        {
         Console.WriteLine("Not a leap year");
        }         
        }

    }
}
