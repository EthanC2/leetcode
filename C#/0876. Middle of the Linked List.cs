/*
  Finding the middle of a linked list using two pointers
  TC: O(n)
  SC: O(1)
  
  The middle of a list can only be deduced by knowing both the beginning and endpoints.
  The midpoint should be exactly halfway between them. Admittedly, this solution could
  be improved by removing the branching logic (the `if` statement) inside the `while`
  loop.
  
  1. midpoint: 1 
     itr: 1
     passed: 1
     
  2. midpoint: 2
     itr: 2
     passed: 2
  
  3. midpoint: 2
     itr: 3
     passed: 3
*/
public class Solution 
{
    public ListNode MiddleNode(ListNode head) 
    {
      ListNode midpoint = head, itr = head;
      int passed = 1;
      
      while (itr is not null)
      {
        itr = itr.next;
        
        if (passed % 2 == 0)
          midpoint = midpoint.next;
        
        passed++;
      }
      
      return midpoint;
    }
}
