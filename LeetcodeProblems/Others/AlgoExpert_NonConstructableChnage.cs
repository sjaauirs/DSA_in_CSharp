using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Globalization;

namespace LeetcodeProblems.Others
{
    internal class AlgoExpert_NonConstructableChnage
    {
        public int NonConstructibleChange(int[] coins)
        {
            System.Array.Sort(coins);
            var MaxChange = 0;
            foreach (var co in coins)
            {
                if (co > MaxChange + 1)
                {
                    return MaxChange + 1;
                }
                else
                {
                    MaxChange = MaxChange + co;
                }
            }
            return MaxChange + 1;
        }
    }
}
