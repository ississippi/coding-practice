using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class RecursionHackerrank
    {
        /*
         * Complete the 'factorial' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER n as parameter.
         */

        public static int factorial(int n)
        {
            if (n <= 1)
                return 1;
            return n * (RecursionHackerrank.factorial(n - 1));
        }
    }
}
