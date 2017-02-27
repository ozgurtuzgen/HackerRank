using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day14_Scope
    {
        public static void Calculate()
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }

        class Difference
        {
            private int[] elements;
            public int maximumDifference;
            public Difference(int[] elements)
            {
                this.elements = elements;
            }

            public void computeDifference()
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    for (int k = 0; k < elements.Length; k++)
                    {
                        var temp = Math.Abs(this.elements[i] - this.elements[k]);
                        if (temp > maximumDifference)
                        {
                            maximumDifference = temp;
                        }
                    }
                }
            }
        }
    }
}