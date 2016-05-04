using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Tuenti
    {
        public static int MinimumTables(int dinners)
        {
            int minimumTables = 0;
            if (dinners == 0)
            {
                minimumTables = 0;
            }
            else if (dinners <= 4)
            {
                minimumTables = 1;
            }
            else
            {
                minimumTables = (int)Math.Ceiling((double)(dinners - 2) / 2);
            }
            return minimumTables;
        }
    }
}
