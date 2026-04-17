public class Solution {
    public int Trap(int[] height) {
        var prefixMax = new int[height.Length];
        var suffixMax = new int[height.Length];
        prefixMax[0] = height[0];
        for(int i =1;i< height.Length;i++){
            prefixMax[i] = Math.Max(height[i],prefixMax[i-1]);
        }
        suffixMax[height.Length-1] = height[height.Length-1];
        for(int i = height.Length-2;i>= 0;i--){
            suffixMax[i] = Math.Max(height[i],suffixMax[i+1]);
        }
        var sum = 0;
        for(int i =0;i< height.Length;i++){
            var trappedWater = Math.Min(prefixMax[i],suffixMax[i])-height[i];
            sum+=trappedWater;
        }
        return sum;
    }
}
