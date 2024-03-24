/*
 * @lc app=leetcode id=71 lang=csharp
 *
 * [71] Simplify Path
 *
 * https://leetcode.com/problems/simplify-path/description/
 *
 * algorithms
 * Medium (41.98%)
 * Likes:    5393
 * Dislikes: 1239
 * Total Accepted:    720.4K
 * Total Submissions: 1.7M
 * Testcase Example:  '"/home/"'
 *
 * Given a string path, which is an absolute path (starting with a slash '/')
 * to a file or directory in a Unix-style file system, convert it to the
 * simplified canonical path.
 * 
 * In a Unix-style file system, a period '.' refers to the current directory, a
 * double period '..' refers to the directory up a level, and any multiple
 * consecutive slashes (i.e. '//') are treated as a single slash '/'. For this
 * problem, any other format of periods such as '...' are treated as
 * file/directory names.
 * 
 * The canonical path should have the following format:
 * 
 * 
 * The path starts with a single slash '/'.
 * Any two directories are separated by a single slash '/'.
 * The path does not end with a trailing '/'.
 * The path only contains the directories on the path from the root directory
 * to the target file or directory (i.e., no period '.' or double period
 * '..')
 * 
 * 
 * Return the simplified canonical path.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: path = "/home/"
 * Output: "/home"
 * Explanation: Note that there is no trailing slash after the last directory
 * name.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: path = "/../"
 * Output: "/"
 * Explanation: Going one level up from the root directory is a no-op, as the
 * root level is the highest level you can go.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: path = "/home//foo/"
 * Output: "/home/foo"
 * Explanation: In the canonical path, multiple consecutive slashes are
 * replaced by a single one.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= path.length <= 3000
 * path consists of English letters, digits, period '.', slash '/' or '_'.
 * path is a valid absolute Unix path.
 * 
 * 
 */

// @lc code=start
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string SimplifyPath(string path) {

        var stack = new Stack<string>();
        var paths = path.Split('/');
        var popCount = 0;
        foreach (var str in paths)
        {
            if (str == ".." && stack.Count > 0)
            {
               popCount++;
                continue;
            }
            if (str == "." || str == " " || (str == "\\" && stack.Peek() == "\\")) { continue; }
            stack.Push(str);


        }
        while (stack.Count > 0 && popCount > 0)
        {
            while (stack.Count> 0 && stack.Peek() == "") { stack.Pop(); }
            while (stack.Count > 0 && stack.Peek() != "" && popCount > 0) { stack.Pop(); popCount--; }
        }
        if(stack.Count == 0) { return "/"; }
        var res = "";
        var reverseStack = new Stack<string>();
        foreach (var str in stack)
        {
            if (!string.IsNullOrEmpty(str))
            {
               reverseStack.Push("/"+str);
            }
        }

        foreach (var str in reverseStack)
        {
           res += str;
        }
        return res;
    }
}
// @lc code=end

