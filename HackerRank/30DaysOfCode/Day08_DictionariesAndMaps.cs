using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day08_DictionariesAndMaps
    {
        public static void Calculate()
        {
            var entryCount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < entryCount; i++)
            {
                var entry = Console.ReadLine().Split(' ');

                phoneBook.Add(entry[0], entry[1]);                
            }

            for (int i = 0; i < entryCount; i++)
            {
                try
                {
                    var query = Console.ReadLine();

                    var result = phoneBook[query];
                                        
                    Console.WriteLine(query + "=" + result);
                    
                }
                catch (KeyNotFoundException ke)
                {
                    Console.WriteLine("Not found");
                }
                
            }

        }
    }
}
