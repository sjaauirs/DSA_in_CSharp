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
            string[] ops= { "5", "-2", "4", "C", "D", "9", "+", "+" };

            SimplifyPathSolution solution = new SimplifyPathSolution();

          var result=  solution.SimplifyPath(input);

            Console.ReadLine();
        }
    }
}

 