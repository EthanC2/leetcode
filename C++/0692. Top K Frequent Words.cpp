/*
  Approach: map + priority queue
*/
struct compare_pair
{
    bool operator()(pair<string,int> p1, pair<string,int> p2) const noexcept
    {
        if (p1.second != p2.second)
            return p1.second < p2.second;
        
        return p1.first > p2.first;
    }
};

class Solution 
{
public:
    vector<string> topKFrequent(vector<string>& words, int k) 
    {
        vector<string> kcommon;
        unordered_map<string,int> map;
        priority_queue<pair<string,int>, vector<pair<string,int>>, compare_pair> pq;
        
        //1. Build frequency map
        for(string word : words)
            map[word]++;
        
        //2. Construct a priority queue from the frequency
        for(auto pair : map)
            pq.push(pair);
        
        //3. Get the top k strs
        for(int i=0; i < k; i++)
        {
            kcommon.push_back(pq.top().first);
            pq.pop();
        }
        
        return kcommon;
    }
};
