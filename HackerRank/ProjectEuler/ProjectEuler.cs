using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class ProjectEulerFirst
    {

        public static void Calculate()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] resultArray = new int[t];

            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int dividedByThree, dividedByFive, dividedByFifteen, remainder;                

                dividedByThree = Math.DivRem(n-1, 3, out remainder);
                dividedByFive = Math.DivRem(n-1, 5, out remainder);
                dividedByFifteen = Math.DivRem(n-1, 15, out remainder);

                BigInteger sumThree = BigInteger.Multiply(dividedByThree, (dividedByThree + 1)) / 2;

                BigInteger sumFive = BigInteger.Multiply(dividedByFive, (dividedByFive + 1)) / 2;

                BigInteger sumFifteen = BigInteger.Multiply(dividedByFifteen, (dividedByFifteen + 1)) / 2;

                Console.WriteLine((sumThree*3)+(sumFive*5)-(sumFifteen*15));

                Console.ReadLine();
            }
            
        }
    }
}
