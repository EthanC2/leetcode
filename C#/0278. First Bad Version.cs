/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */


/*
    O(log n) Solution
    =================
    Since n is the most recent version, we can interpret
    n as a series of version from 1..n.
*/
public class Solution : VersionControl 
{
    public int FirstBadVersion(int n) 
    {
      int low = 1, high = n, mid;
      
      while (low < high)
      {
        mid = low+(high-low)/2;
        
        if (IsBadVersion(mid))
          high = mid;
        else
          low = mid+1;
      }
      
      return low;
    }
}
