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
                //int READLINE_BUFFER_SIZE = 10000;
                //Stream inputStream = Console.OpenStandardInput(READLINE_BUFFER_SIZE);
                //byte[] bytes = new byte[READLINE_BUFFER_SIZE];
                //int outputLength = inputStream.Read(bytes, 0, READLINE_BUFFER_SIZE);
                //Console.WriteLine(outputLength);
                //char[] chars = Encoding.UTF8.GetChars(bytes, 0, outputLength);
                var str = String.Join("",Console.ReadLine().Split());
                //var str = new string(chars);
                //str = str.Remove(str.Length - 1, 1);
                //Console.WriteLine(new string(chars));
                var result = MyString.Anagram(str);
                Console.WriteLine(result);
                t--;
            }
        }
    }
}
