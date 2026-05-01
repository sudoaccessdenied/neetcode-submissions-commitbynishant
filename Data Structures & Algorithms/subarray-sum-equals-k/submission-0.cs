public class Solution {
    public int SubarraySum(int[] nums, int k) {
        if(nums.Length < 1) return 0;
        var prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];
        for(int i =1;i< nums.Length;i++){
            prefixSum[i] = nums[i]+ prefixSum[i-1];
        }

        var count = 0;

        for(int i =0;i< nums.Length;i++){
            for(int j =i;j< nums.Length;j++){
                var minusComponent = i>0? prefixSum[i-1]: 0;
                var totalSum = prefixSum[j] - minusComponent;
                if(totalSum == k) count++;
            }
        }
        return count;
        
    }
}