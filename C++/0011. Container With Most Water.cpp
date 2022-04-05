/*
    Input: 
        - int array (len=n)
        - each array index is the height of a vertical line
    Output:
*/



/*
  Naive approach: compare all possible choices of boxes.
                  exceeds time limit for medium level challenge.
  TC: O(n^2)
  SC: O(1)
*/
class Solution 
{
  public:
      int maxArea(vector<int>& height) 
      {
        //Get initial max area [possible because 2 <= n <= 10E+5]
        int max_area = area(height, 0,1);
          
        for(int left=0; left < height.size(); ++left)
        {
          for(int right=0; right < height.size(); ++right)
          {
            int size = area(height, left,right);
            if (size > max_area)
                max_area = size;
          }
        }
          
          return max_area;
      }  
    
      int area(const vector<int>& lines, int left, int right)
      {
          int base = right-left;
          int height = std::min(lines[left], lines[right]);
          return base*height;
      }
};
