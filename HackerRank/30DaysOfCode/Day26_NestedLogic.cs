using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day26_NestedLogic
    {
        public static void Calculate()
        {
            int[] actuals = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[] expecteds = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            
                       
            if (actuals[2] > expecteds[2])
            {
                Console.WriteLine(10000);
            }
            else if(actuals[1] > expecteds[1] && actuals[2] == expecteds[2])
            {
                var fine = (actuals[1] - expecteds[1]) * 500;

                Console.WriteLine(fine);
            }
            else if (actuals[0] > expecteds[0] && actuals[2] == expecteds[2] && actuals[1] == expecteds[1])
            {
                var fine = (actuals[0] - expecteds[0]) * 15;

                Console.WriteLine(fine);
            }
            else
            {
                Console.WriteLine(0);
            }
        }


    }
}
