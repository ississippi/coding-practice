using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace coding_practice
{
    internal class BinaryNumbersHR
    {
        public static int BNRepeated(int n)
        {
            Console.WriteLine("Input n = " + n);
            var remainder = 0;
            var s = new Stack<int>();
            while (n > 0)
            {
                remainder = n % 2;
                n = n / 2;
                s.Push(remainder);
            }
            var lastInt = 0;
            var repeatingCount = 0;
            var maxRepeat = 0;
            var elements = s.Count;
            Debug.WriteLine("elements:" + elements);
            for (int i = 0; i < elements; i++)
            {
                var r = s.Pop();
                Debug.WriteLine("r:" + r);
                if (r == 0)
                {
                    repeatingCount = 0;
                }
                else // r == 1
                {
                    if (maxRepeat == 0)
                    {
                        // for the 1st '1' encountered.
                        repeatingCount = 1;
                        maxRepeat = 1;
                    }
                    else
                    {
                        if (repeatingCount == 0)
                            repeatingCount = 1;
                        else if (lastInt == 1)
                            repeatingCount++;
                        if (maxRepeat < repeatingCount)
                            maxRepeat = repeatingCount;
                    }
                }
                lastInt = r;
            }
            Debug.WriteLine("maxRepeat:" + maxRepeat);
            return maxRepeat;
        }

    }
}
