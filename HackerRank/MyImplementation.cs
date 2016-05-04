using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class MyImplementation
    {
        public static void AngryProfessor()
        {
            var t = Convert.ToInt32(Console.ReadLine());
            if (t >= 1 && t <= 10)
            {
                for (int i = 0; i < t; i++)
                {
                    var nk = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                    var n = nk[0];
                    var k = nk[1];
                    if (n >= 1 && n <= 1000 && k >= 1 && k <= n)
                    {
                        var arrivalTimes = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                        var numberOfOnTime = 0;
                        foreach (var arrivalTime in arrivalTimes)
                        {
                            if (arrivalTime <= 0) numberOfOnTime++;
                        }
                        if (numberOfOnTime >= k)
                        {
                            Console.WriteLine("NO");
                        }
                        else
                        {
                            Console.WriteLine("YES");
                        }
                    }
                }
            }
        }

        public static void UtopianTree()
        {
            int height = 1;
            var t = Convert.ToInt32(Console.ReadLine());
            if (t >= 1 && t <= 10)
            {
                for (int i = 0; i < t; i++)
                {
                    var n = Convert.ToInt32(Console.ReadLine());
                    if (n > 0)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (j % 2 == 1)
                            {
                                height *= 2;
                            }
                            else
                            {
                                height += 1;
                            }
                        }
                    }
                    Console.WriteLine(height);
                    height = 1;
                }
            }
        }

        public static void FindDigit()
        {
            int count = 0;
            var t = Convert.ToInt32(Console.ReadLine());
            if (t >= 1 && t <= 15)
            {
                for (int i = 0; i < t; i++)
                {
                    var number = Console.ReadLine();
                    var n = Convert.ToInt32(number);
                    var temp = n;
                    while (n > 0)
                    {
                        int devine = n % 10;
                        if (devine != 0 && temp % devine == 0) count++;
                        n = n / 10;
                    }
                    Console.WriteLine(count);
                    count = 0;
                }
            }
        }
    }
}
