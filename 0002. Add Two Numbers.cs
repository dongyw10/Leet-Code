/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resList = new ListNode(0);
            ListNode curr = resList;
            bool greatThan10 = false;
            do
            {
                int res = l1.val + l2.val;
                if (greatThan10) ++res;
                if (res >= 10)
                {
                    res -= 10;
                    greatThan10 = true;
                }
                else
                {
                    greatThan10 = false;
                }
                curr.next = new ListNode(res);
                curr = curr.next;
                l1 = l1.next;
                l2 = l2.next;
            } while ((l1 != null) && (l2 != null));

            if (greatThan10)
            {
                if (l1 != null)
                {
                    PlusOne(l1);
                    curr.next = l1;
                }
                else if (l2 != null)
                {
                    PlusOne(l2);
                    curr.next = l2;
                }
                else curr.next = new ListNode(1);
            }
            else
            {
                if (l1 != null) curr.next = l1;
                else if (l2 != null) curr.next = l2;
            }
            return resList.next;
        }

        private void PlusOne(ListNode li)
        {
            ListNode curr = li;
            ListNode next = li;
            do
            {
                int res = next.val + 1;
                if (res == 10)
                {
                    next.val = 0;
                    curr = next;
                    next = next.next;
                }
                else
                {
                    next.val = res;
                    return;
                }
            } while (next != null);
            curr.next = new ListNode(1);
        }
    }
