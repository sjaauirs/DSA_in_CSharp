/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 *
 * https://leetcode.com/problems/majority-element/description/
 *
 * algorithms
 * Easy (64.67%)
 * Likes:    18796
 * Dislikes: 603
 * Total Accepted:    2.8M
 * Total Submissions: 4.3M
 * Testcase Example:  '[3,2,3]'
 *
 * Given an array nums of size n, return the majority element.
 * 
 * The majority element is the element that appears more than ⌊n / 2⌋ times.
 * You may assume that the majority element always exists in the array.
 * 
 * 
 * Example 1:
 * Input: nums = [3,2,3]
 * Output: 3
 * Example 2:
 * Input: nums = [2,2,1,1,1,2,2]
 * Output: 2
 * 
 * 
 * Constraints:
 * 
 * 
 * n == nums.length
 * 1 <= n <= 5 * 10^4
 * -10^9 <= nums[i] <= 10^9
 * 
 * 
 * 
 * Follow-up: Could you solve the problem in linear time and in O(1) space?
 */

// @lc code=start
public class MajorityElementSolution
{
    public int MajorityElement(int[] nums) {
         int answer = nums[0];
        int count = 1;

        for( int i = 1; i< nums.Length; i++){
            if(answer == nums[i]){
                count++;
            }
            else{
                count--;
            }
            if(count ==0){
                i++;
                answer = nums[i];
                count=1;
            }
        }
        return answer;
    }
}
// @lc code=end

