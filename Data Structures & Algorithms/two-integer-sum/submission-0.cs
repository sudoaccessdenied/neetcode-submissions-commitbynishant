public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indexMap = new Dictionary<int,int>();
        for(int i = 0;i<nums.Length;i++){
            indexMap[nums[i]] =i;
        }
        for(int i = 0;i<nums.Length;i++){
            var numToFind = target -nums[i];
            if(indexMap.ContainsKey(numToFind)
                && indexMap[numToFind]!=i){

                if(indexMap[numToFind] < i){
                    return new int[]{indexMap[numToFind],i };
                }else
                {
                    return new int[]{i ,indexMap[numToFind] };
                }
                return new int[]{indexMap[numToFind],i };
            }
        }
        return new int[]{};
    }
}
