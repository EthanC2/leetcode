// Naive approach
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




// Optimized approach
