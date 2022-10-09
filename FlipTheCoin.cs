using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalPrograms
{
    internal class FlipTheCoin
    {
        public void flipCoin()
        {
            //variables
            int head = 0;
            int tail = 0;
            Console.WriteLine("enter how many times u want to flip the coin");
            int N=Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i=1; i<=N;i++)
            {
                int outcome = random.Next(0, 2);
                if (outcome == 0)
                {
                    Console.WriteLine("Its a Heads");
                    head++;
                }
                else
                {
                    Console.WriteLine("Its a Tails");
                    tail++;
                }
            }
            

            Console.WriteLine("the no of Heads is : " +(head));
            Console.WriteLine("the no of Tails is : " +(tail));
        }
    }
}
