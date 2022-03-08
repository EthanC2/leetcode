/*
  Approach: use a hashset on this ListNode objects themselves instead 
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
