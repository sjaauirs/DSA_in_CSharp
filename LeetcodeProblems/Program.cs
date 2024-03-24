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
             var input = "/a//b////c/d//././/..";
            //var input = "/../";
            Solution solution = new Solution();
            var result = solution.SimplifyPath(input);
            

            Console.ReadLine();
        }
    }
}

 