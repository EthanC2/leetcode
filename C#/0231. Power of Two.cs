/*
  Do the math, numbskull. A logarithm is the opposite of an
  exponent. If the result is an exact integer (i.e. the floating-point
  result has no fractional part), then you know the result is a power of 2.

  TC: O(1)
  SC: O(1)
  
  Could make it faster by calculating 'Math.Log2(n)' once
  and storing it.
*/
public class Solution 
{
    public bool IsPowerOfTwo(int n) 
    {
        return Math.Log2(n) == (int) Math.Log2(n);
    }
}
