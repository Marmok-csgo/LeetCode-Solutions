public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode()
    {
        val = 0;
        next = null;
    }

    public ListNode(int val)
    {
        this.val = val;
        next = null;
    }

    public ListNode(int val, ListNode next)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        current.next = list1 ?? list2;

        return dummy.next;
    }
}