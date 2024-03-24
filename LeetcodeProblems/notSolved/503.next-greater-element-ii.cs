/*
 * @lc app=leetcode id=503 lang=csharp
 *
 * [503] Next Greater Element II
 *
 * https://leetcode.com/problems/next-greater-element-ii/description/
 *
 * algorithms
 * Medium (63.72%)
 * Likes:    7753
 * Dislikes: 190
 * Total Accepted:    380.3K
 * Total Submissions: 596.7K
 * Testcase Example:  '[1,2,1]'
 *
 * Given a circular integer array nums (i.e., the next element of
 * nums[nums.length - 1] is nums[0]), return the next greater number for every
 * element in nums.
 * 
 * The next greater number of a number x is the first greater number to its
 * traversing-order next in the array, which means you could search circularly
 * to find its next greater number. If it doesn't exist, return -1 for this
 * number.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [1,2,1]
 * Output: [2,-1,2]
 * Explanation: The first 1's next greater number is 2; 
 * The number 2 can't find next greater number. 
 * The second 1's next greater number needs to search circularly, which is also
 * 2.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [1,2,3,4,3]
 * Output: [2,3,4,-1,4]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= nums.length <= 10^4
 * -10^9 <= nums[i] <= 10^9
 * 
 * 
 */

// @lc code=start
public class NextGreaterElementsSolution
{
    //public int[] NextGreaterElements(int[] nums) {
    //    var stack = new Stack<int>();
    //    var result = new int[nums.Length];
    //    int i = nums.Length * 2 -1;
    //    while (i != 0) {
    //        var Index = i % nums.Length;
    //        if (stack.Count == 0)
    //        {
    //            stack.Push(nums[Index]);
    //            result[Index] = -1;
    //            i--;
    //        }
    //        else {
    //            var peekValue = stack.Peek();
    //            if(peekValue > nums[Index]) {
    //                result[Index] = peekValue;
    //                stack.Push(nums[Index]);
    //                i--;
    //            }
    //            else
    //            {
    //                while (peekValue <= nums[Index])
    //                {
    //                    stack.Pop();
    //                    if (stack.Count == 0)
    //                    {
    //                        result[Index] = -1;
    //                        i--;
    //                        Index = i % nums.Length;
    //                    }
    //                    else
    //                    {
    //                        peekValue = stack.Peek();
    //                    }
    //                }
    //            }
    //        }
    //    }
    //    return result;  
    //}
    //
    public int[] NextGreaterElements(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 2 * n - 1; i >= 0; --i)
        {
            while (stack.Count != 0 && nums[stack.Peek()] <= nums[i % n])
            {
                stack.Pop();
            }
            result[i % n] = stack.Count == 0 ? -1 : nums[stack.Peek()];
            stack.Push(i % n);
        }

        return result;
    }
}
// @lc code=end

