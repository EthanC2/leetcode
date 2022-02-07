/*
  Search insert on a sorted list in O(log n) time.
  
  TC: O(log n)
  SC: O(1)

  WARNING: DO NOT CALCULATE THE MIDPOINT USING 'mid=(left+right)/2'. IT CAUSES INTEGER OVERFLOW:
  https://thebittheories.com/the-curious-case-of-binary-search-the-famous-bug-that-remained-undetected-for-20-years-973e89fc212?gif=true
  https://medium.com/swlh/overflow-bug-in-binary-search-c4d4a824807a
*/

public class Solution 
{
    public int SearchInsert(int[] nums, int target) 
    {
      int low = 0, high = nums.Length-1, mid;
      
      while (low <= high)
      {
        
        mid = low+(high-low)/2;
        
        if (nums[mid] == target)
          return mid;
        
        if (nums[mid] < target)
          low = mid+1;
        else
          high = mid-1;
      }
      
      return low;
    }
}
