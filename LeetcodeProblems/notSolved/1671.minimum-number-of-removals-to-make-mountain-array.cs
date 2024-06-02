/*
 * @lc app=leetcode id=1671 lang=csharp
 *
 * [1671] Minimum Number of Removals to Make Mountain Array
 *
 * https://leetcode.com/problems/minimum-number-of-removals-to-make-mountain-array/description/
 *
 * algorithms
 * Hard (41.60%)
 * Likes:    1558
 * Dislikes: 22
 * Total Accepted:    29.3K
 * Total Submissions: 70.4K
 * Testcase Example:  '[1,3,1]'
 *
 * You may recall that an array arr is a mountain array if and only if:
 * 
 * 
 * arr.length >= 3
 * There exists some index i (0-indexed) with 0 < i < arr.length - 1 such
 * that:
 * 
 * arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
 * arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
 * 
 * 
 * 
 * 
 * Given an integer array nums​​​, return the minimum number of elements to
 * remove to make nums​​​ a mountain array.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,3,1]
 * Output: 0
 * Explanation: The array itself is a mountain array so we do not need to
 * remove any elements.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [2,1,1,5,6,2,3,1]
 * Output: 3
 * Explanation: One solution is to remove the elements at indices 0, 1, and 5,
 * making the array nums = [1,5,6,3,1].
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 3 <= nums.length <= 1000
 * 1 <= nums[i] <= 10^9
 * It is guaranteed that you can make a mountain array out of nums.
 * 
 * 
 */

// @lc code=start
public class MinimumMountainRemovalsSolution
{
    public int MinimumMountainRemovals(int[] nums) {
        var depth = 0;
        for ( int i = 1; i < nums.Length-1; i++)
        {
            if (nums[i] > nums[i-1] && nums[i]> nums[i + 1])
            {
                var left = 0; var right = 0;
                while (i - left - 1 >= 0 && nums[i-left]> nums[i - left - 1])
                {
                    left++;
                }

                while (i + right + 1 < nums.Length && nums[i + right] > nums[i +right+ 1])
                {
                    right++;
                }
                depth = Math.Max(depth, (left + right + 1));
            } 
        }
        var noOfElementInMountain = depth + 1;
        return depth == nums.Length ? 0 : nums.Length - noOfElementInMountain;
    }
}
// @lc code=end

