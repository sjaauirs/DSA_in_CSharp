/*
 * ALGOEXPERT
 * @lc app=leetcode id=977 lang=csharp
 *
 * [977] Squares of a Sorted Array
 *
 * https://leetcode.com/problems/squares-of-a-sorted-array/description/
 *
 * algorithms
 * Easy (72.78%)
 * Likes:    9209
 * Dislikes: 236
 * Total Accepted:    1.8M
 * Total Submissions: 2.5M
 * Testcase Example:  '[-4,-1,0,3,10]'
 *
 * Given an integer array nums sorted in non-decreasing order, return an array
 * of the squares of each number sorted in non-decreasing order.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [-4,-1,0,3,10]
 * Output: [0,1,9,16,100]
 * Explanation: After squaring, the array becomes [16,1,0,9,100].
 * After sorting, it becomes [0,1,9,16,100].
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [-7,-3,2,3,11]
 * Output: [4,9,9,49,121]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 10^4
 * -10^4 <= nums[i] <= 10^4
 * nums is sorted in non-decreasing order.
 * 
 * 
 * 
 * Follow up: Squaring each element and sorting the new array is very trivial,
 * could you find an O(n) solution using a different approach?
 */

// @lc code=start
public class SortedSquaresSolution
{
    public int[] SortedSquares(int[] nums) {
        
        var result = new int[nums.Length];
        for(int i = 0; i< nums.Length; i++)
        {
            var next = i; 
            var sq = nums[i]* nums[i];
            while(next > 0 && sq < result[next-1]) {
                result[next] = result[next--];
            }
            result[next]= sq;
        }
        return result;
    }
}
// @lc code=end

