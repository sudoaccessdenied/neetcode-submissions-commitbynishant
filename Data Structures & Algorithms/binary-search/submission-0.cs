public class Solution {
    public int Search(int[] nums, int target) {
        var left = 0;
        var right = nums.Length-1;
        
        while(left <= right){
            int mid = (left+right)/2;
            var midVal = nums[mid];
            if(target == midVal) return mid;
            if(target > midVal){
                left = mid+1;
            }else {
                right = mid-1;
            }
        }

        return -1;
        // 1,2,3,4,5,6,7,8;
        // 3,9 , 3+9/2 = 6
    }
}
