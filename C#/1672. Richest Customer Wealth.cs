public class Solution 
{
    public int MaximumWealth(int[][] accounts) 
    {
        int sum, maxWealth = 0;
        
        for(int i=0; i < accounts.Length; i++)
        {
            sum = accounts[i].Sum();
            
            if (maxWealth < sum)
                maxWealth = sum;
        }
        
        return maxWealth;
    }
}
