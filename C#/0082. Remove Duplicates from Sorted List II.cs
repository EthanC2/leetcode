/*
  Iterate over the linked list, removing sections of repeated elements
  when you come across them. This approach is only possible because
  the list is sorted.
  
  The pseudo-head is to avoid the edge case where you 
  have to delete the head of the linked list (which would
  otherwise be impossible since you need a 'previous' pointer
  to delete a linked list node safely.

  TC: O(n)
  SC: O(1)
*/
public class Solution 
{
    public ListNode DeleteDuplicates(ListNode head) 
    {
        ListNode pseudohead = new(-1, head);
        ListNode previous = pseudohead;
        
        while (head is not null)
        {
            if (head.next is not null && head.val == head.next.val)
            {
                while (head.next is not null && head.val == head.next.val)
                {
                    head = head.next;
                }
                previous.next = head.next;
            }
            else
            {
                previous = previous.next;
            }
            
            head = head.next;
        }
        
        return pseudohead.next;  //return head;
    }
}
