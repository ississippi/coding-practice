﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
 // Definition for singly-linked list.
    internal class Palindromes
    {

        // Copy the LinkedList to an array, then copy the array in reverse to another array and compare.
        public bool isPalindrome(ListNode head)
        {
            if (head == null)
                return false;
            List<int> inputLL = new List<int>();
            var curr = head;
            while (curr != null)
            {
                inputLL.Add(curr.val);
                curr = curr.next;
            }

            List<int> revLL = new List<int>();
            for(int i = inputLL.Count - 1; i >= 0; i--)
            {
                revLL.Add(inputLL[i]);
            }

            for (int i = 0; i < inputLL.Count; i++)
            {
                if (inputLL[i] != revLL[i])
                    return false;
            }
            return true;
        }

        public bool IsPalindromeNumber(int x)
        {
            // To be a Palindrome, x must be > 0. 
            // If the last digit is 0, it cannot be a Palindrome due to no leading zeros.
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;
            int[] digits = x.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
            int p1 = 0;
            int p2 = digits.Count() - 1;

            while (p1 < p2)
            {
                if (digits[p1] != digits[p2])
                    return false;
                p1++;
                p2--;
            }
            return true;

            // time: O(n) space: O(1)
        }

        // Leetcode Editorial Solution
        // Intuition

        // The first idea that comes to mind is to convert the number into string, and check if the string is a palindrome,
        // but this would require extra non-constant space for creating the string which is not allowed
        // by the problem description.
        // Second idea would be reverting the number itself, and then compare the number with original number,
        // if they are the same, then the number is a palindrome. However, if the reversed number is larger than int.MAX,
        // we will hit integer overflow problem.
        // Following the thoughts based on the second idea, to avoid the overflow issue of the reverted number,
        // what if we only revert half of the int number? After all, the reverse of the last half of the palindrome
        // should be the same as the first half of the number, if the number is a palindrome.
        // For example, if the input is 1221, if we can revert the last part of the number "1221" from "21" to "12",
        // and compare it with the first half of the number "12", since 12 is the same as 12, we know that
        // the number is a palindrome.
        // Let's see how we could translate this idea into an algorithm.

        // Algorithm

        // First of all we should take care of some edge cases. All negative numbers are not palindrome,
        // for example: -123 is not a palindrome since the '-' does not equal to '3'. So we can return false for all negative numbers.
        // Now let's think about how to revert the last half of the number. For number 1221, if we do 1221 % 10,
        // get the last digit 1, to get the second to the last digit, we need to remove the last digit from 1221,
        // we could do so by dividing it by 10, 1221 / 10 = 122. Then we can get the last digit again by doing a modulus by 10,
        // 122 % 10 = 2, and if we multiply the last digit by 10 and add the second last digit, 1 * 10 + 2 = 12,
        // it gives us the reverted number we want. Continuing this process would give us the reverted number with more digits.
        // Now the question is, how do we know that we've reached the half of the number?
        // Since we divided the number by 10, and multiplied the reversed number by 10,
        // when the original number is less than the reversed number, it means we've processed half of the number digits.
        // time: O(log(n)) space O(1)
        public bool IsPalindromeNumberRevertedAlgo(int x)
        {
            // Special cases:
            // As discussed above, when x < 0, x is not a palindrome.
            // Also if the last digit of the number is 0, in order to be a
            // palindrome, the first digit of the number also needs to be 0. Only 0
            // satisfy this property.
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            // When the length is an odd number, we can get rid of the middle digit
            // by revertedNumber/10 For example when the input is 12321, at the end
            // of the while loop we get x = 12, revertedNumber = 123, since the
            // middle digit doesn't matter in palidrome(it will always equal to
            // itself), we can simply get rid of it.
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
