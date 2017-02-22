using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day10_BinaryNumbers
    {
        public static void Calculate()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            int remainder = 0;
            int consecutive_one_count = 0;
            int max_one = 0;
            while (n > 0)
            {
                n = Math.DivRem(n, 2, out remainder);

                if(remainder == 0)
                {
                    if (max_one < consecutive_one_count)
                    {
                        max_one = consecutive_one_count;
                    }
                    consecutive_one_count = 0;
                }
                else
                {
                    consecutive_one_count++;
                }
            }
            if (consecutive_one_count>max_one)
            {
                max_one = consecutive_one_count;
            }

            Console.WriteLine(max_one);
        }
    }
}
