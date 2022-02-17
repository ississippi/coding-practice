using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class GroupShiftedStrings249
    {
        public IList<IList<string>> GroupStrings(string[] strings)
        {
            var alpha = "abcdefghijklmnopqrstuvwxyz";
            IList<IList<string>> results = new List<IList<string>>();

            foreach (var s in strings)
            {
                if (IsWordInResults(s, results))
                    continue;
                var resultSet = new List<string> { s };
                for (var i = 0; i < alpha.Length; i++)
                {
                    if (i + 1 + s.Length >= alpha.Length)
                        break;
                    if (alpha.Substring(i,s.Length) == s)
                    {
                        for (var j = i; j < alpha.Length - 1; j++)
                        {
                            if (j + 1 + s.Length > alpha.Length)
                                break;
                            var nextSubStr = alpha.Substring(j+1, s.Length);
                            foreach (var m in strings)
                            {
                                if (m == nextSubStr)
                                {
                                    resultSet.Add(nextSubStr);
                                }
                            }
                        }

                    }
                }
                results.Add(resultSet);
            }
            IList<IList<string>> ret = new List<IList<string>>();
            return (IList<IList<string>>)results;

        }

        public bool IsWordInResults(string word, IList<IList<string>> results)
        {
            foreach(var s in results)
            {
                foreach(var r in s)
                {
                    if(r == word)
                        return true;
                }
            }
            return false;
        }
    }
}
