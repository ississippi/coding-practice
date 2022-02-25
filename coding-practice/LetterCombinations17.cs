using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class LetterCombinations17
    {
        new Dictionary<int, string[]> keyMap;
        public LetterCombinations17()
        {
            keyMap = new Dictionary<int, string[]>();
            keyMap.Add(2, new string[] { "a", "b", "c" });
            keyMap.Add(3, new string[] { "d", "e", "f" });
            keyMap.Add(4, new string[] { "g", "h", "i" });
            keyMap.Add(5, new string[] { "j", "k", "l" });
            keyMap.Add(6, new string[] { "m", "n", "o" });
            keyMap.Add(7, new string[] { "p", "q", "r", "s" });
            keyMap.Add(8, new string[] { "t", "u", "v" });
            keyMap.Add(9, new string[] { "w", "x", "y", "z" });
        }

        public IList<string> LetterCombinations(string digits)
        {
            var ans = new List<string>();
            var digitStrings = new List<string>();
            for(int i = 0; i < digits.Length; i++)
            {
                var k = digits[i];
                var l = k.ToString();
                foreach(var c in keyMap[Int32.Parse(l)])
                {
                    digitStrings.Add(c);
                }
            }
            var strArray = digitStrings.ToArray();
            for(var i = 0; i < strArray.Length; i++)
            {
                var ansChar1 = strArray[i];
                for (var j = i+1; j < strArray.Length; j++)
                {
                    ans.Add(ansChar1 + strArray[j]);
                }
            }
             return ans;
        }
    }
}
