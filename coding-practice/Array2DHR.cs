using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace coding_practice
{
    internal class Array2DHR
    {
        public static int MaxHourGlassValue(int[][] arr)
        {
            var maxHGValue = 0;
            var currentHGValue = 0;
            for (int row = 0; row < 4; row++)
            {
                for(int col = 0; col < 4; col++)
                {
                    currentHGValue = HourGlassValue(arr, row, col);
                    if (row == 0 && col == 0)
                        maxHGValue = currentHGValue;
                    else if (currentHGValue > maxHGValue)
                        maxHGValue = currentHGValue;
                }
            }
            Debug.WriteLine($"MaxHourglassValue:" + maxHGValue);
            return maxHGValue;

        }
        public static int HourGlassValue(int[][] arr, int beginRow, int beginCol)
        {

            var currentHGValue = 0;
            // One Hourglass
            for (int j = beginRow; j < beginRow+3; j++)
            {
                for (int k = beginCol; k < beginCol+3; k++)
                {
                    //Debug.WriteLine($"Value at [{j}][{k}]: " + arr[j][k]);
                    if (j == beginRow + 1)
                    {
                        if (k == beginCol + 1)
                            currentHGValue += arr[j][k];
                    }
                    else
                    {
                        currentHGValue += arr[j][k];
                    }
                }
            }
            Debug.WriteLine($"Hourglass[{beginRow}][{beginCol}] value:" + currentHGValue);
            return currentHGValue;
        }
    }
}
