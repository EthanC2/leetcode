//Solution: [GeeksforGeeks](https://leetcode.com/problems/subsets/)

public class Solution 
{
    public IList<IList<int>> Subsets(int[] nums) 
    {
      List<List<int>> sets = new();
      
      uint pow_set_size = (uint) Math.Pow(2, nums.Length);
      
      for(int counter=0; counter < pow_set_size; counter++)
      {
        List<int> temp = new();
        
        for(int j=0; j < nums.Length; j++)
        {
          if ((counter & (1 << j)) > 0)
            temp.Add(nums[j]);
        }
        
        sets.Add(temp);
      }
      
      return sets;
    }
}
