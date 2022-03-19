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
  
*/
