/*
  TC: O(n)
  SC: O(n)
*/

public class Solution 
{
    public string ReverseWords(string s) 
    {
      string[] words = s.Split(' ');
      
      string[] reversed = words.Select(word => Reverse(word)).ToArray();
      
      return String.Join(' ', reversed);
    }
  
    private string Reverse(string word)
    {
      char[] chars = word.ToCharArray();
      
      for(int i=0, j=word.Length-1; i < j; i++, j--)
      {
        (chars[j], chars[i]) = (chars[i], chars[j]);
      }
      
      return new string(chars);
    }
}
