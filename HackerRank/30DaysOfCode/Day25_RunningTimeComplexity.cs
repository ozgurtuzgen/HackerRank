using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day25_RunningTimeComplexity
    {

        public static void Calculate()
        {
            var n = Convert.ToInt32( Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var valueToBeTested = Convert.ToInt64(Console.ReadLine());

                if (isPrime(valueToBeTested))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }

            }
        }

        private static bool isPrime(long valueToBeTested)
        {
            if (valueToBeTested < 2)
            {
                return false;
            }

            if (valueToBeTested == 2)
            {
                return true;
            }

            if (valueToBeTested % 2 == 0)
            {
                return false;
            }            

            var square = Math.Sqrt(valueToBeTested);
            for (int i = 3; i <= square; i = i+2)
            {
                if (valueToBeTested % i == 0)
                {
                    return false;
                }                
            }
            return true;
        }
    }
}
