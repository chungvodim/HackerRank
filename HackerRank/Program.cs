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
        //    //var t = Convert.ToInt32(Console.ReadLine());
        //    //for (int i = 1; i <= t; i++)
        //    //{
        //    //    //var str = String.Join("", Console.ReadLine().Split());
        //    //    var str = Console.ReadLine();
        //    //    MyStack.TextEditor(str);
        //    //}

        //    var n = Convert.ToInt32(Console.ReadLine());
        //    var ar = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        //    MySort.QuickSort(n,ar);

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

        static void Main(String[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] mp = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            String[] grid = new String[n];
            for (int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine();
            }

            BotBuilding.DisplayNextMovetoPrincess(n, grid);
        }

        //static void Main(String[] args)
        //{
        //    int n;
        //    n = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < n; i++)
        //    {
        //        int m = int.Parse(Console.ReadLine());
        //        int[] ar = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        //        DynamicProgramming.MaximumSubarray(m,ar);
        //    }

        //}

        //static void Main(String[] args)
        //{
        //    int n;
        //    n = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < n; i++)
        //    {
        //        int m = int.Parse(Console.ReadLine());
        //        int[] ar = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        //        DynamicProgramming.MaximumSubarray(m, ar);
        //    }

        //}

        //static void Main(String[] args)
        //{
        //    string[] s = Console.ReadLine().Split(' ');
        //    int noVertices = Convert.ToInt32(s[0]);
        //    int noEdges = Convert.ToInt32(s[1]);

        //    Graph graph = new Graph(noVertices);
        //    for (int i = 0; i < noEdges; i++)
        //    {
        //        string[] s1 = Console.ReadLine().Split(' ');

        //        int start = Convert.ToInt32(s1[0]);
        //        int end = Convert.ToInt32(s1[1]);

        //        graph.AddEdgeAndVert(start, end);
        //    }

        //    Console.WriteLine(graph.countNoRemovableEdges());

        //}
    }
}
