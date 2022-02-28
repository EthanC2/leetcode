
/*
  Naive Approach: two-pass
  TC: O(2N)
  SC: O(1)
*/
public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
      int zeroCount = 0, idx = 0;
      
      //Count the number of zeros
      foreach(int num in nums)
      {
        if (num == 0)
          zeroCount++;
      }
      
      //Copy non-zero elements from 'nums' into 'result'
      foreach(int num in nums)
      {
        if (num != 0)
        {
          nums[idx] = num;
          idx++;
        }
      }
      
      //Fill in the remaining space with 0s
      while (idx < nums.Length)
      {
        nums[idx] = 0;
        idx++;
      }
    }
}
