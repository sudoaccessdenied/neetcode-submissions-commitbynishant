public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length ==0) return 0;
        var map = new HashSet<int>(nums);
        var max = 1;
        for(int i = 0;i< nums.Length;i++){
            var num = nums[i];
            var count = 1;
            if(!map.Contains(num-1)){
                while(map.Contains(num+1)){
                    count++;
                    num++;
                }
            }
            max = Math.Max(max,count);

        }
    return max;
    }
}

