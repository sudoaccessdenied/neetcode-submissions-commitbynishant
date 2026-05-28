public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var set = new HashSet<int>();
        for(int i = 0;i<= Math.Min(k,nums.Length-1);i++){
            if(set.Contains(nums[i])){
                return true;
            }
            set.Add(nums[i]);
        }

        for(int i =k+1;i< nums.Length;i++){
            set.Remove(nums[i-k-1]);
            if(set.Contains(nums[i])){
                return true;
            }
            set.Add(nums[i]);
            
        }
        return false;
    }
}

// 0,1,2,3,4,5,6,7
// 0,1,2 , k=1
// 2,1