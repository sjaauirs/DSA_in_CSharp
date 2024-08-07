/*
 * @lc app=leetcode id=226 lang=csharp
 *
 * [226] Invert Binary Tree
 *
 * https://leetcode.com/problems/invert-binary-tree/description/
 *
 * algorithms
 * Easy (76.67%)
 * Likes:    13915
 * Dislikes: 224
 * Total Accepted:    2.1M
 * Total Submissions: 2.7M
 * Testcase Example:  '[4,2,7,1,3,6,9]'
 *
 * Given the root of a binary tree, invert the tree, and return its root.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [4,2,7,1,3,6,9]
 * Output: [4,7,2,9,6,3,1]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: root = [2,1,3]
 * Output: [2,3,1]
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: root = []
 * Output: []
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in the tree is in the range [0, 100].
 * -100 <= Node.val <= 100
 * 
 * 
 */

// @lc code=start
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
public class InvertTreeSolution
{
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
        {
            return null;
        }

        InvertTree(root.left);
        InvertTree(root.right);

        if(root.left != null || root.right!= null)
        {
            var tempnode = root.left;
            root.left = root.right;
            root.right = tempnode;
        }


        return root; 
    }
}
// @lc code=end

