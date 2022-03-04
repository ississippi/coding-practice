using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class MinRemoveToMakeValid1249
    {
        // 1249. Minimum Remove to Make Valid Parentheses
        // Medium
        // Given a string s of '(' , ')' and lowercase English characters.
        // Your task is to remove the minimum number of parentheses ( '(' or ')', in any positions)
        // so that the resulting parentheses string is valid and return any valid string.
        // Formally, a parentheses string is valid if and only if:
        // It is the empty string, contains only lowercase characters, or
        // It can be written as AB(A concatenated with B), where A and B are valid strings, or
        // It can be written as (A), where A is a valid string.
        // Example 1:
        // Input: s = "lee(t(c)o)de)"
        // Output: "lee(t(c)o)de"
        // Explanation: "lee(t(co)de)" , "lee(t(c)ode)" would also be accepted.
        // Example 2:
        // Input: s = "a)b(c)d"
        // Output: "ab(c)d"
        // Example 3:
        // Input: s = "))(("
        // Output: ""
        // Explanation: An empty string is also valid.
        // Constraints:
        // 1 <= s.length <= 105
        // s[i] is either'(' , ')', or lowercase English letter.

        public string MinRemoveToMakeValid(string s)
        {
            var indexesToRemove = new HashSet<int>();
            var stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                if (s[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        indexesToRemove.Add(i);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            // Put any indexes remaining on stack into the set.
            while (stack.Count != 0) indexesToRemove.Add(stack.Pop());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (!indexesToRemove.Contains(i))
                {
                    sb.Append(s[i]);
                }
            }
            return sb.ToString();
        }

    }
}
