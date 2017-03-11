using HackerRank;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        HackerRank._30DaysOfCode.Day27_Testing.Calculate();
        //HackerRank.ProjectEuler._3_LargestPrimeFactor.Calculate();
        //HackerRank.DataStructures.Arrays.LeftRotation.Calculate();

        Console.ReadLine();
        //--------------------------DAY3------------------------------------------
        //int N = Convert.ToInt32(Console.ReadLine());

        //if (N < 1 || N > 100)
        //{
        //    throw new Exception("input values are out of range!");
        //}
        //else if (N % 2 == 1)
        //{
        //    Console.WriteLine("Weird");
        //}
        //else if (2 <= N && N <= 5)
        //{
        //    Console.WriteLine("Not Weird");
        //}
        //else if (6 <= N && N <= 20) {
        //    Console.WriteLine("Weird");
        //}
        //else
        //{
        //    Console.WriteLine("Not Weird");
        //}

        //Console.ReadLine();
        //-------------------------DAY2----------------------------------------------
        //double mealCost;
        //int tipPercent,taxPercent;

        //double totalCost;

        //NumberStyles styles = NumberStyles.Integer | NumberStyles.AllowDecimalPoint;

        //// Read meal cost.
        //if (!double.TryParse(Console.ReadLine(),styles, CultureInfo.InvariantCulture, out mealCost))
        //{
        //    Console.WriteLine("Wrong input parameter!");
        //    return;
        //}

        //// Read tip percent.
        //if (!int.TryParse(Console.ReadLine(), out tipPercent))
        //{
        //    Console.WriteLine("Wrong input parameter!");
        //    return;
        //}

        //// Read tax percent.
        //if (!int.TryParse(Console.ReadLine(), out taxPercent))
        //{
        //    Console.WriteLine("Wrong input parameter!");
        //    return;
        //}

        //totalCost = mealCost + (mealCost * tipPercent / 100) + (mealCost * taxPercent / 100);

        //Console.WriteLine("The total meal cost is {0} dollars", Math.Round(totalCost,0));

        //Console.ReadLine();

        //---------------------------DAY1-------------------------------------
        //int i = 4;
        //double d = 4.0;
        //string s = "HackerRank ";



        //// Declare second integer, double, and String variables.
        //int inputInt;
        //double inputDouble;
        //string inputString;

        //// Read and save an integer, double, and String to your variables.
        //if (!int.TryParse(Console.ReadLine(), out inputInt))
        //{
        //    Console.WriteLine("Wrong input parameter!");
        //    return;
        //}

        //if (!double.TryParse(Console.ReadLine(), out inputDouble))
        //{
        //    Console.WriteLine("Wrong input parameter!");
        //    return;
        //}

        //inputString = Console.ReadLine();

        //// Print the sum of both integer variables on a new line.

        //Console.WriteLine(inputInt + i);

        //// Print the sum of the double variables on a new line.

        //Console.WriteLine((inputDouble + d).ToString("N1"));

        //// Concatenate and print the String variables on a new line
        //// The 's' variable above should be printed first.

        //Console.WriteLine(s + inputString);

        //Console.ReadLine();

        //---------------------------------------------------------------------
        //int[][] arr = new int[6][];
        //for (int arr_i = 0; arr_i < 6; arr_i++)
        //{
        //    string[] arr_temp = Console.ReadLine().Split(' ');
        //    arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
        //}

        //int[] sumOfEachHourglass = new int[16];
        //int hourglassCount = 0;

        //for (int i = 0; i < 4; i++)
        //{

        //    for (int k = 0; k < 4; k++)
        //    {
        //        sumOfEachHourglass[hourglassCount] =    arr[i][k] + arr[i][k + 1] + arr[i][k + 2] +
        //                                                            arr[i + 1][k + 1] +
        //                                                arr[i + 2][k] + arr[i + 2][k + 1] + arr[i + 2][k + 2];
        //        hourglassCount++;
        //    }
        //}

        //Console.WriteLine(sumOfEachHourglass.Max().ToString());
        //Console.ReadLine();

    }
}