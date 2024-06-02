/*
 * @lc app=leetcode id=2461 lang=csharp
 *
 * [2461] Maximum Sum of Distinct Subarrays With Length K
 *
 * https://leetcode.com/problems/maximum-sum-of-distinct-subarrays-with-length-k/description/
 *
 * algorithms
 * Medium (33.80%)
 * Likes:    1242
 * Dislikes: 22
 * Total Accepted:    51K
 * Total Submissions: 150.9K
 * Testcase Example:  '[1,5,4,2,9,9,9]\n3'
 *
 * You are given an integer array nums and an integer k. Find the maximum
 * subarray sum of all the subarrays of nums that meet the following
 * conditions:
 * 
 * 
 * The length of the subarray is k, and
 * All the elements of the subarray are distinct.
 * 
 * 
 * Return the maximum subarray sum of all the subarrays that meet the
 * conditions. If no subarray meets the conditions, return 0.
 * 
 * A subarray is a contiguous non-empty sequence of elements within an
 * array.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,5,4,2,9,9,9], k = 3
 * Output: 15
 * Explanation: The subarrays of nums with length 3 are:
 * - [1,5,4] which meets the requirements and has a sum of 10.
 * - [5,4,2] which meets the requirements and has a sum of 11.
 * - [4,2,9] which meets the requirements and has a sum of 15.
 * - [2,9,9] which does not meet the requirements because the element 9 is
 * repeated.
 * - [9,9,9] which does not meet the requirements because the element 9 is
 * repeated.
 * We return 15 because it is the maximum subarray sum of all the subarrays
 * that meet the conditions
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [4,4,4], k = 3
 * Output: 0
 * Explanation: The subarrays of nums with length 3 are:
 * - [4,4,4] which does not meet the requirements because the element 4 is
 * repeated.
 * We return 0 because no subarrays meet the conditions.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= k <= nums.length <= 10^5
 * 1 <= nums[i] <= 10^5
 * 
 * 
 */

// @lc code=start
public class MaximumSubarraySumSolution
{
    public long MaximumSubarraySum(int[] nums, int k)
    {
        var sum = 0;
        var maxSum = 0;
        int i = 0;
        var dict = new Dictionary<int, int>();
        for (int j = 0; j < nums.Length; j++)
        {

            sum += nums[j];
            if (dict.ContainsKey(nums[j]))
            {
                dict[nums[j]] = dict[nums[j]] + 1;
            }
            else
            {
                dict.Add(nums[j], 1);
            }

            if(j-i+1 ==k) // window length is k
            { 
                if (dict.Count == k) // there are K different element in window
                {
                    maxSum = Math.Max(sum, maxSum);
                }
               // Since window had reached its size, move window start
                sum = sum - nums[i];
                dict[nums[i]] = dict[nums[i]] - 1;

                if (dict[nums[i]] == 0)
                {
                    dict.Remove(nums[i]);
                }

                i++;
            }
        }
        return maxSum;
    }
}
// @lc code=end

/*
 * SLIDING WINDOW
 * 1. For Loop to expend J , to create the window
 * 2. if window have distinct element , update the maxSum
 * 3. move window to right by moving i;
 */

