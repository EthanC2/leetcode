/*
    If you come across an element 'val', just overwrite it.
    ezpz i only had to look up the solution comments.

    TC: O(n)
    SC: O(1)
*/
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        
        foreach(int num in nums)
        {
            if (num != val)
            {
                nums[i] = num;
                i++;
            }
        }
        return i;
    }
}
