//Problem explanation: https://medium.com/swlh/understanding-leetcode-the-two-sum-problem-6428ed5cb18d

/*
  This problem requires you to return the indices of two numbers in the vector<int> nums that will add up
  to the target value. The brute-force solution is check the sum of every element in the array for every 
  element in the array with a double for-loop, but that's an O(n²) solution, and is an average solution.
  
  To solve this problem efficiently, you should use a hashmap (std::unordered_map) for their O(1) lookup time and associativity.
  You could use just std::map, but there's no reason to maintain order and trade an O(1) lookup time for O(log n).
  Using a hashmap will allow you to query whether or not a number `target_number - current_number` exists, which will
  always add to the target number. And, since you're using a hashmap of numbers mapped to indices, you can just query
  for the index of that number as soon as you know it exists.
  Honestly, I do have beef with this problem because it's far more efficient to return a std::pair or a std::tuple
  object and then use structured bindings (https://devblogs.microsoft.com/oldnewthing/20201014-00/?p=104367) to unpack
  the object in the main function. Using a vector as the return value when the return value of the function will ALWAYS
  be only 2 std::size_t objects is a waste of memory.
  
  Also, the return type of this function (the int vector 'answer') should be `vector<std::size_t>` since they're indices.
*/

/*
  Naive approach: double for-loop
  TC: O(n^2)
  SC: O(1)
*/
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
      for(int i=0; i < nums.Length; i++)
      {
        for(int j=i+1; j < nums.Length; j++)
        {
          if (nums[i] + nums[j] == target)
            return new int[2] {i,j};
        }
      }
      
      return new int[2] {0,0};
    }
}

/*
  Optimized approach: hashmap
  TC: O(n)
  SC: O(n)
*/
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
      var hs = new Dictionary<int,int>();
      
      for(int i=0; i < nums.Length; i++)
      {
        if (hs.ContainsKey(target - nums[i]))
          return new int[] {i, hs[target - nums[i]]};
        
        if (hs.ContainsKey(nums[i]))  // <== this is unncessary in most programming languages, but C# doesn't auto-update keys for some reason
          hs[nums[i]] = i;
        else
          hs.Add(nums[i], i);
      }
      
      return new int[] {0,0};
    }
}
