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
                //var x = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
                //var s =String.Join("", Console.ReadLine().Split()).Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                var n = Console.ReadLine().Split(' ').Select(x => Convert.ToUInt32(x)).ToArray();
                MyImplementation.SherlockSquares(n[0], n[1]);
            }

            //while (true)
            //{
            //    int x = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
            //    int n = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
            //    Console.WriteLine(String.Format("Largest divisor: {0}", Algorithm.FindLargestDivisor(x, n)));                
            //}

            //var n = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
            //MyImplementation.SherlockSquares(3, 9);
        }

        //static void Main(string[] args)
        //{
        //    string[] lines = File.ReadAllLines("input02.txt");
        //    MyString.SteadyGene(lines[1], Convert.ToInt32(lines[0])/4);
        //}
    }
}
