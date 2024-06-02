/*
 * @lc app=leetcode id=287 lang=csharp
 *
 * [287] Find the Duplicate Number
 *
 * https://leetcode.com/problems/find-the-duplicate-number/description/
 *
 * algorithms
 * Medium (59.44%)
 * Likes:    22997
 * Dislikes: 4410
 * Total Accepted:    1.7M
 * Total Submissions: 2.8M
 * Testcase Example:  '[1,3,4,2,2]'
 *
 * Given an array of integers nums containing n + 1 integers where each integer
 * is in the range [1, n] inclusive.
 * 
 * There is only one repeated number in nums, return this repeated number.
 * 
 * You must solve the problem without modifying the array nums and uses only
 * constant extra space.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,3,4,2,2]
 * Output: 2
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [3,1,3,4,2]
 * Output: 3
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: nums = [3,3,3,3,3]
 * Output: 3
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= n <= 10^5
 * nums.length == n + 1
 * 1 <= nums[i] <= n
 * All the integers in nums appear only once except for precisely one integer
 * which appears two or more times.
 * 
 * 
 * 
 * Follow up:
 * 
 * 
 * How can we prove that at least one duplicate number must exist in nums?
 * Can you solve the problem in linear runtime complexity?
 * 
 * 
 */

// @lc code=start
using System.Reflection.Metadata.Ecma335;

public class FindDuplicateSolution
{
    public int FindDuplicate(int[] nums, bool allowToModifyArray) {
        /**
         * From ALGOEXPERT
         * Allowed to Modify Input array
         * Duplicate may not exist ( return -1 )
         * Find 1st Duplicate 
         * More than 1 Duplicate may exist
         */
        if (allowToModifyArray)  
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var cur = Math.Abs(nums[i]);
                if (nums[cur - 1] < 0)
                {
                    return cur;
                }
                else
                {
                    nums[cur - 1] = -1 * nums[cur - 1];
                }
            }
            return -1;
        }
        /*
         * THIS LEETCODE PROBLEM 
         * SOLUTION IMPLEMENTS FLOYD ALGO
         * EXACTLY ONE DUPLICATE EXIST 
         * 
         */
        else
        {
            var T= nums[0];
            var R = nums[0];

            do
            {
                T = nums[T];
                R = nums[nums[R]];
            }while( T !=R);

            T= nums[0];

            while( T !=R )
            {
                T = nums[T];
                R = nums[R];
            }
            return T;
        }
    }
}
// @lc code=end

