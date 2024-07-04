/*
 * @lc app=leetcode id=103 lang=csharp
 *
 * [103] Binary Tree Zigzag Level Order Traversal
 *
 * https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/description/
 *
 * algorithms
 * Medium (58.67%)
 * Likes:    10701
 * Dislikes: 294
 * Total Accepted:    1.2M
 * Total Submissions: 2M
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given the root of a binary tree, return the zigzag level order traversal of
 * its nodes' values. (i.e., from left to right, then right to left for the
 * next level and alternate between).
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [3,9,20,null,null,15,7]
 * Output: [[3],[20,9],[15,7]]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: root = [1]
 * Output: [[1]]
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
 * The number of nodes in the tree is in the range [0, 2000].
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
public class BFSZigzagSolution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {

        var result = new List<IList<int>>();
        var direction = true;
        if(root != null)
        {
            var queue= new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var sizeOfqueue = queue.Count;
                var Level = new LinkedList<int>();
                for (int i = 0; i < sizeOfqueue; i++)
                {
                    var node = queue.Dequeue();
                    if (direction)
                    {
                        Level.AddFirst(node.val);
                    }
                    else
                    {
                        Level.AddLast(node.val);
                    }

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                Level.Clear();
                direction = !direction;
                result.Add(new List<int>(Level));
            }

        }
        return result;   
    }
}
// @lc code=end

