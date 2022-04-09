/*
  Approach: hashmap + sorting
  TC: O(n log n)
  SC: O(n)
*/
class Solution 
{
public:
    string frequencySort(string s)
    {
        string ans;  //strings are mutable in C++! no need for stringbuilder.
        std::vector<pair<char,int>> sorted; 
        unordered_map<char,int> freq;
        
        //1. Build a frequency map
        for(const char c : s)
            freq[c]++;
        
        //2. Get a list of the key-value pairs
        for(auto pair : freq)
            sorted.push_back(pair);
    
        //3. Sort the key-value pairs by frequency
        std::sort(sorted.begin(), sorted.end(), [](auto p1, auto p2) {return p1.second > p2.second;});
            
        //4. Append the given character in the string to the string <frequency> times
        for(auto& [ch, frequency] : sorted)
        {
            for(int i=0; i < frequency; i++)
                ans += ch;
        }
        
        return ans;
    }
};
