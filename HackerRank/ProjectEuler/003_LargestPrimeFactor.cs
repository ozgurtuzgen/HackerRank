using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProjectEuler
{
    public static class _3_LargestPrimeFactor
    {

        public static void Calculate()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<long> primeList = new List<long>();
            for (int a0 = 0; a0 < t; a0++)
            {
                long greatestPrime = 0;
                long n = Convert.ToInt64(Console.ReadLine());               

                for (Int64 k=2; k <= n/2; k++)
                {
                    var remainder = n % k;

                    if (remainder==0)
                    {
                        greatestPrime = k;
                    }
                }
                
                if (greatestPrime == 0)
                {
                    greatestPrime = n;
                }

                Console.WriteLine(greatestPrime);
            }
        }
    }
}
