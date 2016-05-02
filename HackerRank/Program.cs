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
        //static void Main(string[] args)
        //{
        //    Console.ReadLine();
        //    int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        //    //CorrectnessInvariant.insertionSort(_ar);
        //    int runningTime = 0;
        //    RunningTime.insertionSort(_ar, ref runningTime);
        //    Console.Read();
        //}
        //    static void Main(string[] args)
        //    {
        //        try
        //        {
        //            var t = Convert.ToInt32(Console.ReadLine());
        //            if(t >=1 && t <= 10)
        //            {
        //                for (int i = 0; i < t; i++)
        //                {
        //                    var nk = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        //                    var n = nk[0];
        //                    var k = nk[1];
        //                    if (n >= 1 && n <= 1000 && k >= 1 && k <= n)
        //                    {
        //                        var arrivalTimes = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
        //                        var numberOfOnTime = 0;
        //                        foreach (var arrivalTime in arrivalTimes)
        //                        {
        //                            if (arrivalTime <= 0) numberOfOnTime++;
        //                        }
        //                        if (numberOfOnTime >= k)
        //                        {
        //                            Console.WriteLine("NO");
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine("YES");
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        catch(Exception ex)
        //        {
        //            Debug.WriteLine(ex);
        //        }
        //    }
        //}

        //static void Main(string[] args)
        //{

        //    int height = 1;
        //    var t = Convert.ToInt32(Console.ReadLine());
        //    if (t >= 1 && t <= 10)
        //    {
        //        for (int i = 0; i < t; i++)
        //        {
        //            var n = Convert.ToInt32(Console.ReadLine());
        //            if(n > 0)
        //            {
        //                for (int j = 1; j <= n; j++)
        //                {
        //                    if (j % 2 == 1)
        //                    {
        //                        height *= 2;
        //                    }
        //                    else
        //                    {
        //                        height += 1;
        //                    }
        //                }
        //            }
        //            Console.WriteLine(height);
        //            height = 1;
        //        }
        //    }
        //}

        //static void Main(string[] args)
        //{

        //    int count = 0;
        //    var t = Convert.ToInt32(Console.ReadLine());
        //    if (t >= 1 && t <= 15)
        //    {
        //        for (int i = 0; i < t; i++)
        //        {
        //            var number = Console.ReadLine();
        //            var n = Convert.ToInt32(number);
        //            var temp = n;
        //            while (n > 0)
        //            {
        //                int devine = n % 10;
        //                if (devine != 0 && temp % devine == 0) count++;
        //                n = n / 10;
        //            }
        //            Console.WriteLine(count);
        //            count = 0;
        //        }
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int t = Convert.ToInt32(Console.ReadLine());
        //    while (t > 0)
        //    {
        //        var dinners = Convert.ToInt32(Console.ReadLine());
        //        var minimumTables = Contest.MinimumTables(dinners);
        //        Console.WriteLine("Case #{0}: {1}", t, minimumTables);
        //        //arrList.Add(sentence);
        //        t--;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int[] lines = File.ReadAllLines(@"C:\WorkSpace\HackerRank\submitInput.txt").Select(x => Convert.ToInt32(x)).ToArray();
        //    int t = 1;
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 1; i < lines.Length; i++)
        //    {
        //        var minimumTables = Contest.MinimumTables(lines[i]);
        //        //Console.WriteLine("Case #{0}: {1}", t, minimumTables);
        //        sb.Append(String.Format("Case #{0}: {1}\n", t, minimumTables));
        //        t++;
        //    }
        //    File.WriteAllText(@"C:\WorkSpace\HackerRank\result.txt", sb.ToString());
        //}

        //static void Main(string[] args)
        //{
        //    string[] lines = File.ReadAllLines("input12.txt");
        //    //var t = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 1; i < lines.Length; i++)
        //    {
        //        //StringBuilder sb = new StringBuilder();
        //        //while (true)
        //        //{
        //        //    char c = Convert.ToChar(Console.Read());
        //        //    sb.Append(c);
        //        //    if (c == '\n')
        //        //    {
        //        //        break;
        //        //    }
        //        //}
        //        //var str = String.Join("", Console.ReadLine().Split());
        //        //Console.WriteLine(MyStringBuffer.PalindromeIndex(lines[i]));
        //        Console.WriteLine(MyStringBuffer.PalindromeIndex(lines[i]));
        //        //Console.WriteLine(MyStringBuffer.PalindromeIndex(sb.ToString().Replace("\r\n","")));
        //    }
        //}
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
