/*
 * @lc app=leetcode id=92 lang=csharp
 *
 * [92] Reverse Linked List II
 *
 * https://leetcode.com/problems/reverse-linked-list-ii/description/
 *
 * algorithms
 * Medium (47.52%)
 * Likes:    11345
 * Dislikes: 583
 * Total Accepted:    835K
 * Total Submissions: 1.8M
 * Testcase Example:  '[1,2,3,4,5]\n2\n4'
 *
 * Given the head of a singly linked list and two integers left and right where
 * left <= right, reverse the nodes of the list from position left to position
 * right, and return the reversed list.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: head = [1,2,3,4,5], left = 2, right = 4
 * Output: [1,4,3,2,5]
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: head = [5], left = 1, right = 1
 * Output: [5]
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in the list is n.
 * 1 <= n <= 500
 * -500 <= Node.val <= 500
 * 1 <= left <= right <= n
 * 
 * 
 * 
 * Follow up: Could you do it in one pass?
 */

// @lc code=start

using LeetcodeProblems.Helpers;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {

        //#region - MY SOLUTION WITH MULTIPLE ERRORS
        //if (left == right)
        //    return head;

        //ListNode cur = head;
        //ListNode? previous = null;
        //ListNode? next = null;

        //int i = 1;

        //while (cur.next != null && i <= left-1) {
        //    previous = cur;
        //    cur = cur.next;
        //    i++;
        //}
        //var lastCorrectnode = previous;
        //var firstIncorrectNode = cur;

        
        //while (i < right-1) {
        //    next = cur.next;
        //    var achualNext = next?.next;
        //    next.next = cur;
        //    cur = next;
        //    next = achualNext;
        //    i++;

        //}
        //if(lastCorrectnode != null) { lastCorrectnode.next = cur; }
        //else { head= cur; }
       
        //firstIncorrectNode.next = next;

        //return head;

        //#endregion
    }
}
// @lc code=end

