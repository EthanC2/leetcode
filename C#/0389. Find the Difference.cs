public class Solution 
{
    public char FindTheDifference(string s, string t) 
    {
      Dictionary<char,int> smap = new(), tmap = new();
      
      foreach(char c in s)
      {
        if (smap.ContainsKey(c))
          smap[c]++;
        else
          smap.Add(c,1);
      }
      
      foreach(char c in t)
      {
        if (tmap.ContainsKey(c))
          tmap[c]++;
        else
          tmap.Add(c,1);
        
        if (!smap.ContainsKey(c) || smap[c] < tmap[c])
          return c;
      }
      
      return '0';
    }
}
