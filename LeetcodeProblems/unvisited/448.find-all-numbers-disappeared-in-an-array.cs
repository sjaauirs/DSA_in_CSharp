/*
 * @lc app=leetcode id=448 lang=csharp
 *
 * [448] Find All Numbers Disappeared in an Array
 *
 * https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
 *
 * algorithms
 * Easy (60.78%)
 * Likes:    9243
 * Dislikes: 476
 * Total Accepted:    854.8K
 * Total Submissions: 1.4M
 * Testcase Example:  '[4,3,2,7,8,2,3,1]'
 *
 * Given an array nums of n integers where nums[i] is in the range [1, n],
 * return an array of all the integers in the range [1, n] that do not appear
 * in nums.
 * 
 * 
 * Example 1:
 * Input: nums = [4,3,2,7,8,2,3,1]
 * Output: [5,6]
 * Example 2:
 * Input: nums = [1,1]
 * Output: [2]
 * 
 * 
 * Constraints:
 * 
 * 
 * n == nums.length
 * 1 <= n <= 10^5
 * 1 <= nums[i] <= n
 * 
 * 
 * 
 * Follow up: Could you do it without extra space and in O(n) runtime? You may
 * assume the returned list does not count as extra space.
 * 
 */

// @lc code=start
public class FindDisappearedNumbers {
    public IList<int> Solution(int[] nums)
    {

        int i = 0;
        while (i < nums.Length)
        {
            if (nums[i] > 0 && nums[i] <= nums.Length)  // if it is a valid number
            {
                if (nums[i] != nums[nums[i] - 1]) // number is not at correct position 
                {
                    swap(nums, i, nums[i] - 1);
                }
                else { i++; }
            }
            else { i++; }
        }

            var disappearedNumbers = new List<int>();
        // find the first number missing from its index, that will be our required number
        for (i = 0; i < nums.Length; i++)
            if (nums[i] != i + 1)
                disappearedNumbers.Add(i + 1);

        return disappearedNumbers;

    }

    private void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

}
// @lc code=end

