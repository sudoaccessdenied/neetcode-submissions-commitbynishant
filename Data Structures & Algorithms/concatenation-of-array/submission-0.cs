public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var n = nums.Length*2;
        var result = new int[n];
        for(int i = 0; i< n ; i++){
            var index = i%(nums.Length);
            result[i] = nums[index];
        }
        return result;
    }
}