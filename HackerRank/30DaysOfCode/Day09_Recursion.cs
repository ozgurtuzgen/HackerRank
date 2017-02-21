using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day09_Recursion
    {

        public static void Calculate()
        {
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }

        private static int Factorial(int n)
        {
            int result=1;
            if (n>0)
            {
                result = n * (Factorial(n - 1));
            }

            return result;
        }
    }
}
