using System;
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
            Stack<int> left = new Stack<int>();
            Stack<int> right = new Stack<int>();
            var p = ar[idx];
            for (int i = 1; i < n; i++)
            {
                if(p > ar[i])
                {
                    left.Push(ar[i]);
                }
                else
                {
                    right.Push(ar[i]);
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = left.Count; i > 0; i--)
            {
                sb.Append(left.Pop() + " ");
            }
            sb.Append(p + " ");
            for (int i = right.Count; i > 0; i--)
            {
                sb.Append(right.Pop() + " ");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
