public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var index = 0;
        var curr = nums[0];
        for(int i =0;i< nums.Length;i++){
            
           if(curr == nums[i]){
                continue;
           }else{
            nums[index] = curr;
            index++;
            curr = nums[i];
           }

        }
        nums[index] = curr;
        index++;
            
        return index;
    }
}

// 2,2,2,30,30,30,30,40,40,40
// index = 0;
// for i ==0 
// ni = 1 , curr = 2
// ni = 2,
// ni = 3 
// nums=[1,1,2,3,4]
// index =0;
// curr = 1;
// i =0,1,2
// index = 1
//curr = 2
// i = 3, 2!=3
// [1,2,2,3,4]
// if not matched at last
// curr = 3 , index = 2
// i = 4, 3 != 4
// [1,2,3,3,4]
// curr = 4, index = 3
// if matched at last
// [1,2,3,3,3]
// curr = 3 , index = 2
// i = 4, 3 == 3
// [1,2,3,3,3]



