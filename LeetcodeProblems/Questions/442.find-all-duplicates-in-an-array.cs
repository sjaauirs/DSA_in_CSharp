/*
 * @lc app=leetcode id=442 lang=csharp
 *
 * [442] Find All Duplicates in an Array
 *
 * https://leetcode.com/problems/find-all-duplicates-in-an-array/description/
 *
 * algorithms
 * Medium (73.64%)
 * Likes:    9559
 * Dislikes: 342
 * Total Accepted:    607.4K
 * Total Submissions: 824.5K
 * Testcase Example:  '[4,3,2,7,8,2,3,1]'
 *
 * Given an integer array nums of length n where all the integers of nums are
 * in the range [1, n] and each integer appears once or twice, return an array
 * of all the integers that appears twice.
 * 
 * You must write an algorithm that runs in O(n) time and uses only constant
 * extra space.
 * 
 * 
 * Example 1:
 * Input: nums = [4,3,2,7,8,2,3,1]
 * Output: [2,3]
 * Example 2:
 * Input: nums = [1,1,2]
 * Output: [1]
 * Example 3:
 * Input: nums = [1]
 * Output: []
 * 
 * 
 * Constraints:
 * 
 * 
 * n == nums.length
 * 1 <= n <= 10^5
 * 1 <= nums[i] <= n
 * Each element in nums appears once or twice.
 * 
 * 
 */

// @lc code=start
public class FindDuplicates {
    public IList<int> solution(int[] nums) {
        int i = 0; 
        while (i < nums.Length)
        {
            if (nums[i]<=0 && nums[i]> nums.Length)
            {
                throw new InvalidDataException("Data not as per question");
            }
            if (nums[i]!= nums[nums[i] - 1])
            {
                swap(nums , i, nums[i]-1);
            }
            else
            {
                i++;
            }
        }

        var duplicateNumbers = new List<int>();
        for (i = 0; i < nums.Length; i++)
            if (nums[i] != i + 1)
                duplicateNumbers.Add(nums[i]);

        return duplicateNumbers;
    }
    private void swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
// @lc code=end

