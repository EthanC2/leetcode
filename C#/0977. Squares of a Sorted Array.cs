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
