/*
  Native solution: brute force by iterating over the entire array
  TC: O(n)
  SC: O(1)
*/
public class Solution 
{
    public int FixedPoint(int[] arr) 
    {
      int min = -1;
      bool found = false;
      
      for(int i=0; i < arr.Length; ++i)
      {
        if (i == arr[i] && !found)
        {
          min = i;
          found = true;
        }
      }
      
      return min;
    }
}

