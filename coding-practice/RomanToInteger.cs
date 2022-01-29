using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class RomanToInteger
    {
        Dictionary<string, int> romanNumeralValues
            = new Dictionary<string, int>();
        Dictionary<string, string> minusNumerals
            = new Dictionary<string, string>();
        public RomanToInteger()
        {
            romanNumeralValues.Add("I", 1);
            romanNumeralValues.Add("V", 5);
            romanNumeralValues.Add("X", 10);
            romanNumeralValues.Add("L", 50);
            romanNumeralValues.Add("C", 100);
            romanNumeralValues.Add("D", 500);
            romanNumeralValues.Add("M", 1000);

            minusNumerals.Add("I", "VX");
            minusNumerals.Add("X", "LC");
            minusNumerals.Add("C", "DM");
        }
        string[] Minus = new string[] {"I", "X", "C"};

        public int RomanToInt(string romanNumber)
        {
            var sum = 0;
            var numerals = romanNumber.ToArray();
            for(int i = 0; i < numerals.Length; i++)
            {
                var rn = numerals[i].ToString();
                if (i + 1 >= numerals.Length)
                {
                    sum += romanNumeralValues[rn];
                }
                else if (minusNumerals.ContainsKey(rn))
                {
                    var next = numerals[i + 1].ToString();
                    var followers = minusNumerals[rn];  
                    if (followers.Contains(next))
                    {
                        sum += romanNumeralValues[next] - romanNumeralValues[rn];
                        i++;
                    }
                    else 
                    {
                        sum += romanNumeralValues[rn];
                    }
                }
                else
                {
                    sum += romanNumeralValues[rn];
                }

            }
            return sum;
        }
        // Main diff is this answer uses the fact that you subtract whenever the current symbol vallue is less than 
        // than the value of the next symbol, so no need for the 'minusNumerals' dictionary above and related logic.
        public int RomanToIntLeetCodeAnswer(string s)
        {

            int sum = 0;
            int i = 0;
            while (i < s.Length)
            {
                string currentSymbol = s.Substring(i, 1);  // substrings instead of turning into an array
                int currentValue = romanNumeralValues[currentSymbol];
                int nextValue = 0;
                if (i + 1 < s.Length)
                {
                    var nextSymbol = s.Substring(i + 1, 1); // substrings instead of turning into an array
                    nextValue = romanNumeralValues[nextSymbol];
                }

                if (currentValue < nextValue)
                {
                    sum += (nextValue - currentValue);
                    i += 2;
                }
                else
                {
                    sum += currentValue;
                    i += 1;
                }

            }
            return sum;
        }
    }
}
