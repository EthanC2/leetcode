
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


/*
  Optimal approach: one pass
  TC: O(n)
  SC: O(1)
*/
public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
      int idx = 0;
      
      //Find all the non-zero elements and put them at the front of the list
      for(int i=0; i < nums.Length; i++)
      {
        if (nums[i] != 0)
        {
          nums[idx] = nums[i];
          idx++;
        }
      }
      
      //Fill the remaining elements with zeros
      while (idx < nums.Length)
      {
        nums[idx] = 0;
        idx++;
      }
    }
}
