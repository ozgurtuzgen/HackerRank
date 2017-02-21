using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.Arrays
{
    public static class DynamicArray
    {
        public static void Calculate()
        {

            int x, y, queryNumber,lastAns = 0;
            string[] arr_temp = Console.ReadLine().Split(' ');

            int seq_count = Convert.ToInt32(arr_temp[0]);

            int arr_count = Convert.ToInt32(arr_temp[1]);

            List<List<int>> wholeArray = new List<List<int>>();

            for (int i = 0; i < seq_count; i++)
            {
                wholeArray.Add(new List<int>());
            }

            //read each query
            for (int i = 0; i < arr_count; i++)
            {
                arr_temp = Console.ReadLine().Split(' ');
                queryNumber = Convert.ToInt32(arr_temp[0]);
                x = Convert.ToInt32(arr_temp[1]);
                y = Convert.ToInt32(arr_temp[2]);

                if (queryNumber == 1)
                {
                    var result = (x ^ lastAns) % seq_count;

                    wholeArray[result].Add(y);
                }
                else if (queryNumber == 2)
                {
                    var result = (x ^ lastAns) % seq_count;
                    var index = y % wholeArray[result].Count;

                    lastAns = wholeArray[result][index];

                    Console.WriteLine(lastAns);
                }
                else
                {
                    throw new Exception("Wrong input parameter!");
                }

            }

            Console.ReadLine();
        }    
    }
}