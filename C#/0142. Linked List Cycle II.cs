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
