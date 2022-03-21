/*
  Naive Approach: iterating through every possible subarray
  
  TC: O(n^2)
  SC: O(n)
*/
public class Solution 
{
    public int MaxSubArray(int[] nums) 
    {
        int maxSubarray = Int32.MinValue;
        
        for(int i=0; i < nums.Length; ++i)
        {
            int currentSubarray = 0;
            for(int j=i; j < nums.Length; ++j)
            {
                currentSubarray += nums[j];
                maxSubarray = Math.Max(maxSubarray, currentSubarray);
            }
        }
        
        return maxSubarray;
    }
}

/*
  Better approach: dynamic programming
  
  TC:
  SC:
*/
public class Solution 
{
    public int MaxSubArray(int[] nums) 
    {
        int currentSubarray = nums[0];
        int maxSubarray = nums[0];
        
        for(int i=1; i < nums.Length; ++i) //skip idx=0 because it's already accounted for above
        {
            int num = nums[i];
            currentSubarray = Math.Max(num, currentSubarray+num);
            maxSubarray = Math.Max(maxSubarray, currentSubarray);
        }
        
        return maxSubarray;
    }
}
