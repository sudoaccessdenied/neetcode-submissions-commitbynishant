public class Solution {
    public void Rotate(int[] nums, int k) {
        var shift = k%nums.Length;
        for(int i=0;i<shift;i++){
            var last = nums[nums.Length-1];
            var prev = nums[0];
            for(int j =1;j< nums.Length;j++){
                var curr = nums[j];
                nums[j] = prev;
                prev = curr;
            }
            nums[0] = last;
        }
    }
}

//: nums = [1,2,3,4,5,6,7,8,9,10,11], k = 11
// 4 
// t = k%n;
// for (int i =0;i< t;i++){
//   swap(i,n -t +i)
// }

// 1 2,3,4
// 4,1,2,3
// 3,4,1,2
// 2,3,4,1
// 1,2,3,4