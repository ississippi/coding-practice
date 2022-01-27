using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class ExcelColumns
    {
        public int TitleToNumber(string columnTitle)
        {
            uint sum = 0;
            var a = columnTitle.ToUpper().ToCharArray();
            var len = a.Length;
            for (int i = 0; i < len; i++)
            {
                sum = sum * 26;
                sum += GetCharacterValue(a[i]);
            }
            return (int)sum;
        }

        public uint GetCharacterValue(char c)
        {
            const uint A = (uint)'A';
            uint sum = (uint)c - A;
            return sum + 1;
        }
    }
}
