/*
  Swapping two strings using two pointers
  =======================================
  TC: O(n)
  SC: O(1)
*/
public class Solution 
{
    public void ReverseString(char[] s) 
    {
      for(int i=0, j=s.Length-1; i < j; i++, j--)
      {
        (s[j], s[i]) = (s[i], s[j]);
      }
    }
}
