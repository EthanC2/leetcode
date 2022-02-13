//Source: [GeeksforGeeks](https://www.geeksforgeeks.org/power-set/)

class Solution 
{
  public:
      vector<vector<int>> subsets(vector<int>& nums) 
      {
        std::vector<std::vector<int>> sets;

        int pow_set_size = pow(2, nums.size());

        for(int counter=0; counter < pow_set_size; counter++)
        {
          std::vector<int> subset;

          for(int j=0; j < nums.size(); j++)
          {
            if ((counter & (1 << j)) > 0)
              subset.push_back(nums[j]);
          }

          sets.push_back(subset);
        }

        return sets;
      }
};
