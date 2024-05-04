// From AlgoExpert : SmallestDiffrance
// pattern : 2 pointer - In different array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Array
{
    internal class SmallestDiffrance
    {
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            System.Array.Sort(arrayOne);
            System.Array.Sort(arrayTwo);
            int i = 0; int j = 0;
            var minDiff = int.MaxValue;
            var result = new int[2];
            while (i < arrayOne.Length && j < arrayTwo.Length)
            {
                if (arrayOne[i] == arrayTwo[j])
                { return new int[] { arrayOne[i], arrayTwo[j] }; }
                if (arrayOne[i] < arrayTwo[j])
                {
                    minDiff = UpdateDiff(arrayOne, arrayTwo, i, j, minDiff, result);
                    i++;
                }
                else
                {
                    minDiff = UpdateDiff(arrayOne, arrayTwo, i, j, minDiff, result);
                    j++;
                }
            }
            return result;
        }

        private static int UpdateDiff(int[] arrayOne, int[] arrayTwo, int i, int j, int minDiff, int[] result)
        {
            var oldDiff = minDiff;
            minDiff = Math.Min(minDiff, Math.Abs(arrayOne[i] - arrayTwo[j]));
            if (oldDiff != minDiff)
            {
                result[0] = arrayOne[i];
                result[1] = arrayTwo[j];
            }

            return minDiff;
        }
    }
}
