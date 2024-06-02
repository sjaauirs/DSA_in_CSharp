using LeetcodeProblems.Array;
using LeetcodeProblems.Helpers;

namespace LeetcodeProblems
{
    internal class Program
    {

        // Customise to call any Specific problem
        static void Main(string[] args)
        {
            int[] nums1 = { 2,1 };

            int[] nums10= {1,2,3, 4};
            int[] nums20 = { 5, 6,7, 8 };
            int[] nums30 = { 9,10,11,12 };
            int[][] nums2 = new int[3][];
            nums2[0] = nums10;
            nums2[1] = nums20;
            nums2[2] = nums30;
            var solution = new FindUnsortedSubarraySolution();
            
           var C =  solution.FindUnsortedSubarray(nums1);



            Console.ReadLine();
        }
    }
}

 