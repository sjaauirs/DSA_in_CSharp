/*
 * @lc app=leetcode id=297 lang=csharp
 *
 * [297] Serialize and Deserialize Binary Tree
 *
 * https://leetcode.com/problems/serialize-and-deserialize-binary-tree/description/
 *
 * algorithms
 * Hard (56.53%)
 * Likes:    10113
 * Dislikes: 394
 * Total Accepted:    887.2K
 * Total Submissions: 1.6M
 * Testcase Example:  '[1,2,3,null,null,4,5]'
 *
 * Serialization is the process of converting a data structure or object into a
 * sequence of bits so that it can be stored in a file or memory buffer, or
 * transmitted across a network connection link to be reconstructed later in
 * the same or another computer environment.
 * 
 * Design an algorithm to serialize and deserialize a binary tree. There is no
 * restriction on how your serialization/deserialization algorithm should work.
 * You just need to ensure that a binary tree can be serialized to a string and
 * this string can be deserialized to the original tree structure.
 * 
 * Clarification: The input/output format is the same as how LeetCode
 * serializes a binary tree. You do not necessarily need to follow this format,
 * so please be creative and come up with different approaches yourself.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: root = [1,2,3,null,null,4,5]
 * Output: [1,2,3,null,null,4,5]
 * 
 * 
 * Example 2:
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
 * The number of nodes in the tree is in the range [0, 10^4].
 * -1000 <= Node.val <= 1000
 * 
 * 
 */

// @lc code=start


using System;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

/**
   * Definition for a binary tree node.
   * public class TreeNode {
   *     public int val;
   *     public TreeNode left;
   *     public TreeNode right;
   *     public TreeNode(int x) { val = x; }
   * }
   */
public class Codec {

    private int index;
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        List<string> list = new List<string>();
        StringBuilder sb = new StringBuilder();
        preOrder(root, sb);
       
       return sb.ToString();
    }

    private void preOrder(TreeNode root, StringBuilder sb)
    {
       if(root == null)
        {
            sb.Append("#,");
            return;
        }
        else
        {
            sb.Append(root.val.ToString()).Append(",");
        }
        preOrder(root.left, sb);
        preOrder(root.right, sb);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if (string.IsNullOrEmpty(data))
        {
            return null;
        }
        index = 0;
        var nodes = data.Split(',');
        return BuildTreeHelper(nodes);
    }

    private TreeNode BuildTreeHelper(string[] nodes)
    {
        if (index >= nodes.Length || nodes[index] == "#")
        {
            index++;
            return null;
        }

        TreeNode root = new TreeNode(int.Parse(nodes[index++]));
        root.left = BuildTreeHelper(nodes);
        root.right = BuildTreeHelper(nodes);

        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
// @lc code=end

