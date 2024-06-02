/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 *
 * https://leetcode.com/problems/3sum/description/
 *
 * algorithms
 * Medium (34.25%)
 * Likes:    30339
 * Dislikes: 2804
 * Total Accepted:    3.5M
 * Total Submissions: 10.1M
 * Testcase Example:  '[-1,0,1,2,-1,-4]'
 *
 * Given an integer array nums, return all the triplets [nums[i], nums[j],
 * nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] +
 * nums[k] == 0.
 * 
 * Notice that the solution set must not contain duplicate triplets.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [-1,0,1,2,-1,-4]
 * Output: [[-1,-1,2],[-1,0,1]]
 * Explanation: 
 * nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
 * nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
 * nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
 * The distinct triplets are [-1,0,1] and [-1,-1,2].
 * Notice that the order of the output and the order of the triplets does not
 * matter.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [0,1,1]
 * Output: []
 * Explanation: The only possible triplet does not sum up to 0.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: nums = [0,0,0]
 * Output: [[0,0,0]]
 * Explanation: The only possible triplet sums up to 0.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 3 <= nums.length <= 3000
 * -10^5 <= nums[i] <= 10^5
 * 
 * 
 */

// @lc code=start

public class ThreeSumSolution
{
    public IList<IList<int>> ThreeSum(int[] nums) {
        System.Array.Sort(nums);
        var target = 0;
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]  == nums[i - 1])
            {
                continue;
            }
            var triplets = getTriplets(nums, i,target);
            if(triplets.Any()) {
            result.AddRange(triplets);
            }
        }
        return result;
    }

    private List<IList<int>> getTriplets(int[] nums, int i, int target)
    {
        int pivot = nums[i];
        var start = i + 1;
        var end = nums.Length - 1;
        var mresult = new List<IList<int>>();
        
        while (start < end)
        {
            var sum = pivot+ nums[start] + nums[end];
            if (sum == target)
            {
                mresult.Add(new List<int> {pivot, start, end });
                start++;end--;
            }
            if(sum > target)
            {
                end--;
            }
            if(sum < target)
            {
                start++;
            }
        }
        return mresult;
    }
}
// @lc code=end

