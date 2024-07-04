/*
 * @lc app=leetcode id=104 lang=csharp
 *
 * [104] Maximum Depth of Binary Tree
 *
 * https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
 *
 * algorithms
 * Easy (75.13%)
 * Likes:    12701
 * Dislikes: 225
 * Total Accepted:    3.1M
 * Total Submissions: 4.1M
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given the root of a binary tree, return its maximum depth.
 * 
 * A binary tree's maximum depth is the number of nodes along the longest path
 * from the root node down to the farthest leaf node.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [3,9,20,null,null,15,7]
 * Output: 3
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: root = [1,null,2]
 * Output: 2
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in the tree is in the range [0, 10^4].
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
public class BFSMaxDepthSolution {
    public int MaxDepth(TreeNode root) {
        int maxDepth = 0;

        if (root != null)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var NoOfElementsInALevel = queue.Count;

                for (int i = 0; i < NoOfElementsInALevel; i++)
                {
                    var node = queue.Dequeue();

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                }
                maxDepth++;
            }
        }

        return maxDepth;
    }
}
// @lc code=end

