/*
  Naive Approach: 
  TC: O(n^2)
  SC: O(1)
*/
public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        for(int i=0; i < numbers.Length; i++)
        {
          for(int j=i+1; j < numbers.Length; j++)
          {
            int sum = numbers[i] + numbers[j];
            
            if (sum == target)
              return new int[2] {i+1, j+1};
            
            if (sum > target)
              break;
          }
        }
        
        return new int[2] {-1,-1};
    }
}
