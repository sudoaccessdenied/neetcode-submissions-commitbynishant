public class Solution {
    public int MaxArea(int[] heights) {
        var left = 0;
        var right = heights.Length-1;
        var maxArea = 0;
        while(left < right){
            var area = (right -left) * Math.Min(heights[left],heights[right]);
            maxArea = Math.Max(area,maxArea);
            Console.WriteLine("left "+ left+" right "+right+" area " + area);
           // case 
           // if left > left +1
           // if right-1 > right
           // if left +1 > right
           // if right-1 > left
           
            if(heights[left] > heights[right]){
                right--;
            } else if(heights[left]< heights[right]){
                left++;
            }else{
                left++;
                right--;
            }
        }
        return maxArea;
        
    }
}
