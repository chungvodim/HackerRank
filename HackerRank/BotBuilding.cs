using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public static class BotBuilding
    {
        internal static void DisplayPathtoPrincess(int n, string[] g)
        {
            int[] pp = new int[2];
            int[] mp = new int[2];
            for (int i = 0; i < g.Length; i++)
            {
                
                int p = g[i].IndexOf("p");
                int m = g[i].IndexOf("m");
                if (p >= 0)
                {
                    Console.WriteLine("{0}/{1}", i, p);
                    pp[0] = i; pp[1] = p;
                }
                if (m >= 0)
                {
                    Console.WriteLine("{0}/{1}", i, m);
                    mp[0] = i; mp[1] = m;
                }
            }
            int h = pp[1] - mp[1];
            bool r = h > 0 ? true : false; 
            int v = pp[0] - mp[0];
            bool d = v > 0 ? true : false;
            for (int i = 0; i < Math.Abs(v); i++)
            {
                if (d)
                {
                    Console.WriteLine("DOWN");
                }
                else
                {
                    Console.WriteLine("UP");
                }
            }
            for (int i = 0; i < Math.Abs(h); i++)
            {
                if (r)
                {
                    Console.WriteLine("RIGHT");
                }
                else
                {
                    Console.WriteLine("LEFT");
                }
            }
        }

        internal static void DisplayNextMovetoPrincess(int n, string[] g)
        {
            int[] pp = new int[2];
            int[] mp = new int[2];
            for (int i = 0; i < g.Length; i++)
            {

                int p = g[i].IndexOf("p");
                int m = g[i].IndexOf("m");
                if (p >= 0)
                {
                    //Console.WriteLine("{0}/{1}", i, p);
                    pp[0] = i; pp[1] = p;
                }
                if (m >= 0)
                {
                    //Console.WriteLine("{0}/{1}", i, m);
                    mp[0] = i; mp[1] = m;
                }
            }
            int h = pp[1] - mp[1];
            bool r = h > 0 ? true : false;
            int v = pp[0] - mp[0];
            bool d = v > 0 ? true : false;
            for (int i = 0; i < Math.Abs(v); i++)
            {
                if (d)
                {
                    Console.WriteLine("DOWN");
                    return;
                }
                else
                {
                    Console.WriteLine("UP");
                    return;
                }
            }
            for (int i = 0; i < Math.Abs(h); i++)
            {
                if (r)
                {
                    Console.WriteLine("RIGHT");
                    return;
                }
                else
                {
                    Console.WriteLine("LEFT");
                    return;
                }
            }
        }
    }
}
