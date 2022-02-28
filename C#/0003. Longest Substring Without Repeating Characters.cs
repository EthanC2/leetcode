/*
    Custom Solution
*/
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


/*
    Optimized approach
*/
/*
  Longest Substring Without Repeating Characters
  ==============================================
*/
public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
      int maxlen = 0;
      Dictionary<char,int> window = new();
      
      for(int lptr=0, rptr=0; rptr < s.Length; rptr++)
      {
        char c = s[rptr];
        if (window.ContainsKey(c))
          lptr = Math.Max(lptr, window[c]);
      
        maxlen = Math.Max(maxlen, rptr-lptr+1);
        window[c] = rptr+1;
      }
        
      return maxlen;
    }
}
