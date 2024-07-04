/*
 * @lc app=leetcode id=129 lang=csharp
 *
 * [129] Sum Root to Leaf Numbers
 *
 * https://leetcode.com/problems/sum-root-to-leaf-numbers/description/
 *
 * algorithms
 * Medium (63.37%)
 * Likes:    7983
 * Dislikes: 140
 * Total Accepted:    889.1K
 * Total Submissions: 1.3M
 * Testcase Example:  '[1,2,3]'
 *
 * You are given the root of a binary tree containing digits from 0 to 9 only.
 * 
 * Each root-to-leaf path in the tree represents a number.
 * 
 * 
 * For example, the root-to-leaf path 1 -> 2 -> 3 represents the number 123.
 * 
 * 
 * Return the total sum of all root-to-leaf numbers. Test cases are generated
 * so that the answer will fit in a 32-bit integer.
 * 
 * A leaf node is a node with no children.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [1,2,3]
 * Output: 25
 * Explanation:
 * The root-to-leaf path 1->2 represents the number 12.
 * The root-to-leaf path 1->3 represents the number 13.
 * Therefore, sum = 12 + 13 = 25.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: root = [4,9,0,5,1]
 * Output: 1026
 * Explanation:
 * The root-to-leaf path 4->9->5 represents the number 495.
 * The root-to-leaf path 4->9->1 represents the number 491.
 * The root-to-leaf path 4->0 represents the number 40.
 * Therefore, sum = 495 + 491 + 40 = 1026.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in the tree is in the range [1, 1000].
 * 0 <= Node.val <= 9
 * The depth of the tree will not exceed 10.
 * 
 * 
 */

// @lc code=start

using System.IO;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class DFS_Solution {
    public int SumNumbers(TreeNode root) {
        int sum = 0;
        var stack = new Stack<(TreeNode root,  List<int> pathitems)>();

        stack.Push((root, new List<int> { root.val}));

        while (stack.Count > 0)
        {
            var (cur, pathitems) = stack.Pop();

            if(cur.left != null) {
                var newPath = new List<int>(pathitems) { cur.left.val };
                stack.Push((cur.left, newPath));
            }

            if(cur.right != null) {
                var newPath = new List<int>(pathitems) { cur.right.val };
                stack.Push((cur.right, newPath));
            }

            if(cur.left == null && cur.right== null) {
            // we are at leaf
            var ListNumber = ConvertListToNumber(pathitems);
            sum = sum+ ListNumber;

            }
        }
            return sum; 
    }

    int ConvertListToNumber(List<int> digits)
    {
        string concatenatedString = string.Concat(digits);
        int number = int.Parse(concatenatedString);
        return number;
    }
}
// @lc code=end

