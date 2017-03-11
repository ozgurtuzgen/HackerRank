using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day27_Testing
    {
        public static void Calculate()
        {
            Random r = new Random();
            //var testCaseCount = r.Next(0, 5);
            var testCaseCount = 5;

            Console.Write(testCaseCount);
            //var n = r.Next(3, 200);

            var n = 5;

            for (int i = 0; i < testCaseCount; i++)
            {
                Console.WriteLine();
                var k = r.Next(1, n);
                Console.WriteLine(n + " " + k);

                var A = new int[n];
                A[0] = -1;
                Console.Write(A[0] + " ");
                A[1] = 0;
                Console.Write(A[1] + " ");
                A[2] = 1;
                Console.Write(A[2] + " ");

                for (int z = 3; z < A.Length; z++)
                {
                    A[z] = r.Next(-1000, 1000);
                    Console.Write(A[z] + " ");
                }
                n++;
            }
        }
    }
}
