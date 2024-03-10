/*
 * @lc app=leetcode id=141 lang=csharp
 *
 * [141] Linked List Cycle
 *
 * https://leetcode.com/problems/linked-list-cycle/description/
 *
 * algorithms
 * Easy (48.81%)
 * Likes:    14219
 * Dislikes: 1165
 * Total Accepted:    2.4M
 * Total Submissions: 4.9M
 * Testcase Example:  '[3,2,0,-4]\n1'
 *
 * Given head, the head of a linked list, determine if the linked list has a
 * cycle in it.
 * 
 * There is a cycle in a linked list if there is some node in the list that can
 * be reached again by continuously following the next pointer. Internally, pos
 * is used to denote the index of the node that tail's next pointer is
 * connected to. Note that pos is not passed as a parameter.
 * 
 * Return true if there is a cycle in the linked list. Otherwise, return
 * false.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: head = [3,2,0,-4], pos = 1
 * Output: true
 * Explanation: There is a cycle in the linked list, where the tail connects to
 * the 1st node (0-indexed).
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: head = [1,2], pos = 0
 * Output: true
 * Explanation: There is a cycle in the linked list, where the tail connects to
 * the 0th node.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: head = [1], pos = -1
 * Output: false
 * Explanation: There is no cycle in the linked list.
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * The number of the nodes in the list is in the range [0, 10^4].
 * -10^5 <= Node.val <= 10^5
 * pos is -1 or a valid index in the linked-list.
 * 
 * 
 * 
 * Follow up: Can you solve it using O(1) (i.e. constant) memory?
 * 
 */

// @lc code=start

  public class ListNode {
      public int val;
     public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null;
      }
  }
  
 
public class SolutionLnkedlistCycle {
    public bool HasCycle(ListNode head) {
        if(head== null || head.next == null){
            return false;
        }
        var slow = head; 
        var fast = head; 
        while( (fast.next != null && fast.next.next != null)){
            slow= slow.next; 
            fast = fast.next.next;
            if(slow== fast){
                return true;
            }
        }
        return false;
    }
}
// @lc code=end

