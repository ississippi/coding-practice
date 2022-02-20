using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    // 1756. Design Most Recently Used Queue - https://leetcode.com/problems/design-most-recently-used-queue/
    // Medium
    // Design a queue-like data structure that moves the most recently used element to the end of the queue.
    // Implement the MRUQueue class:
    // MRUQueue(int n) constructs the MRUQueue with n elements: [1,2,3,..., n].
    // int fetch(int k) moves the kth element(1-indexed) to the end of the queue and returns it.

    // Example 1:
    // Input:
    // ["MRUQueue", "fetch", "fetch", "fetch", "fetch"]
    // [[8], [3], [5], [2], [8]]
    // Output:
    // [null, 3, 6, 2, 2]

    // Explanation:
    // MRUQueue mRUQueue = new MRUQueue(8); // Initializes the queue to [1,2,3,4,5,6,7,8].
    // mRUQueue.fetch(3); // Moves the 3rd element (3) to the end of the queue to become [1,2,4,5,6,7,8,3] and returns it.
    // mRUQueue.fetch(5); // Moves the 5th element (6) to the end of the queue to become [1,2,4,5,7,8,3,6] and returns it.
    // mRUQueue.fetch(2); // Moves the 2nd element (2) to the end of the queue to become [1,4,5,7,8,3,6,2] and returns it.
    // mRUQueue.fetch(8); // The 8th element (2) is already at the end of the queue so just return it.
    internal class MostRecentlyUsedQueue1756
    {
        int[] q;
        public MostRecentlyUsedQueue1756(int n)
        {
            q = new int[n];
            for (int i = 0; i < n; i++)
            {
                q[i] = i+1;
            }
        }

        public int Fetch(int k)
        {
            if (k == q.Length)
                return q[q.Length-1];
            var kth = q[k-1];
            for (var i = k-1; i < q.Length-1; i++)
            {
                q[i] = q[i+1];
            }
            q[q.Length - 1] = kth;

            return kth;
        }
    }
}
