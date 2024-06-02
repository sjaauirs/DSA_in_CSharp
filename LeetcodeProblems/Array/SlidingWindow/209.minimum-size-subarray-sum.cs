/*
 * @lc app=leetcode id=209 lang=csharp
 *
 * [209] Minimum Size Subarray Sum
 *
 * https://leetcode.com/problems/minimum-size-subarray-sum/description/
 *
 * algorithms
 * Medium (46.86%)
 * Likes:    12298
 * Dislikes: 402
 * Total Accepted:    981.7K
 * Total Submissions: 2.1M
 * Testcase Example:  '7\n[2,3,1,2,4,3]'
 *
 * Given an array of positive integers nums and a positive integer target,
 * return the minimal length of a subarray whose sum is greater than or equal
 * to target. If there is no such subarray, return 0 instead.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: target = 7, nums = [2,3,1,2,4,3]
 * Output: 2
 * Explanation: The subarray [4,3] has the minimal length under the problem
 * constraint.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: target = 4, nums = [1,4,4]
 * Output: 1
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: target = 11, nums = [1,1,1,1,1,1,1,1]
 * Output: 0
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= target <= 10^9
 * 1 <= nums.length <= 10^5
 * 1 <= nums[i] <= 10^4
 * 
 * 
 * 
 * Follow up: If you have figured out the O(n) solution, try coding another
 * solution of which the time complexity is O(n log(n)).
 */

// @lc code=start
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

public class MinimumSizeSubarraySum {
    public int MinSubArrayLen(int target, int[] nums) {
        #region MySolution- 4 Hrs
        //int i = 0;
        //int j = 0;
        //int Wsize = 0;
        //int ws = nums[i];
        //while (ws < target && j< nums.Length-1) {
        //    j++; 
        //    ws = ws+ nums[j];
        //}
        //if (j == nums.Length - 1)
        //{
        //    return Wsize;
        //}
        //else
        //{
        //    Wsize = j - i + 1;
        //}

        //while(j< nums.Length-1 || ws >= target)  // Adding this condition makes Error and removing also make error
        //{
        //    if(ws>target)
        //    {
        //        while (ws >= target)
        //        {
        //            Wsize = Math.Min(Wsize, (j - i + 1));
        //            ws = ws - nums[i];
        //            i++;
        //        }
        //    }
        //    else
        //    {
        //        j++;
        //        ws= ws+ nums[j];
        //    }

        //}

        //return Wsize;
        #endregion

        // FROM Design Guru

        int windowSum = 0, minLength = Int32.MaxValue;
        int i = 0;int j = 0;
        while(j<nums.Length) 
        {
            windowSum += nums[j]; // add the next element
            // shrink the window as small as possible until the 'windowSum' is smaller than 'S'
            while (windowSum >= target)
            {
                minLength = Math.Min(minLength, j - i + 1);
                windowSum -= nums[i]; // subtract the element going out
                i++; // slide the window ahead
            }
            j++;
        }

        return minLength == Int32.MaxValue ? 0 : minLength;
    }
}
// @lc code=end

