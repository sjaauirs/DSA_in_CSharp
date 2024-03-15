/*
 * @lc app=leetcode id=268 lang=csharp
 *
 * [268] Missing Number
 *
 * https://leetcode.com/problems/missing-number/description/
 *
 * algorithms
 * Easy (66.44%)
 * Likes:    11773
 * Dislikes: 3300
 * Total Accepted:    2.1M
 * Total Submissions: 3.2M
 * Testcase Example:  '[3,0,1]'
 *
 * Given an array nums containing n distinct numbers in the range [0, n],
 * return the only number in the range that is missing from the array.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [3,0,1]
 * Output: 2
 * Explanation: n = 3 since there are 3 numbers, so all numbers are in the
 * range [0,3]. 2 is the missing number in the range since it does not appear
 * in nums.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [0,1]
 * Output: 2
 * Explanation: n = 2 since there are 2 numbers, so all numbers are in the
 * range [0,2]. 2 is the missing number in the range since it does not appear
 * in nums.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: nums = [9,6,4,2,3,5,7,0,1]
 * Output: 8
 * Explanation: n = 9 since there are 9 numbers, so all numbers are in the
 * range [0,9]. 8 is the missing number in the range since it does not appear
 * in nums.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * n == nums.length
 * 1 <= n <= 10^4
 * 0 <= nums[i] <= n
 * All the numbers of nums are unique.
 * 
 * 
 * 
 * Follow up: Could you implement a solution using only O(1) extra space
 * complexity and O(n) runtime complexity?
 * 
 */

// @lc code=start
public class Solution {
    public int MissingNumber(int[] nums) {
        int i = 0;

        while (i < nums.Length)
        {
            var j = nums[i] - 1;
            if (i != j && nums[i] != 0)
            {
                swap(nums, i, j);
            }
            else
            {
                i++;
            }
        }


        // find the first number missing from its index, that will be our required number
        for (i = 0; i < nums.Length; i++)
            if (nums[i] == 0)
                return i+1;

        return 0;

    }

    private void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
// @lc code=end

