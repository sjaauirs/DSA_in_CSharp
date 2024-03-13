/*
 * @lc app=leetcode id=904 lang=csharp
 *
 * [904] Fruit Into Baskets
 *
 * https://leetcode.com/problems/fruit-into-baskets/description/
 *
 * algorithms
 * Medium (43.97%)
 * Likes:    4496
 * Dislikes: 326
 * Total Accepted:    386.6K
 * Total Submissions: 879.2K
 * Testcase Example:  '[1,2,1]'
 *
 * You are visiting a farm that has a single row of fruit trees arranged from
 * left to right. The trees are represented by an integer array fruits where
 * fruits[i] is the type of fruit the i^th tree produces.
 * 
 * You want to collect as much fruit as possible. However, the owner has some
 * strict rules that you must follow:
 * 
 * 
 * You only have two baskets, and each basket can only hold a single type of
 * fruit. There is no limit on the amount of fruit each basket can hold.
 * Starting from any tree of your choice, you must pick exactly one fruit from
 * every tree (including the start tree) while moving to the right. The picked
 * fruits must fit in one of your baskets.
 * Once you reach a tree with fruit that cannot fit in your baskets, you must
 * stop.
 * 
 * 
 * Given the integer array fruits, return the maximum number of fruits you can
 * pick.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: fruits = [1,2,1]
 * Output: 3
 * Explanation: We can pick from all 3 trees.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: fruits = [0,1,2,2]
 * Output: 3
 * Explanation: We can pick from trees [1,2,2].
 * If we had started at the first tree, we would only pick from trees [0,1].
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: fruits = [1,2,3,2,2]
 * Output: 4
 * Explanation: We can pick from trees [2,3,2,2].
 * If we had started at the first tree, we would only pick from trees
 * [1,2].
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= fruits.length <= 10^5
 * 0 <= fruits[i] < fruits.length
 * 
 * 
 * NOTE: the Question is exactly similar to LongestSubstringWithAtMostKDistinct 340.
 * I tried to implement it after reading the solution from design Guru but it was failing.
 * finally copied the code
 * 
 */

// @lc code=start
public class FruitIntoBaskets
{
    public int TotalFruit(int[] fruits) {
        int maxSize = 0;
        int i = 0;
        var basket = new Dictionary<int, int>();

        for (int r = 0; r < fruits.Length; r++)
        {
            if (!basket.ContainsKey(fruits[r]))
            {
                basket[fruits[r]] = 0;
            }
            basket[fruits[r]]++;

            while (basket.Keys.Count > 2) // Basket is invalid
            {
                var windowRight = fruits[i];
                basket[windowRight] = basket[windowRight] - 1;

                if (basket[windowRight] == 0)
                {
                    basket.Remove(windowRight);
                }
                i++;
            }
            maxSize = Math.Max(maxSize, r - i+1);    // here window is calculated after each window extend
        }

        return maxSize;
        
    }
}


/*
 * public int fn(int[] arr) {
    int left = 0, ans = 0, curr = 0;

    for (int right = 0; right < arr.length; right++) {
        // do logic here to add arr[right] to curr

        while (WINDOW_CONDITION_BROKEN) {
            // remove arr[left] from curr
            left++;
        }

        // update ans
    }

    return ans;
}
*/


// @lc code=end

