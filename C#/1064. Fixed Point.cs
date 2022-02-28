/*
  Native solution: brute force by iterating over the entire array
  TC: O(n)
  SC: O(1)
*/
public class Solution 
{
    public int FixedPoint(int[] arr) 
    {
     for(int i=0; i < arr.Length; ++i)
      {
        if (i == arr[i])
          return i;
      }
      
      return -1;
    }
}

