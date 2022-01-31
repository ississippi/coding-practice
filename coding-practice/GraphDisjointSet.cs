using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    // ==============
    // Quick Find
    // ==============
    //
    // UnionFindQuickFind.class
    // Space O(n) Constructor O(n) find O(1)	Union O(N)	Connected O(1)
    class UnionFindQuickFind
    {
        private int[] root;

        // O(n)
        public UnionFindQuickFind(int size)
        {
            // Initialize root array
            root = new int[size];
            for (int i = 0; i < size; i++)
            {
                root[i] = i;
            }
        }

        // O(1)
        public int find(int x)
        {
            // return root at index x
            return root[x];
        }

        // O(n)
        public void union(int x, int y)
        {
            // find root at index x and y, if roots not equal, find the root of y and set Y to the root of x.
            int rootX = find(x);
            int rootY = find(y);
            if (rootX != rootY)
            {
                for (int i = 0; i < root.Length; i++)
                {
                    if (root[i] == rootY)
                    {
                        root[i] = rootX;
                    }
                }
            }
        }

        // O(1)
        public bool connected(int x, int y)
        {
            // Compare roots of index x and y
            return find(x) == find(y);
        }
    }

    // ==============
    // Quick Union
    // ==============
    //
    // UnionFindQuickUnion.class
    // Space O(n) Constructor O(n) find O(n)	Union O(N)	Connected O(n)
    class UnionFindQuickUnion // more efficient thatn QuickFind
    {
        private int[] root;

        public UnionFindQuickUnion(int size)
        {
            root = new int[size];
            for (int i = 0; i < size; i++)
            {
                root[i] = i;
            }
        }

        public int find(int x)
        {
            while (x != root[x])
            {
                x = root[x];
            }
            return x;
        }

        public void union(int x, int y)
        {
            int rootX = find(x);
            int rootY = find(y);
            if (rootX != rootY)
            {
                root[rootY] = rootX;
            }
        }

        public bool connected(int x, int y)
        {
            return find(x) == find(y);
        }
    }

}
