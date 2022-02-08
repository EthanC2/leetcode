/*
  Approach: apparently what they're talking about is called a "digital root".
            Poor explanation aside, it's only 3 lines of code.
  
  TC: O(1)
  SC: O(1)
*/
public class Solution 
{
    public int AddDigits(int num) 
    {
      if (num == 0) return 0;
      if (num % 9 == 0) return 9;
      return num % 9;
    }
}
