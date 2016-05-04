using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class RunningTime
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
    }
}
