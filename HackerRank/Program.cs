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

            String[] grid = new String[n];
            for (int i = 0; i < n; i++)
            {
                grid[i] = Console.ReadLine();
            }

            BotBuilding.DisplayPathtoPrincess(n, grid);
        }
    }
}
