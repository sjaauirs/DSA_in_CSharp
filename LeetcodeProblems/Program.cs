using LeetcodeProblems.Helpers;
using LeetcodeProblems.Questions;

namespace LeetcodeProblems
{
    internal class Program
    {

        // Customise to call any Specific problem
        static void Main(string[] args)
        {

            ListNode head = new ListNode(3);
            head.next = new ListNode(5);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);

            Solution solution = new Solution();
            var result = solution.BaseNeg2(12);
            

            Console.ReadLine();
        }
    }
}

 