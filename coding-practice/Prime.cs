using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class Prime
    {
        static bool IsPrime(int n)
        {
            // Optimized primality test: check divisors only up to the square root
            if (n == 1)
                return false;
            if (n <= 3)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;
            for (int i = 5; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        //static void CheckIsPrime(String[] args)
        //{
        //    /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //    var nbr = Int32.Parse(Console.ReadLine());

        //    for (int i = 0; i < nbr; i++)
        //    {
        //        var numToCheck = Int32.Parse(Console.ReadLine());
        //        Console.WriteLine((IsPrime(numToCheck)) ? "Prime" : "Not prime");
        //    }
        //}




    }
}
