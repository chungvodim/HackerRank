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

        public static int[] Extended_GCD(int A, int B)
        {
            int[] result = new int[3];
            if (A < B)
            {
                int temp = A;
                A = B;
                B = temp;
            }
            int r = B;
            int q = 0;
            int x0 = 1;
            int y0 = 0;
            int x1 = 0;
            int y1 = 1;
            int x = 0, y = 0;
            while (r > 1)
            {
                r = A % B;
                q = A / B;
                x = x0 - q * x1;
                y = y0 - q * y1;
                x0 = x1;
                y0 = y1;
                x1 = x;
                y1 = y;
                A = B;
                B = r;
            }
            result[0] = r;
            result[1] = x;
            result[2] = y;
            return result;
        }

    }
}
