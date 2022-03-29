using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    public class Fibonacci
    {
        public int FibonacciIterative(int n)
        {
            var arr = new List<int>();
            arr.Add(0);
            arr.Add(1);
            for (int i = 2; i <= n + 1; i++)
            {
                arr.Add(arr[i - 2] + arr[i - 1]);
                Console.Write(arr[i - 2] + arr[i - 1] + ",");
            }
            return arr[n];
        }

        public int FibonacciRecursive(int n)
        {
            if (n < 2)
            {
                return n;
            }
            Console.Write(n + ",");
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public int Fib(int n)
        {
            var currentPos = 2;
            var fibValues = new List<int>() { 0, 1 };
            for (var i = 2; i <= n; i++)
            {
                var currentVal = fibValues[i - 1] + fibValues[i - 2];
                fibValues.Add(currentVal);
            }
            return fibValues[n];
        }
    }
}
