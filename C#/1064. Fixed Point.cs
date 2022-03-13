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

/*
    Optimized solution: use binary search
    Anytime you see 'sorted array' and 'search', you should *always* opt for a binary search if possible

    TC: O(log n)
    SC: O(1)

    Why 'left + (right-left)/2' instead of '(left+right)/2'?:
    https://thebittheories.com/the-curious-case-of-binary-search-the-famous-bug-that-remained-undetected-for-20-years-973e89fc212
*/

public class Solution {
    public int FixedPoint(int[] arr) {
        int left = 0, right = arr.Length-1;
        int smallestIdx = -1;
        
        while (left <= right) 
        {
            int mid = left + (right-left)/2;
            
            if (arr[mid] == mid) 
            {
                smallestIdx = mid;
                right = mid-1;
            }
            else if (arr[mid] < mid)
            {
                left = mid+1;
            }
            else
            {
                right = mid-1;
            }
        }
        
        return smallestIdx;
    }
}
