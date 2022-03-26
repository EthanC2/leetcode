/*
  Same as 'Power of Two' and 'Power of Three'.
  Just use a logarithm and the 'Change of Base' rule.
  
  SC: O(1)
  TC: O(1)
*/

public class Solution 
{
    public bool IsPowerOfFour(int n) 
    {
        double result = Math.Log10(n)
                        /
                        Math.Log10(4);
        
        return result == (int) result;
    }
}
