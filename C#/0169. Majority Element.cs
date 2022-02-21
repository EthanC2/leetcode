/*
  Native Approach: Hashmap
  TC: O(n)
  SC: O(n)
*/
public class Solution 
{
    public int MajorityElement(int[] nums) 
    {
      Dictionary<int,int> map = new();
      
      //Count the amount of each number in the array
      foreach(int num in nums)
      {
        if (map.ContainsKey(num)) map[num]++;
        else map.Add(num,1);
      
        //If an element appears more than N/2+1 times, it's the majority
        if (map[num] >= nums.Length/2+1)
          return num;
      }
      
      return nums[0];  //make the compiler happy
    }
}
