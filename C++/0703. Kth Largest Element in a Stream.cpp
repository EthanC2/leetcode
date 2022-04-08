/*
  WARNING!
  ========
  This problem is very poorly explained on LeetCode. 
  It does not tell you to only maintain K elements at a 
  time.
*/

/*
  Naive approach: sorting. every operation takes O(n log n) time.
  However, this could be optimized by finding the index to insert
  at by using a binary search and vector.insert(index, value).
  
  TC: O(n log n)
  SC: O(1)
*/
class KthLargest 
{
private:
    int kth;
    std::vector<int> values;
    
public:
    KthLargest(int k, vector<int>& nums) 
    {
        kth = k;
        values = nums;
        std::sort(values.begin(), values.end(), std::greater<int>());
        //std::make_heap(values.begin(), values.end());
    }
    
    int add(int val) 
    {
        values.push_back(val);
        std::sort(values.begin(), values.end(), std::greater<int>());
        return values[kth-1];
    }
};



/*
  Optimized approach: use a max heap in the form of a priorty queue
  
  TC: O(log n)
  SC: O(1)
*/
class KthLargest {
private:
    int n;
    std::priority_queue<int, std::vector<int>, std::greater<int>> pq;
    
public:
    KthLargest(int k, vector<int>& nums) {
        n = k;
        
        for(const int num : nums)  //init pq
            pq.push(num);
        
        while (pq.size() > n)
            pq.pop();
    }
    
    int add(int val) {
        pq.push(val);
        
        if (pq.size() > n)
            pq.pop();
        
        return pq.top();
    }
};



/*
  Raw solution using a heap instead of the priority queue class
  
  TC: O(log n)
  SC: O(1)
*/
class KthLargest {
private:
    int n;
    std::vector<int> values;
    
public:
    KthLargest(int k, vector<int>& nums) {
        n = k;
        
        values = nums;
        std::make_heap(values.begin(), values.end(), std::greater<int>());
        
        while (values.size() > n)
        {
            std::pop_heap(values.begin(), values.end(), std::greater<int>());
            values.pop_back();
        }
    }
    
    int add(int val) { 
        values.push_back(val);
        std::push_heap(values.begin(), values.end(), std::greater<int>());
        
        if (values.size() > n)
        {
            std::pop_heap(values.begin(), values.end(), std::greater<int>());
            values.pop_back();
        }
        
        return values[0];
    }
};
