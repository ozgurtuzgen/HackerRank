using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProjectEuler
{
    public static class _2_EvenFibonacciNumbers
    {
        public static void Calculate()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(SumEvenFibonacci(n));
            }
        }


        public static long SumEvenFibonacci(long limit)
        {
            long first = 1;
            long second = 2;
            long sum = 0;

            while (second < limit)
            {
                if (second % 2 == 0)
                {
                    sum += second;
                }

                var temp_second = first + second;
                first = second;
                second = temp_second;
            }
            
            return sum;
        }
    }
}
