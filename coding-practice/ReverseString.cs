using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class ReverseString
    {
        public void ReverseString2Pointers(char[] s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                char temp = s[left];
                s[left++] = s[right];
                s[right--] = temp;
            }
        }

        public void Swapper(char[] s, int left, int right)
        {
            if (left >= right) return;
            char tmp = s[left];
            s[left++] = s[right];
            s[right--] = tmp;
            Swapper(s, left, right);
        }

        public void ReverseStringRecursive(char[] s)
        {
            Swapper(s, 0, s.Length - 1);
        }
    }
}


