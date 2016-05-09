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
            //    //var s =String.Join("", Console.ReadLine().Split());
            //    var ar = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            //    MyImplementation.ChocolateFeast(ar[0], ar[1], ar[2]);
            //}

            var nk = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            var ar = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            MyImplementation.LisaBook(nk[0], nk[1], ar);

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

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_R = Console.ReadLine().Split(' ');
                int R = Convert.ToInt32(tokens_R[0]);
                int C = Convert.ToInt32(tokens_R[1]);
                string[] G = new string[R];
                for (int G_i = 0; G_i < R; G_i++)
                {
                    G[G_i] = Console.ReadLine();
                }
                string[] tokens_r = Console.ReadLine().Split(' ');
                int r = Convert.ToInt32(tokens_r[0]);
                int c = Convert.ToInt32(tokens_r[1]);
                string[] P = new string[r];
                for (int P_i = 0; P_i < r; P_i++)
                {
                    P[P_i] = Console.ReadLine();
                }

                MyImplementation.GridSearch(G,P);
            }
        }
    }
}
