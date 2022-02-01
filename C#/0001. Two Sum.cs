/*
  Naive approach: double for-loop
  TC: O(n^2)
  SC: O(1)
*/
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
      for(int i=0; i < nums.Length; i++)
      {
        for(int j=i+1; j < nums.Length; j++)
        {
          if (nums[i] + nums[j] == target)
            return new int[2] {i,j};
        }
      }
      
      return new int[2] {0,0};
    }
}

/*
  Optimized approach: hashmap
  TC: O(n)
  SC: O(n)
*/
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
      var hs = new Dictionary<int,int>();
      
      for(int i=0; i < nums.Length; i++)
      {
        if (hs.ContainsKey(target - nums[i]))
          return new int[] {i, hs[target - nums[i]]};
        
        if (hs.ContainsKey(nums[i]))  // <== this is unncessary in most programming languages, but C# doesn't auto-update keys for some reason
          hs[nums[i]] = i;
        else
          hs.Add(nums[i], i);
      }
      
      return new int[] {0,0};
    }
}
