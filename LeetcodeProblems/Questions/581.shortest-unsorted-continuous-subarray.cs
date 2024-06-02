/*
 * @lc app=leetcode id=581 lang=csharp
 *
 * [581] Shortest Unsorted Continuous Subarray
 *
 * https://leetcode.com/problems/shortest-unsorted-continuous-subarray/description/
 *
 * algorithms
 * Medium (36.76%)
 * Likes:    7697
 * Dislikes: 259
 * Total Accepted:    326.9K
 * Total Submissions: 887.1K
 * Testcase Example:  '[2,6,4,8,10,9,15]'
 *
 * Given an integer array nums, you need to find one continuous subarray such
 * that if you only sort this subarray in non-decreasing order, then the whole
 * array will be sorted in non-decreasing order.
 * 
 * Return the shortest such subarray and output its length.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [2,6,4,8,10,9,15]
 * Output: 5
 * Explanation: You need to sort [6, 4, 8, 10, 9] in ascending order to make
 * the whole array sorted in ascending order.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [1,2,3,4]
 * Output: 0
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: nums = [1]
 * Output: 0
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 10^4
 * -10^5 <= nums[i] <= 10^5
 * 
 * 
 * 
 * Follow up: Can you solve it in O(n) time complexity?
 */

// @lc code=start
public class FindUnsortedSubarraySolution
{
    public int[] FindUnsortedSubarray(int[] nums) {

        int minleft = nums.Length;
        int maxRight = 0;

        for(int i = 1;i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1])
            {
                int k = i - 1; int j = 0;
                while (k>=0 && nums[k]> nums[i])
                {
                    k--; j++;
                }
                minleft = Math.Min(minleft, (i - j));
                maxRight = Math.Max(i + 1, maxRight);
            }  
        }

        return new int[] { minleft, maxRight };
    }
}
// @lc code=end

