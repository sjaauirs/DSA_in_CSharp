/* ALGOEXPERT
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 *
 * https://leetcode.com/problems/two-sum/description/
 *
 * algorithms
 * Easy (52.04%)
 * Likes:    55291
 * Dislikes: 1889
 * Total Accepted:    12.5M
 * Total Submissions: 24M
 * Testcase Example:  '[2,7,11,15]\n9'
 *
 * Given an array of integers nums and an integer target, return indices of the
 * two numbers such that they add up to target.
 * 
 * You may assume that each input would have exactly one solution, and you may
 * not use the same element twice.
 * 
 * You can return the answer in any order.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [2,7,11,15], target = 9
 * Output: [0,1]
 * Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [3,2,4], target = 6
 * Output: [1,2]
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: nums = [3,3], target = 6
 * Output: [0,1]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 2 <= nums.length <= 10^4
 * -10^9 <= nums[i] <= 10^9
 * -10^9 <= target <= 10^9
 * Only one valid answer exists.
 * 
 * 
 * 
 * Follow-up: Can you come up with an algorithm that is less than O(n^2) time
 * complexity?
 */

// @lc code=start
public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target) {
        //Optimized approch  BY leetCode
        var pairs = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (pairs.ContainsKey(target - nums[i]))
            {
                return new int[] { pairs[target - nums[i]], i };
            }
            else
            {
                pairs.TryAdd(nums[i], i);
            }
        }
        return new int[] { 0, 0 };
        


    // Sorted Array 
    // https://www.designgurus.io/course-play/grokking-the-coding-interview/doc/638c9e2788f1e1c16f41c35c

    //int i = 0;
    //    int j = nums.Length - 1;
    //    var result = new int[2];
    //    var sum = nums[i] + nums[j];
    //    while (sum != target)
    //    {
    //        if (sum > target)
    //        {
    //            j--;
    //        }
    //        else
    //        {
    //            i++;
    //        }
    //        sum = nums[i] + nums[j];
    //    }
    //    return new int[] { i, j };

    }
}
// @lc code=end

