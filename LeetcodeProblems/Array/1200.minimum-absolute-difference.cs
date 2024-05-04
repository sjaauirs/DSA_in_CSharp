/* TOPIC  : SORTING
 * @lc app=leetcode id=1200 lang=csharp
 *
 * [1200] Minimum Absolute Difference
 *
 * https://leetcode.com/problems/minimum-absolute-difference/description/
 *
 * algorithms
 * Easy (69.46%)
 * Likes:    2327
 * Dislikes: 75
 * Total Accepted:    189K
 * Total Submissions: 271.8K
 * Testcase Example:  '[4,2,1,3]'
 *
 * Given an array of distinct integers arr, find all pairs of elements with the
 * minimum absolute difference of any two elements.
 * 
 * Return a list of pairs in ascending order(with respect to pairs), each pair
 * [a, b] follows
 * 
 * 
 * a, b are from arr
 * a < b
 * b - a equals to the minimum absolute difference of any two elements in
 * arr
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: arr = [4,2,1,3]
 * Output: [[1,2],[2,3],[3,4]]
 * Explanation: The minimum absolute difference is 1. List all pairs with
 * difference equal to 1 in ascending order.
 * 
 * Example 2:
 * 
 * 
 * Input: arr = [1,3,6,10,15]
 * Output: [[1,3]]
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: arr = [3,8,-10,23,19,-4,-14,27]
 * Output: [[-14,-10],[19,23],[23,27]]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 2 <= arr.length <= 10^5
 * -10^6 <= arr[i] <= 10^6
 * 
 * 
 */

// @lc code=start
public class AExMinimumAbsDifference
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        System.Array.Sort(arr);
        var MinDiff = Int32.MaxValue;
        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < arr.Length - 1; ++i)  /// First Loop tocalculate the Min Differance
        {
            MinDiff = Math.Min(MinDiff, Math.Abs(arr[i] - arr[i+1]));
        }


        for (int i = 1;i < arr.Length-1; i++)
        {
            var idiff = Math.Abs(arr[i] - arr[i + 1]);
            if(idiff == MinDiff)
            {
                result.Add(new List<int> { arr[i], arr[i + 1] });
            }
        }

        return result;
    }
}
// @lc code=end

