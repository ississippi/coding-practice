using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    public class SolutionGetSum
    {
        public int GetSum(int a, int b)
        {
            while (a != 0)
            {
                int c = b & a;
                b = b ^ a;
                a = c << 1;
            }
            return b;
        }
        UInt32 GetSum2(UInt32 a, UInt32 b)
        {
            UInt32 carry = a & b;
            UInt32 result = a ^ b;
            while (carry != 0)
            {
                UInt32 shiftedcarry = carry << 1;
                carry = result & shiftedcarry;
                result ^= shiftedcarry;
            }
            return result;
        }
    }
}
