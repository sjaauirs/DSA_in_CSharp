    
/*
 * @lc app=leetcode id=102 lang=csharp
 *
 * [102] Binary Tree Level Order Traversal
 *
 * https://leetcode.com/problems/binary-tree-level-order-traversal/description/
 *
 * algorithms
 * Medium (66.82%)
 * Likes:    15160
 * Dislikes: 310
 * Total Accepted:    2.3M
 * Total Submissions: 3.3M
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given the root of a binary tree, return the level order traversal of its
 * nodes' values. (i.e., from left to right, level by level).
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [3,9,20,null,null,15,7]
 * Output: [[3],[9,20],[15,7]]
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


public class BFS_Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
        var Allleveldata = new List<IList<int>>();

        if(root == null)
        {
            return null; 
        }
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            var sizeOfqueue = queue.Count;
            var LevelList = new List<int>(sizeOfqueue);

            for (int i = 0; i < sizeOfqueue; i++)
            {
                var node = queue.Dequeue();
                LevelList.Add(node.val);

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            Allleveldata.Add(LevelList);

        }
        return Allleveldata;

    }
}
// @lc code=end

