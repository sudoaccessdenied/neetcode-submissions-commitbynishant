public class Solution {
    public void SortColors(int[] nums) {
        var l =0;
        var r = nums.Length-1;
        var i = 0;
        while(i <= r){
            var curr = nums[i];
             if(curr == 0) {
                swap(nums, l,i);
                    l++;
                    i++;
            }
            else if(curr ==1) {
                i++;
            }
            else if(curr == 2){
                swap(nums,i,r);
                    r--;
            }
        }

    }
    private void swap(int[] nums,int i, int j){
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}