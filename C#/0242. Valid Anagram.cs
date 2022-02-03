public class Solution 
{
    public bool IsAnagram(string s, string t) 
    { 
      Dictionary<char,int> smap = new();
      Dictionary<char,int> tmap = new();
      
      //PRE-REQ: an anagram must use all letters
      if (s.Length != t.Length)
        return false;
      
      //Create hashmap for string s
      foreach(char c in s)
      {
        if (smap.ContainsKey(c))
          smap[c]++;
        else
          smap.Add(c,1);
      }
      
      //Create hashmap for string t
      foreach(char c in t)
      {
        if (tmap.ContainsKey(c))
          tmap[c]++;
        else
          tmap.Add(c,1);
      }
      
      //Compare the two hashmaps
      foreach(char key in smap.Keys)
      {
        //If the key is non-existant, or 
        if (!tmap.ContainsKey(key) || tmap[key] < smap[key])
          return false;
      }
      return true;
    }
}
