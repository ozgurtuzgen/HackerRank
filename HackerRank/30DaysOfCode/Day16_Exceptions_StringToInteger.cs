using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day16_Exceptions_StringToInteger
    {
        public static void Calculate()
        {
            try
            {
                string S = Console.ReadLine();
                Console.WriteLine(Convert.ToInt32(S));
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
