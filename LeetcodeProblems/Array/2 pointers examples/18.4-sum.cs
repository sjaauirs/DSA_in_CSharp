/*
 * @lc app=leetcode id=18 lang=csharp
 *
 * [18] 4Sum
 *
 * https://leetcode.com/problems/4sum/description/
 *
 * algorithms
 * Medium (36.15%)
 * Likes:    11128
 * Dislikes: 1364
 * Total Accepted:    949.1K
 * Total Submissions: 2.6M
 * Testcase Example:  '[1,0,-1,0,-2,2]\n0'
 *
 * Given an array nums of n integers, return an array of all the unique
 * quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
 * 
 * 
 * 0 <= a, b, c, d < n
 * a, b, c, and d are distinct.
 * nums[a] + nums[b] + nums[c] + nums[d] == target
 * 
 * 
 * You may return the answer in any order.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,0,-1,0,-2,2], target = 0
 * Output: [[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [2,2,2,2,2], target = 8
 * Output: [[2,2,2,2]]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 200
 * -10^9 <= nums[i] <= 10^9
 * -10^9 <= target <= 10^9
 * 
 * 
 */

// @lc code=start
using System.Collections.Generic;

public class FourSumSolution
{
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length-3; i++)
        {
            if (i>0 && nums[i]== nums[i - 1])    // Skip same i
            {
                continue;
            }
            for(int j = i+1;j<nums.Length-2; j++)
            {
                if (j> i+1 && nums[j]== nums[j - 1])  // skip same j
                {
                    continue;
                }
                TwoSum(nums, target, i, j, result);
            }

        }
        return result;
    }
    public void TwoSum(int[] nums, int target , int i, int j, List<IList<int>> result) {
        int start = j + 1;
        int end = nums.Length - 1;
        int newTraget = target - nums[i] - nums[j];
        var sum = 0;
        while (start < end)
        {
            sum = nums[start]+ nums[end];
            if(sum > newTraget) {
                end--;
            }
            if(sum < newTraget)
            {
                start++;
            }
            if (sum == newTraget)
            {
                result.Add(new List<int>() { nums[i], nums[j] , nums[start], nums[end] });
                start++;
                end--;
                while (start < end && nums[start] == nums[start - 1])
                    start++; // skip same element to avoid duplicate quadruplets
                while (start < end && nums[end] == nums[end + 1])
                    end--; // skip same element to avoid duplicate quadruplets
            }
        }
    }
}
// @lc code=end

