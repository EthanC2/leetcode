/*
  Naive solution: sorting
  
  TC: O(n log n)
  SC: O(1)
*/
class Solution {
    
public:
    int findKthLargest(vector<int>& nums, int k) {
        std::sort(nums.begin(), nums.end(), std::greater<int>());   //sort largest => smallest
        return nums[k-1];                                           //return kth largest
    }
};

/*
  Optimized approach: make a heap from the vector
    
   TC: O(log n)
   SC: O(n)
*/
class Solution 
{
    
public:
    int findKthLargest(vector<int>& nums, int k) 
    {
        std::vector<int> heap = nums;
        std::make_heap(heap.begin(), heap.end());
        
        for(int i=0; i < k-1; i++)
        {
            std::pop_heap(heap.begin(), heap.end());
            heap.pop_back();
        }
        
        return heap.front();
    }
};
