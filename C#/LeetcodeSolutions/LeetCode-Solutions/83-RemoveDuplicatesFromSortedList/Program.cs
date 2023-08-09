 public class ListNode
{
     public int val;
     public ListNode next;
     public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}


public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return null;
        ListNode result = new ListNode(0);
        ListNode current = result;


        while (head != null)
        {
            if (head.next == null)
            {
                current.next = new ListNode(head.val);
                current = current.next;

                break;
            }
            if (head.val != head.next.val)
            {
                current.next = new ListNode(head.val);
                current = current.next;
            }

            head = head.next;
        }
        return result.next;
    }
}