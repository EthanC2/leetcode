/*
  Same as 'Power of Two' (https://github.com/EthanC2/leetcode/blob/main/C%23/0231.%20Power%20of%20Two.cs).
  This is just a math problem; however, this one's more complicated because there's no Log function that
  lets you pick the base. To circumvent this limitation, you can use the 'Change of Base' rule (https://www.purplemath.com/modules/logrules5.htm)
  that allows you to turn the equation 'log base x of y' into 'log base 10 of x' divided by 'log base 10 of y'.
  The two are exactly equivalent.

  TC: O(1)
  SC: O(1)
*/
public class Solution 
{
    public bool IsPowerOfThree(int n) 
    {
        double result = Math.Log10(n)
                        /
                        Math.Log10(3);
        
        return result == (int) result;
    }
}
