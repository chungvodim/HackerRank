using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                var str1 = String.Join("", Console.ReadLine().Split());
                var str2 = String.Join("", Console.ReadLine().Split());
                MyString.TwoStrings(str1,str2);
            }
        }

        //static void Main(string[] args)
        //{
        //    string[] lines = File.ReadAllLines("input14.txt");
        //    for (int i = 1; i < lines.Length; i++)
        //    {
        //        var result = MyString.PalindromeIndex(lines[i]);
        //        Console.WriteLine(String.Format("{0}/{1}/{2}", result, lines[i].Length - result - 1, lines[i].Length));
        //    }
        //}
    }
}
