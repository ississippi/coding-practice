using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class NextClosestTime681
    {
        // 681. Next Closest Time
        // Medium
        // Given a time represented in the format "HH:MM", form the next closest time by reusing the current digits.There is no limit on how many times a digit can be reused.
        // You may assume the given input string is always valid.For example, "01:34", "12:09" are all valid. "1:34", "12:9" are all invalid.

        // Example 1:
        // Input: time = "19:34"
        // Output: "19:39"
        // Explanation: The next closest time choosing from digits 1, 9, 3, 4, is 19:39, which occurs 5 minutes later.
        // It is not 19:33, because this occurs 23 hours and 59 minutes later.

        // Example 2:
        // Input: time = "23:59"
        // Output: "22:22"
        // Explanation: The next closest time choosing from digits 2, 3, 5, 9, is 22:22.
        // It may be assumed that the returned time is next day's time since it is smaller than the input time numerically.
        public string NextClosestTime(string time)
        {
            // hours 00 - 23 minutes 01 - 59
            // numbers can be reuses, all numbers do not have to be used.
            // next lowest = minutes in the same hour greater than input minutes
            // Approach - add each input number to minutes saving the lowest value
            var inputHour = Int32.Parse(time.Substring(0, 2));
            var inputMinutes = Int32.Parse(time.Substring(3, 2));
            List<int> numbers = new List<int>();    
            numbers.Add(Int32.Parse(time.Substring(0, 1)));
            numbers.Add(Int32.Parse(time.Substring(1, 1)));
            numbers.Add(Int32.Parse(time.Substring(3, 1)));
            numbers.Add(Int32.Parse(time.Substring(4, 1)));

            numbers.Sort();


            return string.Empty;
        }
    }
}
