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
            int n = 10;// Convert.ToInt32(Console.ReadLine());
            string evenString = string.Empty;
            string oddString = string.Empty;
            string evenStringLast = string.Empty;
            string oddStringLast = string.Empty;

            for (int i = 0; i < n; i++)
            {

                var inputString = string.Empty;// Console.ReadLine();
                for (int z = 0; z < 10000; z++)
                {
                    inputString += "a";
                }

                Console.WriteLine(DateTime.Now);

                oddString = string.Empty;
                evenString = string.Empty;
                oddStringLast = string.Empty;
                evenStringLast = string.Empty;
                string lastChar = string.Empty;
                var inputLength = inputString.Length;
                int remainder;

                int midIndex = Math.DivRem(inputLength, 2, out remainder);

                if(remainder == 1)
                {
                    lastChar = inputString.Last().ToString();
                    inputString = inputString.Substring(0, inputLength - 1);
                }


                for (int k = 0;k< midIndex; k++)
                {
                    if (k % 2 == 0)
                    {
                        //even
                        evenString += inputString.ElementAt(k);
                        oddStringLast = inputString.ElementAt(inputString.Length - 1 - k) + oddStringLast;

                    }
                    else
                    {
                        // odd
                        oddString += inputString.ElementAt(k);
                        evenStringLast = inputString.ElementAt(inputString.Length - 1 - k) + evenStringLast;

                    }
                }

                //Console.WriteLine(evenString + evenStringLast + lastChar + " " + oddString+oddStringLast);
            }
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();
        }
    }
}
