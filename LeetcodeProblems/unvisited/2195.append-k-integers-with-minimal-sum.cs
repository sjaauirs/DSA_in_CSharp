/*
 * @lc app=leetcode id=2195 lang=csharp
 *
 * [2195] Append K Integers With Minimal Sum
 *
 * https://leetcode.com/problems/append-k-integers-with-minimal-sum/description/
 *
 * algorithms
 * Medium (25.12%)
 * Likes:    712
 * Dislikes: 301
 * Total Accepted:    30.5K
 * Total Submissions: 121.3K
 * Testcase Example:  '[1,4,25,10,25]\n2'
 *
 * You are given an integer array nums and an integer k. Append k unique
 * positive integers that do not appear in nums to nums such that the resulting
 * total sum is minimum.
 * 
 * Return the sum of the k integers appended to nums.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,4,25,10,25], k = 2
 * Output: 5
 * Explanation: The two unique positive integers that do not appear in nums
 * which we append are 2 and 3.
 * The resulting sum of nums is 1 + 4 + 25 + 10 + 25 + 2 + 3 = 70, which is the
 * minimum.
 * The sum of the two integers appended is 2 + 3 = 5, so we return 5.
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [5,6], k = 6
 * Output: 25
 * Explanation: The six unique positive integers that do not appear in nums
 * which we append are 1, 2, 3, 4, 7, and 8.
 * The resulting sum of nums is 5 + 6 + 1 + 2 + 3 + 4 + 7 + 8 = 36, which is
 * the minimum. 
 * The sum of the six integers appended is 1 + 2 + 3 + 4 + 7 + 8 = 25, so we
 * return 25.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 10^5
 * 1 <= nums[i] <= 10^9
 * 1 <= k <= 10^8
 * 
 * 
 */

// @lc code=start
public class MinimalKSumSolution
{
    public long MinimalKSum(int[] nums, int k) {


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
        long minimalsum = 0;
        var sumCounter = 0; 
        var disappearedNumbers = new List<int>();

        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1 && sumCounter < k)
            {
                minimalsum = minimalsum + (i + 1);
                sumCounter++;
            }
        }

        var nextElement = nums.Length+1;   /// TODO
        if (sumCounter < k)
        {
            minimalsum = minimalsum + nextElement;
            nextElement++;
        }



        return minimalsum; 
    }

    private void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
// @lc code=end

