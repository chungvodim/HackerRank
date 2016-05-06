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
            //var t = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= t; i++)
            //{
            //    //var m = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
            //    var s = String.Join("", Console.ReadLine().Split());
            //    MyString.SherlockAndAnagrams(s);
            //}

            //while (true)
            //{
            //    int m = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
            //    int n = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
            //    Console.WriteLine(String.Format("Largest divisor: {0}", Algorithm.FindLargestDivisor(m, n)));                
            //}

            var s = String.Join("", Console.ReadLine().Split());
            MyString.ReverseShuffleMerge(s);
        }

        //static void Main(string[] args)
        //{
        //    string[] lines = File.ReadAllLines("input02.txt");
        //    MyString.SteadyGene(lines[1], Convert.ToInt32(lines[0])/4);
        //}
    }
}
