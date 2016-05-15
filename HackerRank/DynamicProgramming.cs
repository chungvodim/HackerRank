using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class DynamicProgramming
    {
        internal static void MaximumSubarray(int m, int[] ar)
        {
            int sum = 0;
            int max = 0;
            int min = int.MinValue;
            foreach (int i in ar)
            {
                sum += i;
                if(sum < 0)
                {
                    sum = 0;
                }
                max = Math.Max(max, sum);
                min = Math.Max(min, i);
            }
            if(max > 0)
            {
                Console.Write(max + " ");
            }
            else
            {
                Console.WriteLine(min + " " + min);
                return;
            }
            max = 0;
            foreach (int i in ar)
            {
                if (i > 0)
                {
                    max += i;
                }
            }
            Console.Write(max + "\n");
        }
    }
}
