/*
 * @lc app=leetcode id=41 lang=csharp
 *
 * [41] First Missing Positive
 *
 * https://leetcode.com/problems/first-missing-positive/description/
 *
 * algorithms
 * Hard (37.84%)
 * Likes:    15818
 * Dislikes: 1781
 * Total Accepted:    1M
 * Total Submissions: 2.8M
 * Testcase Example:  '[1,2,0]'
 *
 * Given an unsorted integer array nums. Return the smallest positive integer
 * that is not present in nums.
 * 
 * You must implement an algorithm that runs in O(n) time and uses O(1)
 * auxiliary space.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,2,0]
 * Output: 3
 * Explanation: The numbers in the range [1,2] are all in the array.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [3,4,-1,1]
 * Output: 2
 * Explanation: 1 is in the array but 2 is missing.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: nums = [7,8,9,11,12]
 * Output: 1
 * Explanation: The smallest positive integer 1 is missing.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 10^5
 * -2^31 <= nums[i] <= 2^31 - 1
 * 
 * 
 */

// @lc code=start
public class FirstMissingPositive {
    public int FirstMissingsolution(int[] nums) {
        int i = 0; 

        while( i < nums.Length)
        {
            if (nums[i] > 0 && nums[i] < nums.Length)  // if it is a valid number
            {
                if (nums[i] != nums[nums[i] - 1]) // number is not at correct position 
                {
                    swap(nums, i, nums[i] - 1);
                }
                else { i++; }
            }
            else { i++; }
        }


        // find the first number missing from its index, that will be our required number
        for (i = 0; i < nums.Length; i++)
            if (nums[i] != i + 1)
                return i + 1;

        return nums.Length + 1;       
    }

    private void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
// @lc code=end

