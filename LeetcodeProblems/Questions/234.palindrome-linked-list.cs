/*
 * @lc app=leetcode id=234 lang=csharp
 *
 * [234] Palindrome Linked List
 *
 * https://leetcode.com/problems/palindrome-linked-list/description/
 *
 * algorithms
 * Easy (51.00%)
 * Likes:    15288
 * Dislikes: 819
 * Total Accepted:    1.6M
 * Total Submissions: 3.1M
 * Testcase Example:  '[1,2,2,1]'
 *
 * Given the head of a singly linked list, return true if it is a palindrome or
 * false otherwise.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: head = [1,2,2,1]
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: head = [1,2]
 * Output: false
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of nodes in the list is in the range [1, 10^5].
 * 0 <= Node.val <= 9
 * 
 * 
 * 
 * Follow up: Could you do it in O(n) time and O(1) space?
 */

// @lc code=start
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
    public bool IsPalindrome(ListNode head) {
     var slow = head; 
        var fast = head; 
        var entry = head;
        ListNode middle = null;
        while(fast!= null || fast.next != null){
            slow= slow.next;
            fast= fast.next.next;
        }
        middle = slow; 
        var reverseHead = ReverseList(middle);
        var IsPalindrome = true; 
        while(entry != middle){
            if(entry != reverseHead){
                IsPalindrome = false; 
                break; 
            }
            entry=entry.next; 
            reverseHead = reverseHead.next;
        }
        return IsPalindrome;
    }
    ListNode ReverseList(ListNode head) {
       ListNode previous = null; 
       var current = head; 
       while(current != null){
           var next = current.next; 
           current.next = previous; 
           previous = current; 
           current = next;
       } 
       return previous;
    }
}
// @lc code=end

