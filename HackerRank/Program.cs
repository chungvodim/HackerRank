using System;
using System.Collections.Generic;
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
            int t = Convert.ToInt16(Console.ReadLine());
            while (t > 0)
            {
                var str = String.Join("",Console.ReadLine().Split());
                var result = MyString.Anagram(str);
                Console.WriteLine(result);
                t--;
            }
        }
    }
}
