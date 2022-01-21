 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class FizzBuzz
    {

        public IList<string> DoFizzBuzz(int n)
        {
            var result = new List<string>();
            var max = Math.Pow(10, 4);
            if (n < 1 || n > max)
                return null;

            for (int num = 1; num <= n; num++)
            {
                bool divisibleBy3 = (num % 3 == 0);
                bool divisibleBy5 = (num % 5 == 0);
                var answerStr = string.Empty;

                if (divisibleBy3)
                {
                    answerStr += "Fizz";
                }
                if (divisibleBy5)
                {
                    answerStr += "Buzz";
                }
                if(String.IsNullOrEmpty(answerStr))
                {
                    answerStr += num.ToString();
                }
                result.Add(answerStr);
            }
            return result;

        }
    }
}
