/*
    Naive approach: Sorting
    TC: O(n log n) | sorting
    SC: O(n)       | iterating char by char
*/
public class Solution 
{
    public char FindTheDifference(string s, string t) 
    {
      //assumption: s.Length+1 == t.Length
      var ssorted = s.ToCharArray();
      var tsorted = t.ToCharArray();
    
      //Sort the arrays
      Array.Sort(ssorted);
      Array.Sort(tsorted);
      
      //Compare them letter by letter
      for(int i = 0; i < s.Length; ++i)
      {
        if (ssorted[i] != tsorted[i])
          return tsorted[i];
      }
      
      //Else it's the last character
      return tsorted[t.Length-1];
    }
}


/*
    Better approach: hashmap
    TC: O(n) | iterating over the whole string
    SC: O(n) | for storing each char in the string 
*/
public class Solution 
{
    public char FindTheDifference(string s, string t) 
    {
      Dictionary<char,int> smap = new();
      
      //Create a reference hashmap for string s
      foreach(char c in s)
      {
        if (smap.ContainsKey(c))
          smap[c]++;
        else
          smap.Add(c,1);
      }
      
      //Compare string t to hashmap of s
      foreach(char c in t)
      {
        if (!smap.ContainsKey(c) || smap[c] == 0)
          return c;
      
        smap[c]--;
      }
      
      //Should never happen
      return '\0';
    }
}


/*
    Optimized Approach: ASCII math
    TC: O(n)
    SC: O(1)
    
    If there is only a one-character difference between the two strings,
    then the difference between the sum of the two strings is the integer
    value of that character. So, calculate the difference and cast it to a char.
*/
public class Solution 
{
    public char FindTheDifference(string s, string t) 
    {
      int ssum = s.Sum(c => (int) c);
      int tsum = t.Sum(c => (int) c);
        
      return (char) (tsum - ssum);
    }
}
