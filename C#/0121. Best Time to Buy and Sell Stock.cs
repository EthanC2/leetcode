/*
    Naive approach
    TC: O(n^2)
    SC: O(1)
*/
public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
      int maxProfit = 0;
      
      for(int i=0; i < prices.Length; i++)
      {
        for(int j=i+1; j < prices.Length; j++)
        {
          if (maxProfit < prices[j] - prices[i])
            maxProfit = prices[j] - prices[i];  
        }
      }
      
      return maxProfit;
    }
}




/*
    Optimized solution:
    TC: O(n)
    SC: O(1)
*/
public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int minPrice = Int32.MaxValue;
        int maxProfit = 0;
        
        for(int i=0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];
            else if (prices[i] - minPrice > maxProfit)
                maxProfit = prices[i] - minPrice;
        }
        
        return maxProfit;
    }
}
