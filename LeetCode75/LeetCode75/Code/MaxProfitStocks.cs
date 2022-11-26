namespace LeetCode75
{
    public class MaxProfitStocks
    {
        public int MaxProfit(int[] prices)
        {
            int minI = 10001;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minI)
                    minI = prices[i];
                else if (prices[i] - minI > maxProfit)
                    maxProfit = prices[i] - minI;
            }
            return maxProfit;
        }
    }
}
