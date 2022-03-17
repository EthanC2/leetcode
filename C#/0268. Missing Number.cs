/*
  Sorting is an intuitive solution, but is ineffecient because it takes O(n log n) time.

  Creating a hashset from the array allows for constant (O(1)) lookup time.
  This yields a faster, but less space efficient, algorithm
  
  TC: O(n)
  SC: O(n)
*/
public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        //Create a hashset from the array
        HashSet<int> allNums = new(nums);   //you may need to use a for loop in other languages
         
        //For each num in 0..n (inclusive), check if the number exists
        for(int i=0; i < nums.Length+1; ++i)
        {
            if (!allNums.Contains(i))
                return i;
        }
        
        //No repeated number (really should be an optional/nullable return value)
        return -1;
    }
}
