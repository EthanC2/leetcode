public class Solution {
    public string ToGoatLatin(string sentence) {
        string[] words = sentence.Split(' ');
        StringBuilder AsGoatLatin = new();
        int count = 0;
        
        foreach(var word in words)
        {
            count += 1;
            
            if (IsVowel(word[0]))
                AsGoatLatin.Append($"{word}ma");
            else
                AsGoatLatin.Append($"{word[1..]}{word[0]}ma");
            
            AsGoatLatin.Append('a', count);
            if (count < words.Length)
                AsGoatLatin.Append(' ');
        }
        
        return AsGoatLatin.ToString();
    }
    
    public bool IsVowel(char c)
    {
        var Vowels = new HashSet<char>() {'a', 'e', 'i', 'o', 'u'};
            
        return Vowels.Contains(Char.ToLower(c));
    }
}
