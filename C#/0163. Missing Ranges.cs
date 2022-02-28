/*
  Solution: iterate over all the elements (O(n) time) and compare distances via subtraction.
  * If the distance between two elements is greater than 1, then there's a missing number. NECESSARILY. 
  * If (lower_missing+1) equals (upper_missing-1) (e.g. 1+1 and 3-1 both == 2),
    then add that number instead of     a range.
*/
public class Solution 
{
    public IList<string> FindMissingRanges(int[] nums, int lower, int upper) 
    {
      List<string> missing = new();
      int prev = lower-1;
      
      for(int i=0; i <= nums.Length; i++)
      {
        int curr = (i < nums.Length) ? nums[i] : upper+1;
        
        if (prev+1 <= curr-1)
          missing.Add(Range2Str(prev+1, curr-1));
        
        prev = curr;
      }
      
      return missing;
    }
  
    private string Range2Str(int lower, int upper)
    {
      if (lower == upper)
        return lower.ToString();
      
      return $"{lower}->{upper}";
    }
}
