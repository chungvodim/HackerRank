﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class MySort
    {
        public static void insertionSort(int[] A, ref int runningTime)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                // Note : j >= 0
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                    runningTime += 1;
                }
                A[j + 1] = value;
            }
            //Console.WriteLine(string.Join(" ", A));
        }

        public static void Partition(int n, int[] ar)
        {
            int idx = 0;
            int ls = 0;
            int rs = 0;
            int[] l = new int[n];
            int[] r = new int[n];
            var p = ar[idx];
            for (int i = 1; i < n; i++)
            {
                if(p > ar[i])
                {
                    l[ls] = ar[i];
                    ls++;
                }
                else
                {
                    r[rs] = ar[i];
                    rs++;
                }
            }
            //Array.Resize(ref l, ls);
            //Array.Resize(ref r, rs);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ls; i++)
            {
                sb.Append(l[i] + " ");
            }
            sb.Append(p + " ");
            for (int i = 0; i < rs; i++)
            {
                sb.Append(r[i] + " ");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
