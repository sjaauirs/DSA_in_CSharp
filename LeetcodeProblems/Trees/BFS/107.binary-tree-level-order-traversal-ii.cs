/*
 * @lc app=leetcode id=107 lang=csharp
 * TRAVERSAL IN REVERSE ORDER
 * [107] Binary Tree Level Order Traversal II
 *
 * https://leetcode.com/problems/binary-tree-level-order-traversal-ii/description/
 *
 * algorithms
 * Medium (63.09%)
 * Likes:    4830
 * Dislikes: 323
 * Total Accepted:    649.6K
 * Total Submissions: 1M
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given the root of a binary tree, return the bottom-up level order traversal
 * of its nodes' values. (i.e., from left to right, level by level from leaf to
 * root).
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [3,9,20,null,null,15,7]
 * Output: [[15,7],[9,20],[3]]
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
public class LevelOrderBottomSolution
{
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        var AllLevels = new LinkedList<IList<int>>();

        if (root == null)
        {
            return new List<IList<int>>();
        }

        var bfsQueue = new Queue<TreeNode>();
        bfsQueue.Enqueue(root);
        while (bfsQueue.Count > 0)
        {
            var sizeOfqueue = bfsQueue.Count;
            var Leveldata = new List<int>(sizeOfqueue);

            for (int i = 0; i < sizeOfqueue; i++)
            {
                var node = bfsQueue.Dequeue();
                Leveldata.Add(node.val);
                if(node.left != null)
                {
                    bfsQueue.Enqueue(node.left);
                }
                if(node.right != null)
                {
                    bfsQueue.Enqueue(node.right);   
                }
            
            }
            AllLevels.AddFirst(Leveldata);
        }

        var result = new List<IList<int>>();
        foreach (var item in AllLevels)
        {
            result.Add(item);
        };
        return result;
    }
}
// @lc code=end

