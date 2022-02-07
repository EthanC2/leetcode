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


/*
    Optimized approach: two pointers
    
    TC: O(n)
    SC: O(1)
*/
public class Solution 
{
    public int[] SortedSquares(int[] nums) 
    {
      int[] squares = new int[nums.Length];
      int left = 0, right = nums.Length-1;
      
      for(int i=nums.Length-1; i >= 0; --i)
      {
        if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
        {
          squares[i] = nums[right]*nums[right];
          --right;
        }
        else
        {
          squares[i] = nums[left]*nums[left];
          ++left;
        }
      }
      
      return squares;
    }
}
