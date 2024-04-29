//AlgoExpert
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Array
{
    public class Program
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {

            int j = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == sequence[j])
                {
                    j++;
                }

                if (j == sequence.Count)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
