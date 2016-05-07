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
                //var s =String.Join("", Console.ReadLine().Split());
                var ar = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                MyImplementation.ChocolateFeast(ar[0], ar[1], ar[2]);
            }

            //    //while (true)
            //    //{
            //    //    int x = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
            //    //    int n = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
            //    //    Console.WriteLine(String.Format("Largest divisor: {0}", Algorithm.FindLargestDivisor(x, n)));                
            //    //}

            //    //var n = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
            //    //MyImplementation.SherlockSquares(3, 9);
            //}

            //static void Main(string[] args)
            //{
            //    string[] lines = File.ReadAllLines("input00.txt");
            //    int n = Convert.ToInt32(lines[0]);
            //    int[] ar = lines[1].Split(' ').Select(x => Convert.ToInt32(x)).OrderBy(elm => elm).ToArray();
            //    MyImplementation.CutTheSticks(ar,n);
            //}
        }
    }
}
