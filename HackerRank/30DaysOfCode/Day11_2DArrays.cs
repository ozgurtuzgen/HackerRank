using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day11_2DArrays
    {
        public static void Calculate()
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            Console.WriteLine(FindMaxSumOfHourglasses(arr));
        }

        private static int FindMaxSumOfHourglasses(int[][] arr)
        {
            int maxSum = -60;
            for (int i = 0; i < arr.GetLength(0)-2; i++)
            {
                for (int k = 0; k < arr[0].Length-2; k++)
                {
                    var tempSum =  arr[i][k] + arr[i][k+1] + arr[i][k+2]
                                    + arr[i + 1][k + 1] +
                          arr[i+2][k] + arr[i + 2][k + 1] + arr[i + 2][k + 2];

                    if (maxSum < tempSum)
                    {
                        maxSum = tempSum;
                    }
                }

            }

            return maxSum;
        }
    }
}
