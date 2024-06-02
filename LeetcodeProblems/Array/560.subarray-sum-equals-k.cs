/*
 * @lc app=leetcode id=560 lang=csharp
 *
 * [560] Subarray Sum Equals K
 *
 * https://leetcode.com/problems/subarray-sum-equals-k/description/
 *
 * algorithms
 * Medium (43.45%)
 * Likes:    21197
 * Dislikes: 641
 * Total Accepted:    1.2M
 * Total Submissions: 2.8M
 * Testcase Example:  '[1,1,1]\n2'
 *
 * Given an array of integers nums and an integer k, return the total number of
 * subarrays whose sum equals to k.
 * 
 * A subarray is a contiguous non-empty sequence of elements within an
 * array.
 * 
 * 
 * Example 1:
 * Input: nums = [1,1,1], k = 2
 * Output: 2
 * Example 2:
 * Input: nums = [1,2,3], k = 3
 * Output: 2
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 2 * 10^4
 * -1000 <= nums[i] <= 1000
 * -10^7 <= k <= 10^7
 * 
 * 
 */

// @lc code=start
public class SubarraySumSolution
{
    // based on leetcode vedio
    public int SubarraySum(int[] nums, int k) {
        var count = 0;
        var prefixSum = 0;
        var pfmap = new Dictionary<int, int>();

        pfmap.Add(0, 1); // initialize the Dictionary with prefix 0 and fequency 1

        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];

            if (pfmap.ContainsKey(prefixSum - k))  // THIS SHOULD COME first
            {
                count = count + pfmap[prefixSum - k];
            }

            if (pfmap.ContainsKey(prefixSum))
            {
                pfmap[prefixSum] = pfmap[prefixSum] + 1;
            }
            else
            {
                pfmap.Add(prefixSum, 1);
            }


        }
        return count;
    }
}
// @lc code=end

