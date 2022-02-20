using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class LeetcodeContest281
    {

        //
        // 2180. Count Integers With Even Digit Sum https://leetcode.com/contest/weekly-contest-281/problems/count-integers-with-even-digit-sum/
        // Easy
        // Given a positive integer num, return the number of positive integers less than or equal to num whose digit sums are even.
        // The digit sum of a positive integer is the sum of all its digits.

        // Example 1:
        // Input: num = 4
        // Output: 2
        // Explanation:
        // The only integers less than or equal to 4 whose digit sums are even are 2 and 4.    

        // Example 2:
        // Input: num = 30
        // Output: 14
        // Explanation:
        // The 14 integers less than or equal to 30 whose digit sums are even are
        // 2, 4, 6, 8, 11, 13, 15, 17, 19, 20, 22, 24, 26, and 28.
        public int CountEven(int num)
        {
            var count = 0;
            for (var i = 1; i <= num; i++)
            {
                var strNum = i.ToString();
                if (strNum.Length == 1)
                {
                    if (i % 2 == 0)
                        count++;
                    continue;
                }
                char[] vs = strNum.ToCharArray();
                var sum = 0;
                for (var j = 0; j < vs.Length; j++)
                {
                    sum += (int)Char.GetNumericValue(vs[j]);
                }
                if (sum % 2 == 0)
                    count++;
            }


            return count;
        }

        //
        // 6013. Merge Nodes in Between Zeros https://leetcode.com/contest/weekly-contest-281/problems/merge-nodes-in-between-zeros/
        //
        // You are given the head of a linked list, which contains a series of integers separated by 0's. The beginning and end of the linked list will have Node.val == 0.
        // For every two consecutive 0's, merge all the nodes lying in between them into a single node whose value is the sum of all the merged nodes.
        // The modified list should not contain any 0's.
        // Return the head of the modified linked list.
        //
        // Definition for singly-linked list.
         public class ListNode {
              public int val;
              public ListNode next;
              public ListNode(int val=0, ListNode next=null) {
                  this.val = val;
                  this.next = next;
              }
          }
         
        public ListNode MyMergeNodes(ListNode head)
        {
            ListNode saveNode = null;
            ListNode lastSumNode = null;
            ListNode prev = null;
            ListNode curr = head;
            var currentSum = 0;
            while (curr != null)
            {
                if (curr.val == 0)
                {
                    if (lastSumNode == null)
                    {
                        lastSumNode = curr;
                    }
                    else
                    {
                        lastSumNode = new ListNode(0, null);
                    }
                    while (curr.next != null)
                    {
                        curr = curr.next;
                        if (curr.val == 0)
                        {
                            lastSumNode.val = currentSum;
                            lastSumNode.next = curr.next;
                            break;
                        }
                        else
                        {
                            currentSum += curr.val;
                        }
                        curr = curr.next;
                    }
                    currentSum = 0;
                }
            }
            return head;
        }

        // Leetcode community answer from C++ https://leetcode.com/problems/merge-nodes-in-between-zeros/discuss/1784898/C%2B%2B-or-Easy-to-understand-or-Linked-List
        ListNode MergeNodes(ListNode head)
        {
            ListNode res = new ListNode(0);
            ListNode ret = res;
            int sm = 0;
            head = head.next;

            while (head != null)
            {
                if (head.val == 0)
                {
                    res.next = new ListNode(sm);
                    res = res.next;
                    sm = 0;
                }
                else
                {
                    sm += head.val;
                }
                head = head.next;
            }

            return ret.next;
        }

        // 2183. Count Array Pairs Divisible by K
        // Hard
        // Given a 0-indexed integer array nums of length n and an integer k, return the number of pairs(i, j) such that:
        // 0 <= i<j <= n - 1 and
        // nums[i] * nums[j] is divisible by k.

        // Example 1:
        // Input: nums = [1, 2, 3, 4, 5], k = 2
        // Output: 7
        // Explanation: 
        // The 7 pairs of indices whose corresponding products are divisible by 2 are
        // (0, 1), (0, 3), (1, 2), (1, 3), (1, 4), (2, 3), and(3, 4).
        // Their products are 2, 4, 6, 8, 10, 12, and 20 respectively.
        // Other pairs such as (0, 2) and(2, 4) have products 3 and 15 respectively, which are not divisible by 2.    

        // Example 2:
        // Input: nums = [1,2,3,4], k = 5
        // Output: 0
        // Explanation: There does not exist any pair of indices whose corresponding product is divisible by 5.

        // This fails on the test with 20,000 plus input nums
        public long CoutPairs(int[] nums, int k)
        {
            var pairCount = 0;  
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if ((nums[i] * nums[j]) % k == 0)
                        pairCount++;
                }
            }
            return pairCount;
        }

        //This problem is similar to an easy problem from today's biweekly (2176. Count Equal and Divisible Pairs in an Array).
        //A brute-force solution is accepted for the easy problem(inputs are limited to 1000). This one is hard, so we must do better than O(n* n).
        //Intuition
        //A number with a factor i will form a pair with a number with a factor j if i* j is divisible by k.
        //It can be shown that if n1* n2 % k == 0, then gcd(n1, k) * gcd(n2, k) % k == 0.

        //Approach 1: Count GCDs
        //Track count of each GCD we encountered so far in a map.For each number, check its GCD agains all previous GCDs.


        // Community solution - https://leetcode.com/problems/count-array-pairs-divisible-by-k/discuss/1784721/Count-GCDs
        //long long countPairs(vector<int>& nums, int k)
        //{
        //    long long res = 0;
        //    unordered_map<int, int> gcds;
        //    for (int n : nums)
        //    {
        //        long long gcd_i = gcd(n, k);
        //        for (auto[gcd_j, cnt] : gcds)
        //            res += gcd_i * gcd_j % k ? 0 : cnt;
        //        ++gcds[gcd_i];
        //    }
        //    return res;
        //}
    }
}
