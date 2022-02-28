using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    class MyKeyValuePair
    {
        public MyKeyValuePair(int timestamp, int count)
        {
            Timestamp = timestamp;
            Count = count;
        }
        public int Timestamp { get; set; } 
        public int Count { get; set; }   
    }
    internal class HitCounter362
    {
        // Design a hit counter which counts the number of hits received in the past 5 minutes(i.e., the past 300 seconds).
        // Your system should accept a timestamp parameter(in seconds granularity),
        // and you may assume that calls are being made to the system in chronological order
        // (i.e., timestamp is monotonically increasing).
        // Several hits may arrive roughly at the same time.
        // Implement the HitCounter class:
        // HitCounter() Initializes the object of the hit counter system.
        // void hit(int timestamp) Records a hit that happened at timestamp(in seconds).
        // Several hits may happen at the same timestamp.
        // int getHits(int timestamp) Returns the number of hits in the past 5 minutes from timestamp (i.e., the past 300 seconds).

        // Example 1:
        // Input
        // ["HitCounter", "hit", "hit", "hit", "getHits", "hit", "getHits", "getHits"]
        // [[], [1], [2], [3], [4], [300], [300], [301]]
        // Output
        // [null, null, null, null, 3, null, 4, 3]
        // Explanation
        // HitCounter hitCounter = new HitCounter();
        // hitCounter.hit(1);       // hit at timestamp 1.
        // hitCounter.hit(2);       // hit at timestamp 2.
        // hitCounter.hit(3);       // hit at timestamp 3.
        // hitCounter.getHits(4);   // get hits at timestamp 4, return 3.
        // hitCounter.hit(300);     // hit at timestamp 300.
        // hitCounter.getHits(300); // get hits at timestamp 300, return 4.
        // hitCounter.getHits(301); // get hits at timestamp 301, return 3.
        // Constraints:
        // 1 <= timestamp <= 2 * 109
        // All the calls are being made to the system in chronological order(i.e., timestamp is monotonically increasing).
        // At most 300 calls will be made to hit and getHits.
        /**
         * Your HitCounter object will be instantiated and called as such:
         * HitCounter obj = new HitCounter();
         * obj.Hit(timestamp);
         * int param_2 = obj.GetHits(timestamp);
         */
        private int total;
        private Queue<MyKeyValuePair> hits;

        public HitCounter362()
        {
            this.total = 0;
            hits = new Queue<MyKeyValuePair>();
        }

        public void Hit(int timestamp)
        {
            if (this.hits.Count == 0 || this.hits.Peek().Timestamp != timestamp)
            {
                // Insert the new timestamp with count = 1
                var initPair = new MyKeyValuePair(timestamp, 1);
                this.hits.Enqueue(initPair);
            }
            else
            {
                // Update the count of latest timestamp by incrementing the count by 1
                this.hits.Peek().Count++;
            }
            this.total++;
        }

        public int GetHits(int timestamp)
        {
            while (this.hits.Count != 0)
            {
                int diff = timestamp - this.hits.Peek().Timestamp;
                if (diff >= 300)
                {
                    // Decrement total by the count of the oldest timestamp
                    this.total -= this.hits.Peek().Count;
                    this.hits.Dequeue();
                }
                else break;
            }
            return this.total;
        }
    }

}
