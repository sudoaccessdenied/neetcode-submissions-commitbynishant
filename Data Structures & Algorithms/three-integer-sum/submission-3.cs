public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
       var list = new List<List<int>>();
       Array.Sort(nums);
        Console.WriteLine("nums "+string.Join(",",nums));
        for(int i =0;i<nums.Length;i++){

            Console.WriteLine("i "+i);
            if(nums[i]>0) return list;
            if(i>0 && nums[i] == nums[i-1] ) continue;
             Console.WriteLine("executing i "+i);
            var result = Pair(nums, i,-nums[i]);

            foreach(var r in result){
                Console.WriteLine("i "+i+"res "+string.Join(",",r));
                list.Add(r);
            }
        }
        return list;

    }
    public List<List<int>> Pair(int[] nums,int i, int target){
        var left =i+1;
        var right = nums.Length -1;
        var results = new List<List<int>>();
        while(left < right){
            var sum = nums[left]+nums[right];
            if(left > i+1 && nums[left] == nums[left-1]){
                left++;
            } 
            else if(sum==target && left != right){
                var sol = new List<int>(){ -target,nums[left],nums[right]};
                Console.WriteLine("Sol "+ string.Join(",",sol));
                 results.Add(sol);
                 left++;
            }else if(sum>target){
                right--;
            }else{
                left++;
            }
        }
        return results;
    }
}
