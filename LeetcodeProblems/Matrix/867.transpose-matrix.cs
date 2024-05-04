/*
 * @lc app=leetcode id=867 lang=csharp
 *
 * [867] Transpose Matrix
 *
 * https://leetcode.com/problems/transpose-matrix/description/
 *
 * algorithms
 * Easy (71.09%)
 * Likes:    3682
 * Dislikes: 444
 * Total Accepted:    391.1K
 * Total Submissions: 547.7K
 * Testcase Example:  '[[1,2,3],[4,5,6],[7,8,9]]'
 *
 * Given a 2D integer array matrix, return the transpose of matrix.
 * 
 * The transpose of a matrix is the matrix flipped over its main diagonal,
 * switching the matrix's row and column indices.
 * 
 * 
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
 * Output: [[1,4,7],[2,5,8],[3,6,9]]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: matrix = [[1,2,3],[4,5,6]]
 * Output: [[1,4],[2,5],[3,6]]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * m == matrix.length
 * n == matrix[i].length
 * 1 <= m, n <= 1000
 * 1 <= m * n <= 10^5
 * -10^9 <= matrix[i][j] <= 10^9
 * 
 * 
 */

// @lc code=start
using System.Data.Common;

public class TransposeSolution
{
    public int[][] Transpose(int[][] matrix) {
        var rows = matrix.Length;
        var cols = matrix[0].Length;

        var result = new int[cols][];    // we cant just declare int [][] transpose = new int[m][n] ... c# things
        for (int i = 0; i < cols; i++) 
        {
            result[i] = new int[rows];
        }
        for ( int i = 0; i < rows; i++ )
        {
            for( int j = 0; j< cols; j++)
            {
                var item = matrix[i][j];
                result[j][i] = item;
            }
        }
        return result;
    }

    //WHEN WORKING WITH JEGGED ARRAY: ALGOEXPOERT

    /*
      public int[,] TransposeMatrix(int[,] matrix) {
    var rows = matrix.GetLength(0);
        var cols = matrix.GetLength(1);

        var result = new int[cols,rows];
        for ( int i = 0; i < rows; i++ )
        {
            for( int j = 0; j< cols; j++)
            {
                var item = matrix[i,j];
                result[j,i] = item;
            }
        }
        return result;
  }
    */
}
// @lc code=end

