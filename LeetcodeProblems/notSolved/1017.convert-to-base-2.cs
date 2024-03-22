/*
 * @lc app=leetcode id=1017 lang=csharp
 *
 * [1017] Convert to Base -2
 *
 * https://leetcode.com/problems/convert-to-base-2/description/
 *
 * algorithms
 * Medium (60.54%)
 * Likes:    507
 * Dislikes: 285
 * Total Accepted:    26K
 * Total Submissions: 42.9K
 * Testcase Example:  '2'
 *
 * Given an integer n, return a binary string representing its representation
 * in base -2.
 * 
 * Note that the returned string should not have leading zeros unless the
 * string is "0".
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: n = 2
 * Output: "110"
 * Explantion: (-2)^2 + (-2)^1 = 2
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: n = 3
 * Output: "111"
 * Explantion: (-2)^2 + (-2)^1 + (-2)^0 = 3
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: n = 4
 * Output: "100"
 * Explantion: (-2)^2 = 4
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 0 <= n <= 10^9
 * 
 * 
 */

// @lc code=start
using System.Text;

public class BaseNeg2Solution
{
    public string BaseNeg2(int n) {
        var stack = new Stack<int>();
        while(n != 0)
        {
            stack.Push(n%2);
            n = n / 2;
        }
        var sb = new StringBuilder();
        while(stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }
        return sb.ToString();
    }
}
// @lc code=end

