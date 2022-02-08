using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    class LeetcodeContest279
    {

        // 6000. Sort Even and Odd Indices Independently
        // User Accepted:0
        // User Tried:0
        // Total Accepted:0
        // Total Submissions:0
        // Difficulty:Easy
        // You are given a 0-indexed integer array nums.Rearrange the values of nums according to the following rules:

        // Sort the values at odd indices of nums in non-increasing order.
        // For example, if nums = [4, 1, 2, 3] before this step, it becomes [4,3,2,1] after.The values at odd indices 1 and 3 are sorted in non-increasing order.
        // Sort the values at even indices of nums in non-decreasing order.
        // For example, if nums = [4, 1, 2, 3] before this step, it becomes [2,1,4,3] after.The values at even indices 0 and 2 are sorted in non-decreasing order.
        // Return the array formed after rearranging the values of nums.




        //Example 1:

        //Input: nums = [4, 1, 2, 3]
        //Output: [2,3,4,1]
        //Explanation: 
        //First, we sort the values present at odd indices (1 and 3) in non-increasing order.
        //So, nums changes from[4, 1, 2, 3] to [4,3,2,1].
        //Next, we sort the values present at even indices (0 and 2) in non-decreasing order.
        //So, nums changes from[4, 1, 2, 3] to [2,3,4,1].
        //Thus, the array formed after rearranging the values is [2,3,4,1].
        //Example 2:

        //Input: nums = [2, 1]
        //Output: [2,1]
        //Explanation: 
        //Since there is exactly one odd index and one even index, no rearrangement of values takes place.
        //The resultant array formed is [2,1], which is the same as the initial array.

        // Input:
        // [36,45,32,31,15,41,9,46,36,6,15,16,33,26,27,31,44,34]
        // Output:
        // [32,45,15,41,9,46,36,31,15,6,36,16,33,26,27,31,44,34]
        // Expected:
        // [9,46,15,45,15,41,27,34,32,31,33,31,36,26,36,16,44,6]
        public int[] SortEvenOdd(int[] nums)
        {
            if (nums.Length < 3)
                return nums;
            var swaps = true;
            while (swaps)
            {
                swaps = false;
                for (int i = 0; i < (nums.Length); i++)
                {
                    // Odd index - descending
                    if (i % 2 == 0)
                    {
                        if (i < nums.Length-2 && nums[i] > nums[i + 2])
                        {
                            swaps = true;
                            var temp = nums[i];
                            nums[i] = nums[i + 2];
                            nums[i + 2] = temp;
                        }
                    }
                    // Even Index - ascending
                    else
                    {
                        if (i < nums.Length - 2 && nums[i] < nums[i + 2])
                        {
                            swaps = true;
                            var temp = nums[i];
                            nums[i] = nums[i + 2];
                            nums[i + 2] = temp;
                        }
                    }
                }
            }
            return nums;
        }

        // 6001. Smallest Value of the Rearranged Number
        // User Accepted:5778
        // User Tried:6498
        // Total Accepted:5904
        // Total Submissions:11359
        // Difficulty:Medium
        
        // You are given an integer num.
        // Rearrange the digits of num such that its value is minimized and it does not contain any leading zeros.
        // Return the rearranged number with minimal value.

        // Note that the sign of the number does not change after rearranging the digits.

        // Example 1:
        // Input: num = 310
        // Output: 103
        // Explanation: The possible arrangements for the digits of 310 are 013, 031, 103, 130, 301, 310. 
        // The arrangement with the smallest value that does not contain any leading zeros is 103.

        // Example 2:
        // Input: num = -7605
        // Output: -7650
        // Explanation: Some possible arrangements for the digits of -7605 are -7650, -6705, -5076, -0567.
        // The arrangement with the smallest value that does not contain any leading zeros is -7650.
        public long SmallestNumber1(long num)
        {
            List<int> longList = new List<int>(); 
            while (num > 0) 
            {
                int add = (int)num % 10;
                longList.Add(add);
                num /= 10;
            }
            var resultList = new List<int>();
            for (int i = 0;i < longList.Count; i++)
            {
                var smallest = Int32.MinValue;
                for (int j = i + 1; j < longList.Count; j++)
                {
                    if (longList[j] < smallest)
                    {
                        smallest = longList[j];
                    }
                }
                resultList[i] = smallest;
            }
            var resStr = string.Empty;  
            foreach(var s in resultList)
            {
                resStr += s;
            }

            return long.Parse(resStr);
        }
        public long SmallestNumber(long num)
        {
            List<int> longList = new List<int>();
            while (num > 0)
            {
                int add = (int)num % 10;
                longList.Add(add);
                num /= 10;
            }
            longList.Sort();

            var resStr = string.Empty;
            foreach (var s in longList)
            {
                resStr += s;
            }

            return long.Parse(resStr);
        }

        //6003. Minimum Time to Remove All Cars Containing Illegal Goods
        //User Accepted:510
        //User Tried:1933
        //Total Accepted:560
        //Total Submissions:3464
        //Difficulty:Hard
        //You are given a 0-indexed binary string s which represents a sequence of train cars.s[i] = '0' denotes that the ith car does not contain illegal goods and s[i] = '1' denotes that the ith car does contain illegal goods.

        //As the train conductor, you would like to get rid of all the cars containing illegal goods.You can do any of the following three operations any number of times:


        //Remove a train car from the left end (i.e., remove s[0]) which takes 1 unit of time.
        //Remove a train car from the right end(i.e., remove s[s.length - 1]) which takes 1 unit of time.
        //Remove a train car from anywhere in the sequence which takes 2 units of time.
        //Return the minimum time to remove all the cars containing illegal goods.

        //Note that an empty sequence of cars is considered to have no cars containing illegal goods.




        //Example 1:


        //Input: s = "1100101"
        //Output: 5
        //Explanation: 
        //One way to remove all the cars containing illegal goods from the sequence is to
        //- remove a car from the left end 2 times.Time taken is 2 * 1 = 2.
        //- remove a car from the right end.Time taken is 1.
        //- remove the car containing illegal goods found in the middle. Time taken is 2.
        //This obtains a total time of 2 + 1 + 2 = 5. 


        //An alternative way is to
        //- remove a car from the left end 2 times.Time taken is 2 * 1 = 2.
        //- remove a car from the right end 3 times.Time taken is 3 * 1 = 3.
        //This also obtains a total time of 2 + 3 = 5.

        //5 is the minimum time taken to remove all the cars containing illegal goods. 
        //There are no other ways to remove them with less time.
        //Example 2:


        //Input: s = "0010"
        //Output: 2
        //Explanation:
        //One way to remove all the cars containing illegal goods from the sequence is to
        //- remove a car from the left end 3 times.Time taken is 3 * 1 = 3.
        //This obtains a total time of 3.


        //Another way to remove all the cars containing illegal goods from the sequence is to
        //- remove the car containing illegal goods found in the middle. Time taken is 2.
        //This obtains a total time of 2.


        //Another way to remove all the cars containing illegal goods from the sequence is to
        //- remove a car from the right end 2 times.Time taken is 2 * 1 = 2. 
        //This obtains a total time of 2.

        //2 is the minimum time taken to remove all the cars containing illegal goods. 
        //There are no other ways to remove them with less time.

        public int MinimumTime(string s)
        {
            return 0;
        }

    }

    // 6002. Design Bitset
    // User Accepted:2561
    // User Tried:5908
    // Total Accepted:2635
    // Total Submissions:15418
    // Difficulty:Medium
    // A Bitset is a data structure that compactly stores bits.

    // Implement the Bitset class:

    // Bitset(int size) Initializes the Bitset with size bits, all of which are 0.
    // void fix(int idx) Updates the value of the bit at the index idx to 1. If the value was already 1, no change occurs.
    // void unfix(int idx) Updates the value of the bit at the index idx to 0. If the value was already 0, no change occurs.
    // void flip() Flips the values of each bit in the Bitset.In other words, all bits with value 0 will now have value 1 and vice versa.
    // boolean all() Checks if the value of each bit in the Bitset is 1. Returns true if it satisfies the condition, false otherwise.
    // boolean one() Checks if there is at least one bit in the Bitset with value 1. Returns true if it satisfies the condition, false otherwise.
    // int count() Returns the total number of bits in the Bitset which have value 1.
    // String toString() Returns the current composition of the Bitset. Note that in the resultant string, the character at the ith index should coincide with the value at the ith bit of the Bitset.

    // Example 1:

    // Input
    // ["Bitset", "fix", "fix", "flip", "all", "unfix", "flip", "one", "unfix", "count", "toString"]
    // [[5], [3], [1], [], [], [0], [], [], [0], [], []]
    // Output
    // [null, null, null, null, false, null, null, true, null, 2, "01010"]

    // Explanation
    // Bitset bs = new Bitset(5); // bitset = "00000".
    // bs.fix(3);     // the value at idx = 3 is updated to 1, so bitset = "00010".
    // bs.fix(1);     // the value at idx = 1 is updated to 1, so bitset = "01010". 
    // bs.flip();     // the value of each bit is flipped, so bitset = "10101". 
    // bs.all();      // return False, as not all values of the bitset are 1.
    // bs.unfix(0);   // the value at idx = 0 is updated to 0, so bitset = "00101".
    // bs.flip();     // the value of each bit is flipped, so bitset = "11010". 
    // bs.one();      // return True, as there is at least 1 index with value 1.
    // bs.unfix(0);   // the value at idx = 0 is updated to 0, so bitset = "01010".
    // bs.count();    // return 2, as there are 2 bits with value 1.
    // bs.toString(); // return "01010", which is the composition of bitset.



    /**
     * Your Bitset object will be instantiated and called as such:
     * Bitset obj = new Bitset(size);
     * obj.Fix(idx);
     * obj.Unfix(idx);
     * obj.Flip();
     * bool param_4 = obj.All();
     * bool param_5 = obj.One();
     * int param_6 = obj.Count();
     * string param_7 = obj.ToString();
     */

    public class Bitset
    {

        public Bitset(int size)
        {

        }

        public void Fix(int idx)
        {

        }

        public void Unfix(int idx)
        {

        }

        public void Flip()
        {

        }

        public bool All()
        {

        }

        public bool One()
        {

        }

        public int Count()
        {

        }

        public string ToString()
        {

        }
    }
}
