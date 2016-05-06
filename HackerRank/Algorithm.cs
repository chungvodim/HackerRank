using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class Algorithm
    {
        public static int FindLargestDivisor(int m, int n)
        {
            int r  = m % n;
            if (r == 0)
            {
                return n;
            }
            else
            {
                return FindLargestDivisor(n,r);
            }
        }
    }
}
