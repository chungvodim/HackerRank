using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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


        public static void SherlockBeast(int n)
        {
            int x = n / 3;
            int r = n % 3;
            int y = 0;
            while ((r + y * 3) % 5 != 0)
            {
                y++;
                if (y > x)
                {
                    Console.WriteLine("-1");
                    return;
                }
            }
            int l = r + y * 3;
            int m = n - l;//n = 3x(5's) + 5y(3's)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                if (i >= m)
                {
                    sb.Append('3');
                }
                else
                {
                    sb.Append('5');
                }
            }
            Console.WriteLine(sb.ToString());
        }

        public static void SherlockSquares(uint s, uint e)
        {
            int r = 0;
            for (uint i = s; i <= e; i++)
            {
                //if (IsPowerOfTwo(i)) r++;
                double x = Math.Sqrt(i);
                if (x % 1 == 0)
                {
                    r++;
                    i = (uint)Math.Pow(x + 1,2) - 1;
                }
            }
            Console.WriteLine(r);
        }

        private static bool IsPowerOfTwo(uint x)
        {
            //while (((x % 2) == 0) && x > 1)
            //{
            //    x /= 2;
            //}
            //return (x == 1);

            //return (x & (x - 1)) == 0;

            return (x != 0) && ((x & (x - 1)) == 0);
        }

        public static void CutTheSticks(int[] ar,int n)
        {
            int smallest = 0;
            int nextSmallest = ar[0];
            int left = n;
            bool isFoundSmallest = false;
            StringBuilder sb = new StringBuilder();
            while (ar[n - 1] > 0)
            {
                smallest = nextSmallest;
                sb.AppendLine(left.ToString());
                for (int i = 0; i < n; i++)
                {
                    if (ar[i] > 0)
                    {
                        ar[i] = ar[i] - smallest;
                        if(ar[i] > 0 && !isFoundSmallest)
                        {
                            nextSmallest = ar[i];
                            isFoundSmallest = true;
                        }
                        if (ar[i] <= 0)
                        {
                            left--;
                        }
                    }
                }
                isFoundSmallest = false;
            }
            Console.WriteLine(sb.ToString());
        }

        public static void ChocolateFeast(int n, int c, int m)
        {
            int w = n / c;
            w += GetBonus(w, m);
            Console.WriteLine(w);
        }

        private static int GetBonus(int w, int m)
        {
            int r = w / m;
            int mob = w % m;
            if(w < m)
            {
                return 0;
            }
            else
            {
                return r + GetBonus(r + mob, m);
            }
        }
    }
}
