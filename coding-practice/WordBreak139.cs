using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class WordBreak139
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            foreach (var w in wordDict)
            {
                if (w.Length <= s.Length)
                {
                    if (w == s.Substring(0, w.Length))
                    {
                        if (WordBreak(s.Substring(w.Length), wordDict) == true)
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
