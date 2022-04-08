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
  Optimized approach: use a max heap
  
  TC: O(log n)
  SC: O(1)
*/
