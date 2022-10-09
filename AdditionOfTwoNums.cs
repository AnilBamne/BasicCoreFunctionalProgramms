using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalPrograms
{
    internal class AdditionOfTwoNums
    {
       public static void add()
        {
            Console.WriteLine("Enter first num");
            string a = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string e = Console.ReadLine();
            int A=Convert.ToInt32(a);
            int B=Convert.ToInt32(e);
            int C = A + B;
            Console.WriteLine("the sum is : "+C);
        }

        
    }
}
