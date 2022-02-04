/*
  Do math, dummy. If a + b + c + d == 0, then a + b = -(c + d).
  If you do this problem normally (with 4 for-loops), then it has 
  an O(n^4) time complexity and an O(1) space complexity. However, 
  if you rearrange the formula and use a hashmap, then you can do it
  in TC: O(n^2) and SC: O(n^2), making the problem actually feasable.
*/
public class Solution 
{
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) 
    {
      int count = 0;
      Dictionary<int,int> hashmap = new();
      
      //Create reference hashmap from nums1 and nums2
      foreach(int a in nums1)
      {
        foreach(int b in nums2)
        {
          if (hashmap.ContainsKey(a+b))
            hashmap[a+b]++;
          else
            hashmap.Add(a+b,1);
        }
      }
      
      foreach(int c in nums3)
      {
        foreach(int d in nums4)
        {
          if (hashmap.ContainsKey(-(c+d)))
            count += hashmap[-(c+d)];
        }
      }
      
      return count;
    }
}
