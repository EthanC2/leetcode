/*
    Naive approach: overwrite values with their squares and then sort.

    TC: O(n log n)
    SC: O(1)
*/
public class Solution 
{
    public int[] SortedSquares(int[] nums) 
    {
      for(int i=0; i < nums.Length; ++i)
      {
        nums[i] = (int) Math.Pow(nums[i],2);
      }
      
      Array.Sort(nums);
      return nums;
    }
}
