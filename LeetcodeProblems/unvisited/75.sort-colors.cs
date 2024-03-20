/*
 * @lc app=leetcode id=75 lang=csharp
 *
 * [75] Sort Colors
 *
 * https://leetcode.com/problems/sort-colors/description/
 *
 * algorithms
 * Medium (60.38%)
 * Likes:    16765
 * Dislikes: 577
 * Total Accepted:    1.6M
 * Total Submissions: 2.7M
 * Testcase Example:  '[2,0,2,1,1,0]'
 *
 * Given an array nums with n objects colored red, white, or blue, sort them
 * in-place so that objects of the same color are adjacent, with the colors in
 * the order red, white, and blue.
 * 
 * We will use the integers 0, 1, and 2 to represent the color red, white, and
 * blue, respectively.
 * 
 * You must solve this problem without using the library's sort function.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [2,0,2,1,1,0]
 * Output: [0,0,1,1,2,2]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [2,0,1]
 * Output: [0,1,2]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * n == nums.length
 * 1 <= n <= 300
 * nums[i] is either 0, 1, or 2.
 * 
 * 
 * 
 * Follow up: Could you come up with a one-pass algorithm using only constant
 * extra space?
 * 
 */

// @lc code=start
public class SolutionSortColors{
    public void SortColors(int[] nums) {
        int posl = 0; 
        int posh = nums.Length-1;
        int i =0;
        while(i<=posh){
             if(nums[i]==0){
                swap(nums, posl , i);
                posl++;
            }
             if(nums[i]==2){
                swap(nums, posh , i);
                posh--;
            }else{
                i++;
            }
        }

    }
   void swap(int[] nums , int p , int q){
        var temp = nums[p]; 
        nums[p] = nums[q];
        nums[q] =temp;
    }
}
// @lc code=end

