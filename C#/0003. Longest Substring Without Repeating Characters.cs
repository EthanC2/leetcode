public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        int maxLength = 0;
        int n = s.Length;
        ReadOnlySpan<char> substr;
        
        for(int i=0; i < n; i++) 
        {
            for(int j=i; j <= n; j++) 
            {
                substr = s[i..j];
                
                if (HasUniqueChars(substr))
                    maxLength = Math.Max(maxLength, substr.Length);
            }
        }
        
        return maxLength;
    }
    
    public bool HasUniqueChars(ReadOnlySpan<char> s)
    {
        var hs = new HashSet<char>();
        
        foreach(char c in s)
        {
            if (!hs.Add(c))
                return false;
        }
        
        return true;
    }
}
