public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var set = new HashSet<int>(nums);
        var max =0;
        var min = int.MaxValue-1;

        for(int i =0;i< nums.Length;i++){
            max = Math.Max(nums[i],max);
            min = Math.Min(nums[i],min);
        }
        
        for(int i = 1;i<=max;i++){
            if(!set.Contains(i) && i >0){
                return i;
            }
        }
        // if(min > 1) return min-1;
        return max+1;
    }
}