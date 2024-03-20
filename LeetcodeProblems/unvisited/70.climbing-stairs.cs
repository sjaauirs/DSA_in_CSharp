/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */

// @lc code=start
namespace LeetcodeProblems.unvisited
{
    public class SolutionClimbingStairs
    {

        // This is actually the expression for Fibonacci numbers, but there is one thing to notice, the value of ways(n) is equal to fibonacci(n+1)
        public int ClimbStairs(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            int prev1 = 1;
            int prev2 = 1;
            int current = 0;

            for (int i = 2; i <= n; i++)
            {
                current = prev1 + prev2;
                prev1 = prev2;
                prev2 = current;
            }

            return current;
        }

    }
}
// @lc code=end

