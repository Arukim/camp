using System;
using System.Collections.Generic;
using System.Text;

namespace VEBTree
{

    public class Tree
    {
        int min;
        int max;
        int M;
        Tree[] children;
        Tree aux;

        public Tree(int m)
        {
            max = -1;
            min = M = m;
        }

        public void Insert(int x)
        {
            if (min > max) // tree is empty
            {
                min = max = x;
                return;
            }

            if (x < min)
                (x, min) = (min, x);

            if (x > max)
                max = x;

            var i = x / (int)Math.Sqrt(M);
            var lo = i % (int)Math.Sqrt(M);
            children[i].Insert(lo);

            if (children[i].min == children[i].max)
                aux.Insert(i);
        }
    }
}
