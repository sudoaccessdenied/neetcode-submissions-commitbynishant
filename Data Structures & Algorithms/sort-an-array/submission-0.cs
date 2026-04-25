public class Solution {
    public int[] SortArray(int[] nums) {
        
        for(int i =1;i< nums.Length;i++){
                // find correct position
                // swap
        
                for(int j = i-1;j>=0;j--){
                     var curr = nums[j+1];
                    if(nums[j]>curr){
                        // swap
                        var temp = nums[j];
                        nums[j] = nums[j+1];
                        nums[j+1] = temp;
                        
                    }else{
                        break;
                    }
                }
        }
        return nums;
    }
}