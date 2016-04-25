using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class MyString
    {
        public static int Anagram(string str)
        {
            if (string.IsNullOrEmpty(str)) return -1;
            int anagram = 0;
            int length = str.Length;
            if (length > 10000) return -1;
            if (length % 2 == 1) return -1;
            int[] arr = new int[256];
            for (int i = 0; i < length/2; i++)
            {
                arr[(int)str[i]]++;
            }
            for (int i = length / 2; i < length; i++)
            {
                arr[(int)str[i]]--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                anagram += Math.Abs(arr[i]);
            }
            return anagram/2;
        }
    }
}
