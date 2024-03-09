/*
 * @lc app=leetcode id=713 lang=csharp
 *
 * [713] Subarray Product Less Than K
 *
 * https://leetcode.com/problems/subarray-product-less-than-k/description/
 *
 * algorithms
 * Medium (46.44%)
 * Likes:    5777
 * Dislikes: 177
 * Total Accepted:    246.3K
 * Total Submissions: 530.4K
 * Testcase Example:  '[10,5,2,6]\n100'
 *
 * Given an array of integers nums and an integer k, return the number of
 * contiguous subarrays where the product of all the elements in the subarray
 * is strictly less than k.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [10,5,2,6], k = 100
 * Output: 8
 * Explanation: The 8 subarrays that have product less than 100 are:
 * [10], [5], [2], [6], [10, 5], [5, 2], [2, 6], [5, 2, 6]
 * Note that [10, 5, 2] is not included as the product of 100 is not strictly
 * less than k.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [1,2,3], k = 0
 * Output: 0
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 3 * 10^4
 * 1 <= nums[i] <= 1000
 * 0 <= k <= 10^6
 * 
 * 
 */

// @lc code=start
public class Solution2 {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
         int i=0; int j=0;  
        int count = 0; 
        while(i<nums.Length){
            var product = 1;
            while (j < nums.Length && (product* nums[j]<k)) {
                count++;
                product *= nums[j];
                j++;
            }
            i++;
            j = i;
        }
        return count; 
    }
        
}
// @lc code=end

  