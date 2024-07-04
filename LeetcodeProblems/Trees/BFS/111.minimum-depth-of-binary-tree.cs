/*
 * @lc app=leetcode id=111 lang=csharp
 *
 * [111] Minimum Depth of Binary Tree
 *
 * https://leetcode.com/problems/minimum-depth-of-binary-tree/description/
 *
 * algorithms
 * Easy (47.56%)
 * Likes:    7246
 * Dislikes: 1306
 * Total Accepted:    1.2M
 * Total Submissions: 2.5M
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given a binary tree, find its minimum depth.
 * 
 * The minimum depth is the number of nodes along the shortest path from the
 * root node down to the nearest leaf node.
 * 
 * Note: A leaf is a node with no children.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [3,9,20,null,null,15,7]
 * Output: 2
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: root = [2,null,3,null,4,null,5,null,6]
 * Output: 5
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in the tree is in the range [0, 10^5].
 * -1000 <= Node.val <= 1000
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
public class BFS_MinDepthSolution
{
    public int MinDepth(TreeNode root)
    {
        int minDepth = 0;
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
                    else
                    {
                        return minDepth;
                    }
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    else
                    {
                        return minDepth;
                    }

                }
                minDepth++;
            }
        }

        return minDepth;
    }
}
// @lc code=end

