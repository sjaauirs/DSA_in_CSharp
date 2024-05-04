/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 *
 * https://leetcode.com/problems/move-zeroes/description/
 *
 * algorithms
 * Easy (61.64%)
 * Likes:    16392
 * Dislikes: 435
 * Total Accepted:    2.9M
 * Total Submissions: 4.7M
 * Testcase Example:  '[0,1,0,3,12]'
 *
 * Given an integer array nums, move all 0's to the end of it while maintaining
 * the relative order of the non-zero elements.
 * 
 * Note that you must do this in-place without making a copy of the array.
 * 
 * 
 * Example 1:
 * Input: nums = [0,1,0,3,12]
 * Output: [1,3,12,0,0]
 * Example 2:
 * Input: nums = [0]
 * Output: [0]
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 10^4
 * -2^31 <= nums[i] <= 2^31 - 1
 * 
 * 
 * 
 * Follow up: Could you minimize the total number of operations done?
 */

// @lc code=start
public static class MoveZeroesSolution
{
    public static void MoveZeroes(int[] nums) {
        int position = 0;
        while (nums[position] != 0)
        {
            position++;
        }
        
        for(int i = position; i < nums.Length; i++)
        {
            if (nums[i] != 0) {
                nums[position] = nums[i];
                nums[i] = 0;
                position++;
            }
        }
    }
}
// @lc code=end

