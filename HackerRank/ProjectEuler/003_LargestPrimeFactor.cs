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
            List<long> factorList = new List<long>();
            for (int a0 = 0; a0 < t; a0++)
            {

                long n = Convert.ToInt64(Console.ReadLine());               
                
                Console.WriteLine(FindMaxPrimeFactor(n));
            }
        }

        public static long FindMaxPrimeFactor(long n)
        {
            long remainder = 0;
            long maxPrimeFactor = 1;
            var factorList = new List<long>();
            for (Int64 k = 2; k <= n; k++)
            {
                var tempN = n;                
                while (remainder == 0)
                {
                    tempN = Math.DivRem(tempN, k, out remainder);
                    if (remainder == 0)
                    {
                        if (factorList.Count==0 || factorList.Last() != k)
                        {
                            factorList.Add(k);
                        }
                        n = tempN;
                    }
                }
                remainder = 0;
            }

            if (factorList.Count == 0)
            {
                maxPrimeFactor = n;
            }
            else
            {
                maxPrimeFactor = factorList.Last();
            }            

            return maxPrimeFactor;
        }
    }
}
