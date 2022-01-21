using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class ReverseVowels
    {
        public char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        public string Reverse(string s)
        {
            if (s.Length < 2)
                return s;
            var left = 0;
            var right = s.Length - 1;
            char[] arr = s.ToCharArray(0, s.Length);
            while (left <= right)
            {
                while (!IsVowel(arr[left]))
                {
                    left++;
                    if (left >= right)
                        break;
                }
                if (left >= right)
                    break;
                while (!IsVowel(arr[right]))
                {
                    right--;
                    if (left >= right)
                        break;
                }
                SwapVowels(left++, right--, arr);
            }
            return new string(arr);
        }

        public bool IsVowel(char c)
        {
            for (int i = 0; i < vowels.Length; i++)
            {
                if (c == vowels[i])
                    return true;
            }
            return false;
        }

        public void SwapVowels(int left, int right, char[] s)
        {
            var temp = s[left];
            s[left] = s[right];
            s[right] = temp;

        }
    }
}
