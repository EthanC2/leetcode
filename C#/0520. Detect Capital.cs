//Optimal Solution: https://leetcode.com/problems/detect-capital/discuss/1715652/C-Easy-understanding-2-line-solution

/*
    The brilliance of the optimal solution above is that it only requires you to traverse the string once, 
    making its time complexity O(1N). Furthermore, it doesn't have to allocate a new string like mine did.
*/

public class Solution 
{
    public bool DetectCapitalUse(string word) 
    {
        return word.All(Char.IsUpper)                                       //All uppercase
            || word.All(Char.IsLower)                                       //All lowercase
            || (Char.IsUpper(word[0]) && word[1..].All(Char.IsLower));      //First uppercase, rest lowercase 
    }
}
