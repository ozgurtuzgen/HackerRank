using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day6_LetsReview
    {
        public static void Calculate()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string evenString = string.Empty;
            string oddString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var inputString = Console.ReadLine();
                oddString = string.Empty;
                evenString = string.Empty;

                for (int k = 0; k < inputString.Length; k = k + 2)
                {

                    //even
                    evenString += inputString[k];

                    // odd
                    if (k + 1 < inputString.Length)
                    {
                        oddString += inputString[k + 1];
                    }

                }
                Console.WriteLine(evenString + " " + oddString);
            }
        }
    }
}
