/*
 * @lc app=leetcode id=735 lang=csharp
 *
 * [735] Asteroid Collision
 *
 * https://leetcode.com/problems/asteroid-collision/description/
 *
 * algorithms
 * Medium (44.59%)
 * Likes:    7659
 * Dislikes: 988
 * Total Accepted:    477K
 * Total Submissions: 1.1M
 * Testcase Example:  '[5,10,-5]'
 *
 * We are given an array asteroids of integers representing asteroids in a
 * row.
 * 
 * For each asteroid, the absolute value represents its size, and the sign
 * represents its direction (positive meaning right, negative meaning left).
 * Each asteroid moves at the same speed.
 * 
 * Find out the state of the asteroids after all collisions. If two asteroids
 * meet, the smaller one will explode. If both are the same size, both will
 * explode. Two asteroids moving in the same direction will never meet.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: asteroids = [5,10,-5]
 * Output: [5,10]
 * Explanation: The 10 and -5 collide resulting in 10. The 5 and 10 never
 * collide.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: asteroids = [8,-8]
 * Output: []
 * Explanation: The 8 and -8 collide exploding each other.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: asteroids = [10,2,-5]
 * Output: [10]
 * Explanation: The 2 and -5 collide resulting in -5. The 10 and -5 collide
 * resulting in 10.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 2 <= asteroids.length <= 10^4
 * -1000 <= asteroids[i] <= 1000
 * asteroids[i] != 0
 * 
 * 
 */

// @lc code=start

public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();
        
        foreach (int asteroid in asteroids)
        {

            if (stack.Count == 0 || CheckDirection(asteroid, stack.Peek()) == 0)
            {
                stack.Push(asteroid);
            }
            while (stack.Count > 0 && CheckDirection(asteroid, stack.Peek())==1)
             {
                 if(Math.Abs(asteroid) >= Math.Abs(stack.Peek()))
                {
                    stack.Pop();
                }
                else
                {
                    break;
                }
             }
            
        }
        int[] result = new int[stack.Count];
        for(int i = 0; i < result.Length; i++)
        {
            result[i] = stack.Pop();
        }
        var rev=  result.Reverse<int>();
        return rev.ToArray();
    }

    private int CheckDirection(int asteroid , int peek)
    {
       if((asteroid < 0  && peek>0)  || (asteroid > 0 && peek < 0))
        {
            return 1;
        }
        return 0;
    }
}
// @lc code=end

