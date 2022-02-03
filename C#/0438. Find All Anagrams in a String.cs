public class Solution 
{
    public IList<int> FindAnagrams(string s, string p) 
    {
        //Variables: two hashmaps for comparison of strings and a list for recording indices
        Dictionary<char,int> window = new();
        Dictionary<char,int> pmap = new();
        List<int> indices = new();
        
        //Create hashmap for string p
        foreach(char c in p)
        {
          if (pmap.ContainsKey(c))
            pmap[c]++;
          else
            pmap.Add(c,1);
        }
        
        //Compare reference hashmap p with string s
        for(int i=0; i < s.Length; ++i)
        {
          //Add letter to window
          char c = s[i];           //Create alias for clarity
          if (window.ContainsKey(c))
            window[c]++;
          else
            window.Add(c,1);
          
          //Remove one letter from the left side
          if (i >= p.Length)
          {
            c = s[i - p.Length];
            if (window[c] == 1)
              window.Remove(c);
            else
              window[c]--;
          }
          
          if (AreEqual(window, pmap))
            indices.Add(i - p.Length+1);
        }
      
        return indices;
    }
  
    //Compare hashmap equality: every character in 'window' must be <= that in 'pmap'
    public bool AreEqual(Dictionary<char,int> window, Dictionary<char,int> pmap)
    {
      foreach(char key in pmap.Keys)
      {
        if (!window.ContainsKey(key) || window[key] < pmap[key])
          return false;
      }
      return true;
    }
}
