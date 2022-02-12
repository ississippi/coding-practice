using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class RohanMockInterview20220212
    {
        public Dictionary<string, int> GetWordFrequency(string[] words)
        {
            var seen = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!seen.ContainsKey(word))
                    seen.Add(word, 1);
                else
                    seen[word]++;
            }

            return seen;
        }

        public Dictionary<string, int> GetWordFrequencyR(string[] words, int i, Dictionary<string, int> seen)
        {
            if (i >= words.Length)  
                return seen;
            if (!seen.ContainsKey(words[i]))
                seen.Add(words[i], 1);
            else
                seen[words[i]]++;
            i++;
            return GetWordFrequencyR(words, i, seen);
        }
    }
}
