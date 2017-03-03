using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HackerRank._30DaysOfCode.Day19_Interfaces;

namespace HackerRank._30DaysOfCode
{
    public static class Day19_Interfaces
    {
        public static void Calculate()
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }

        public interface AdvancedArithmetic
        {
            int divisorSum(int n);
        }
    }

    class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
