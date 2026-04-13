public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length == 1) return 0;
        int maxProfit = 0;
        for(int i =0;i< prices.Length-1;i++){
            for(int j = i+1;j< prices.Length;j++){
                var profit = prices[j] -prices[i];
                maxProfit = Math.Max(maxProfit,profit);
            }
        }
        return maxProfit;
    }
}
