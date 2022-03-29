/*
   TC: O(n)
   SC: O(n)
*/
public class Solution 
{
    public int FindDuplicate(int[] nums) 
    {
        HashSet<int> hs = new();
        
        foreach(int num in nums)
        {
            if (!hs.Add(num))
                return num;
        }
            
        return -1;
    }
}
