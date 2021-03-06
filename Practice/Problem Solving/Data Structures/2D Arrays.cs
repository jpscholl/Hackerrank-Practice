
/*
//  Author: Jonathan Scholl
//  Date: 9/8/2021
//  Exercise: Hackerrank 30 days of coding day 11
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> numArray = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                numArray.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrayTemp => Convert.ToInt32(arrayTemp)).ToList());
            }

            int[] sum = new int[16];
            int h = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum[h] = numArray[i][j] + numArray[i][j + 1] + numArray[i][j + 2]
                            + numArray[i + 1][j + 1] + numArray[i + 2][j] + numArray[i + 2][j + 1]
                            + numArray[i + 2][j + 2];
                    h++;
                }
            }
            Array.Sort(sum);
            Console.WriteLine(sum[15]);
        }
    }
}
