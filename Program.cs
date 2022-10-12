using BasicCoreFunctionalProgramming;

namespace logicalPrograms
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(" welcome to basic functional programs");

            Console.WriteLine("------------------------");
            IsPrimeNumber p = new IsPrimeNumber();
            p.isPrimeNum();
            Console.WriteLine("------------------------");



            FlipTheCoin flip = new FlipTheCoin();
            flip.flipCoin();


            LeapYear.checkLeapYear();

            PowerOfTwo.computePower();


            ComputeQuotientAndReminder.compute();

            SwapTwoNums.swapNums();

            CheckEvenOrOdd.checkEvenOdd();

            LargestOfThreeNumbers.findLargest();

            StopWatchProgram.stopWatch();

        }
    }
}