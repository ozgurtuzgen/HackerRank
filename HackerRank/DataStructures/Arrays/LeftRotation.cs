using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructures.Arrays
{
    public static class LeftRotation
    {
        public static void Calculate()
        {
            var temp_arr = Console.ReadLine().Split(' ');
            var array = Console.ReadLine().Split(' ');

            int[] new_array = new int[Convert.ToInt32(temp_arr[0])];
            int rotate_count = Convert.ToInt32(temp_arr[1]);



            for (int i = 0; i < array.Length; i++)
            {
                var index = (i + rotate_count) % array.Length;
                new_array[i] = Convert.ToInt32( array[index]);                
            }

            for (int i = 0; i < new_array.Length; i++)
            {
                Console.Write(new_array[i].ToString() + " ");

            }
        }
    }
}
