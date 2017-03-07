using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30DaysOfCode
{
    public static class Day20_Sorting
    {
        public static void Calculate()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            var count = BubbleSort(ref a);

            Console.WriteLine("Array is sorted in {0} swaps.", count);

            Console.WriteLine("First Element: {0}", a[0]);

            Console.WriteLine("Last Element: {0}", a[n-1]);

        }

        public static int BubbleSort(ref int[] a)
        {
            int numberOfSwaps = 0;
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                // Track number of elements swapped during a single array traversal
                

                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                        numberOfSwaps++;
                    }
                }

                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }
            
            return numberOfSwaps;
        }
    }
}
