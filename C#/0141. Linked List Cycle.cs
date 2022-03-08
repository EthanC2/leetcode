/*
  Naive Approach: 
  ==============
  use a hashset on this ListNode objects themselves instead 
  of their values. If you encounter the same object in memory,
  then you already visited it

  TC: O(n)
  SC: O(n)
*/

public class Solution 
{
    public bool HasCycle(ListNode head) 
    {
        HashSet<ListNode> seen = new();
        
        while (head is not null)
        {
            if (seen.Contains(head))
                return true;
            
            seen.Add(head);
            head = head.next;
        }
        
        return false;
    }
}


/*
  Optimized Approach: Floyd's Cycle Detection Algorithm (Tortoise and Harse):
  ===========================================================================
  Use a fast and slow pointer. If there is a cycle, the two pointers will necessarily
  overlap at some point. If either pointer reaches null, then there is no cycle.
*/
public class Solution 
{
    public bool HasCycle(ListNode head) 
    {
        if (head is null) return false;
        ListNode slow = head, fast = head.next;
        
        while (fast != slow)
        {
            if (fast is null || fast.next is null)
                return false;
                
            slow = slow.next;
            fast = fast.next.next;
        }
        
        return true;
    }
}
