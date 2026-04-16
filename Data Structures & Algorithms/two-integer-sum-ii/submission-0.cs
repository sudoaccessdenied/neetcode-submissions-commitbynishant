public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var left = 0;
        var right = nums.Length-1;
        while(left < right){
            var sum = nums[left]+nums[right];
            if(sum == target){
                return new int[]{ left+1,right+1};
            }else if(sum > target){
                right--;
            }else {
                left ++;
            }
        }
        return new int[]{};
    }
}
