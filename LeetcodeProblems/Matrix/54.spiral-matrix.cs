/*
 * @lc app=leetcode id=54 lang=csharp
 *
 * [54] Spiral Matrix
 *
 * https://leetcode.com/problems/spiral-matrix/description/
 *
 * algorithms
 * Medium (48.98%)
 * Likes:    14461
 * Dislikes: 1277
 * Total Accepted:    1.4M
 * Total Submissions: 2.8M
 * Testcase Example:  '[[1,2,3],[4,5,6],[7,8,9]]'
 *
 * Given an m x n matrix, return all elements of the matrix in spiral order.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
 * Output: [1,2,3,6,9,8,7,4,5]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
 * Output: [1,2,3,4,8,12,11,10,9,5,6,7]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * m == matrix.length
 * n == matrix[i].length
 * 1 <= m, n <= 10
 * -100 <= matrix[i][j] <= 100
 * 
 * 
 */

// @lc code=start
public class SpiralOrderSolution
{
    public IList<int> SpiralOrder(int[][] matrix) {
        
        //below colution based on leetcode

        var result= new List<int>();

        var C1 = 0; 
        var C2 = matrix[0].Length-1;
        var C3 = matrix.Length-1;
        var C4 = 0;
        var totalelement = (matrix[0].Length) * (matrix.Length);

        while(result.Count < totalelement)
        {
            // go right
            for( int i = C1; i <= C2 && result.Count< totalelement; i++ )
            {
                result.Add(matrix[C1][i]);
            }

            // go down 

            for (int i = C1+1; i <= C3 && result.Count < totalelement; i++)
            {
                result.Add(matrix[i][C2]);
            }

            // go left 

            for (int i = C2-1; i >= C4 && result.Count < totalelement; i--)
            {
                result.Add(matrix[C3][i]);
            }

            // go right 

            for (int i = C3-1; i > C1 && result.Count < totalelement; i--)
            {
                result.Add(matrix[i][C4]);
            }

            C1++;C2--; C3--;C4++;
        }

        return result;


    }
}
// @lc code=end

