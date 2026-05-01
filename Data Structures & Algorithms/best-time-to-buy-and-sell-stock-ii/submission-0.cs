public class Solution {
    public int MaxProfit(int[] prices) {
        var n = prices.Length;
        var dp = new int[n,n];
        for(int i = 0;i< n;i++){
            for(int j = i;j<n;j++){
                var max = 0;
                for(int k = 0;k<=i-1;k++){
                    var sol = dp[k,i-1];
                    max = Math.Max(sol,max);
                }
                dp[i,j] = max + prices[j]-prices[i];

            }
        }
        var result = 0;
        for(int k = 0;k<=n-1;k++){
            var sol = dp[k,n-1];
            result = Math.Max(sol,result);
        }

        return result;
        
    }

    // public int Max(int i , int j)
}