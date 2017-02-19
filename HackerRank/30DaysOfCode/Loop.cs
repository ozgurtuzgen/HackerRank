using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Loop
    {
        public static void Calculate()
        {
            int n = Convert.ToInt32( Console.ReadLine());

            for (int i=1; i <= 10; i++)
            {
                var result = i * n;

                Console.WriteLine("{0} x {1} = {2}", n, i, result);
            }

        }
    }
}
