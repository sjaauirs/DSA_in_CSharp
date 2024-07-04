/*
 * @lc app=leetcode id=113 lang=csharp
 *
 * [113] Path Sum II
 *
 * https://leetcode.com/problems/path-sum-ii/description/
 *
 * algorithms
 * Medium (58.24%)
 * Likes:    7892
 * Dislikes: 154
 * Total Accepted:    862.5K
 * Total Submissions: 1.5M
 * Testcase Example:  '[5,4,8,11,null,13,4,7,2,null,null,5,1]\n22'
 *
 * Given the root of a binary tree and an integer targetSum, return all
 * root-to-leaf paths where the sum of the node values in the path equals
 * targetSum. Each path should be returned as a list of the node values, not
 * node references.
 * 
 * A root-to-leaf path is a path starting from the root and ending at any leaf
 * node. A leaf is a node with no children.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
 * Output: [[5,4,11,2],[5,8,4,5]]
 * Explanation: There are two paths whose sum equals targetSum:
 * 5 + 4 + 11 + 2 = 22
 * 5 + 8 + 4 + 5 = 22
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: root = [1,2,3], targetSum = 5
 * Output: []
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: root = [1,2], targetSum = 0
 * Output: []
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in the tree is in the range [0, 5000].
 * -1000 <= Node.val <= 1000
 * -1000 <= targetSum <= 1000
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
public class DFSpathSum2Solution {
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        var allPath = new List<IList<int>>();
        var currentPath = new List<int>();
        process(root,allPath , currentPath, targetSum);
        return allPath;
        
    }

    public void process(TreeNode root, List<IList<int>> allPath , List<int> currentPath , int targetsum)
    {

        if( root == null) return; // Break condition

        currentPath.Add(root.val);

        if (root.left == null && root.right == null && root.val == targetsum)  // if leaf and sum match-- add to Answer
        {
            allPath.Add(new List<int>(currentPath));  // copy path into new list reference and to result
        }
        
        process(root.left, allPath , currentPath , root.val-targetsum);

        process(root.right, allPath, currentPath, root.val - targetsum);

        currentPath.RemoveAt(currentPath.Count - 1); // remove last element as we are moving up in path
    }
}
// @lc code=end



/* USING STACK
 *
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        var result = new List<IList<int>>();
        if (root == null) return result;

        var stack = new Stack<(TreeNode node, List<int> path, int sum)>();  #A
        stack.Push((root, new List<int> { root.val }, root.val));   #B

        while (stack.Count > 0) {                 #C
            var (current, path, sum) = stack.Pop();              #D

            // Check if it's a leaf node and the path sum equals targetSum
            if (current.left == null && current.right == null && sum == targetSum) {
                result.Add(new List<int>(path));
            }

            // If there is a right child, push it onto the stack                #E
            if (current.right != null) {
                var newPath = new List<int>(path) { current.right.val };   // new List reference
                stack.Push((current.right, newPath, sum + current.right.val));
            }

            // If there is a left child, push it onto the stack         #F
            if (current.left != null) {
                var newPath = new List<int>(path) { current.left.val };      // new List reference
                stack.Push((current.left, newPath, sum + current.left.val));
            }
        }

        return result;
    }
}

#A : Create a Stack
#B : Add a Root element to stack 
#C : while we have elements in stack 
#D : get element from stack , checking if elemet from stack is satisfying the result condition
#E 

*/