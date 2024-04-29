using LeetcodeProblems.Helpers;
using LeetcodeProblems.Questions;

namespace LeetcodeProblems
{
    internal class Program
    {

        // Customise to call any Specific problem
        static void Main(string[] args)
        {
            //   int[] input = { 1, 2, 3, 4, 5 };
           //   var input = "/a//b////c/d//././/..";
            var input = "/../";
            int[] nums1= {5,10,-5 };
            int[] nums2 = { 1, 3,4, 2 };

            Solution solution = new Solution();

          var result=  solution.AsteroidCollision(nums1);

            Console.ReadLine();
        }
    }
}

 