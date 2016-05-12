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
        //static void Main(string[] args)
        //{
        //    var t = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 1; i <= t; i++)
        //    {
        //        var str = String.Join("", Console.ReadLine().Split());
        //        MyStack.BalancedParentheses(str);
        //    }

        //    //var nk = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        //    //var ar = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        //    //MyImplementation.LisaBook(nk[0], nk[1], ar);

        //    //    //while (true)
        //    //    //{
        //    //    //    int x = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
        //    //    //    int n = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
        //    //    //    Console.WriteLine(String.Format("Largest divisor: {0}", Algorithm.FindLargestDivisor(x, n)));                
        //    //    //}

        //    //    //var n = Convert.ToInt32(String.Join("", Console.ReadLine().Split()));
        //    //    //MyImplementation.SherlockSquares(3, 9);
        //    //}

        //}

        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input02.txt");
            int n = Convert.ToInt32(lines[0]);
            for (int i = 1; i <= n; i++)
            {
                var s = lines[i];
                MyStack.BalancedParentheses(s);
            }
        }

        //static void Main(String[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    for (int a0 = 0; a0 < t; a0++)
        //    {
        //        string[] tokens_R = Console.ReadLine().Split(' ');
        //        int R = Convert.ToInt32(tokens_R[0]);
        //        int C = Convert.ToInt32(tokens_R[1]);
        //        string[] G = new string[R];
        //        for (int G_i = 0; G_i < R; G_i++)
        //        {
        //            G[G_i] = Console.ReadLine();
        //        }
        //        string[] tokens_r = Console.ReadLine().Split(' ');
        //        int r = Convert.ToInt32(tokens_r[0]);
        //        int c = Convert.ToInt32(tokens_r[1]);
        //        string[] P = new string[r];
        //        for (int P_i = 0; P_i < r; P_i++)
        //        {
        //            P[P_i] = Console.ReadLine();
        //        }

        //        MyImplementation.GridSearch(G,P);
        //    }
        //}

        //static void Main(String[] args)
        //{
        //    string[] lines = File.ReadAllLines("input01.txt");
        //    int t = Convert.ToInt32(lines[0]);
        //    for (int i = 1; i < lines.Length; i++)
        //    {
        //        string[] tokens_R = lines[i].Split(' ');
        //        int R = Convert.ToInt32(tokens_R[0]);
        //        int C = Convert.ToInt32(tokens_R[1]);
        //        string[] G = new string[R];
        //        for (int j = i + 1; j <= R + i; j++)
        //        {
        //            G[j - i - 1] = lines[j];
        //        }
        //        string[] tokens_r = lines[i + R + 1].Split(' ');
        //        int r = Convert.ToInt32(tokens_r[0]);
        //        int c = Convert.ToInt32(tokens_r[1]);
        //        string[] P = new string[r];
        //        for (int k = i + R + 2; k <= i + R + 1 + r; k++)
        //        {
        //            P[k - i - R - 2] = lines[k];
        //        }
        //        MyImplementation.GridSearch(G, P);
        //        i += R + r + 1;
        //    }
        //}
    }
}
