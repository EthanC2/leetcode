/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */


/*
    O(log n) Solution
    =================
    Since n is the most recent version, we can interpret
    n as a series of versions from 1..n. If you encounter a 
    bad version 'x', you can't guarantee that x-1 is not a bad
    version without calling a 'IsBadVersion(x-1)', so the best
    way to deal with that is just to include x in the dataset,
    changing the normal 'high = mid-1' to 'high = mid'.
*/
public class Solution : VersionControl 
{
    public int FirstBadVersion(int n) 
    {
      int low = 1, high = n, mid;
      
      while (low < high)   // <== NOT 'low <= high' because no internal return statement
      {
        mid = low+(high-low)/2;
        
        if (IsBadVersion(mid))
          high = mid;
        else
          low = mid+1;
      }
      
      return low; //You can return 'low' OR 'high' here because they're equal
    }
}
