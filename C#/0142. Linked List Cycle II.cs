/*
  Naive Approach: 
  ==============
  use a hashset on this ListNode objects themselves instead 
  of their values. If you encounter the same object in memory,
  then you already visited it.
  
  TC: O(n)
  SC: O(n)
*/
public class Solution 
{
    public ListNode DetectCycle(ListNode head) 
    {
        HashSet<ListNode> seen = new();
        
        while (head is not null)
        {
            if (seen.Contains(head))
                return head;
                
            seen.Add(head);
            head = head.next;
        }
        
        return null;
    }
}

/*
  Optimized Approach: Floyd's Cycle Detection Algorithm (Tortoise and Harse):
  ===========================================================================
  Use a fast and slow pointer. If there is a cycle, the two pointers will necessarily
  overlap at some point. If either pointer reaches null, then there is no cycle.
  After finding the intersection, set one pointer to the beginning of the linked list
  and another to the intersection point. From there, iterate until the two converge.
  The point where the two converge will always be the beginning of the cycle.
  
  TC: O(n)
  SC: O(1)
*/
public class Solution 
{
    public ListNode DetectCycle(ListNode head) 
    {
        if (head is null)
            return null;
        
        ListNode intersection = FindIntersection(head);
        if (intersection is null)
            return null;
    
        while (head != intersection)
        {
            head = head.next;
            intersection = intersection.next;
        }
        
        return head;  //head == intersection
    }
    
    public ListNode FindIntersection(ListNode head)
    {
        ListNode slow = head, fast = head;
        
        while (fast is not null && fast.next is not null)
        {
            slow = slow.next;
            fast = fast.next.next;
            
            if (slow == fast)
                return slow;
        }
        
        return null;
    }
}
