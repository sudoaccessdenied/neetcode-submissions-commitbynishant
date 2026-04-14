public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var forward = new int[nums.Length];
        var backward = new int[nums.Length];
        var result = new int[nums.Length];
        forward[0] = nums[0];
        backward[nums.Length-1] = nums[nums.Length-1];
        for(int left = 1, right = nums.Length-2;left< nums.Length && right >=0;left++,right-- ){
            forward[left] = forward[left-1]*nums[left];
            backward[right]= backward[right+1]*nums[right];
        }

        for(int i = 0;i< nums.Length;i++){
            if(i==0){

                result[i]=backward[i+1];

            }else if(i == nums.Length-1){

                result[i]= forward[i-1];

            }else{
                result[i]=forward[i-1]*backward[i+1];
            }

        }
        return result;
    }
}
