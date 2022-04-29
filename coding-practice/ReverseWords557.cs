using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class ReverseWords557
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(' ');
            StringBuilder res = new StringBuilder();
            for (var i = 0; i < words.Length; i++)
            {
                var reversedWord = reverseString(words[i]);
                res.Append(reversedWord + " ");
            }
            return res.ToString().Trim();
        }

        public string reverseString(string s)
        {
            StringBuilder res = new StringBuilder();
            for (var i = 0; i < s.Length; i++)
                res.Insert(0, s[i]);

            return res.ToString().Trim();
        }
    }
}
