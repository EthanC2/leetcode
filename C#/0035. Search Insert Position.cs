/*


  WARNING: 
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
