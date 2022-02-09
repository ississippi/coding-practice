using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class FindTheDifference389
    {
        public char FindTheDifference(string s, string t)
        {
            if (s.Length == 0)
                return (char)t[0];
            var dicS = new Dictionary<char, int>();
            foreach(char c in s)
            {
                if(dicS.ContainsKey(c))
                {
                    dicS[c]++;   
                }
                else
                {
                    dicS.Add(c, 1);  
                }
            }
            var dicT = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (dicT.ContainsKey(c))
                {
                    dicT[c]++;
                }
                else
                {
                    dicT.Add(c, 1);
                }
            }
            foreach(char c in dicS.Keys)
            {
                if (!dicT.ContainsKey(c))
                    return c;
                if(dicS[c] != dicT[c])
                    return c;
            }
            foreach(var c in dicT.Keys)
            {
                if (!dicS.ContainsKey(c))
                    return c;
            }
            return '0';
        }
    }
}
