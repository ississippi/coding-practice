using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{

    public static class Util
    {
        public static void PrintList(List<int> p)
        {
            Console.WriteLine();
            foreach (var a in p)
            {
                Console.Write(a);
            }
        }
        public static void PrintList(string title, IList<string> p)
        {
            Console.WriteLine(title);
            Console.WriteLine();
            for (int i = 0; i < p.Count; i++)
            {
                if (i < p.Count - 1)
                    Console.Write(p[i] + ",");
                else
                {
                    Console.Write(p[i]);
                    Console.WriteLine();
                }
            }
        }
        public static void PrintList(string title, IList<long> p)
        {
            Console.WriteLine(title);
            Console.WriteLine();
            for (int i = 0; i < p.Count; i++)
            {
                if (i < p.Count - 1)
                    Console.Write(p[i] + ",");
                else
                {
                    Console.Write(p[i]);
                    Console.WriteLine();
                }
            }
        }

        public static void PrintArray(string title, int[] p)
        {
            Console.WriteLine(title);   
            for (int i = 0; i < p.Length; i++)
            {
                if (i < p.Length - 1) 
                    Console.Write(p[i] + ",");
                else
                {
                    Console.Write(p[i]);
                    Console.WriteLine();
                }
            }
        }

        public static void PrintArray(string title, long[] p)
        {
            Console.WriteLine(title);
            for (int i = 0; i < p.Length; i++)
            {
                if (i < p.Length - 1)
                    Console.Write(p[i] + ",");
                else
                {
                    Console.Write(p[i]);
                    Console.WriteLine();
                }
            }
        }

        public static void PrintArray(string title, string[] p)
        {
            Console.WriteLine(title);
            for (int i = 0; i < p.Length; i++)
            {
                if (i < p.Length - 1)
                    Console.Write(p[i] + ",");
                else
                {
                    Console.Write(p[i]);
                    Console.WriteLine();
                }
            }
        }
    }
}
