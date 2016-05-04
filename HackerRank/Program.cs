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
                var str = String.Join("", Console.ReadLine().Split());
                Console.WriteLine(MyString.PalindromeIndex(str));
            }
        }
    }
}
