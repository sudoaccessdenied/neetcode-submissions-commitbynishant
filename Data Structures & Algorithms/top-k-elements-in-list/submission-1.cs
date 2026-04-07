public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var bucket = new List<int>[nums.Length+1];

        var map = new Dictionary<int,int>();
        foreach(var val in nums){
            if(map.ContainsKey(val)){
                map[val]++;
            }else{
                map[val] =1;
            }
            
        }
        Console.WriteLine(string.Join(", ", map.Values));
        foreach(var dic in map){
           var key = dic.Key;
           var val = dic.Value;
            if(bucket[val]== null){
                bucket[val] = new List<int>() ;
            }
            bucket[val].Add(key);
        }
        // Console.WriteLine(string.Join(", ", bucket));
        var sol = new int[k];
        for(var i = nums.Length; i>=0 && k>0;i--){
            if(bucket[i]!=null){
                var items = bucket[i];
                foreach(var item in items){
                    sol[k-1] = item;
                    k--;
                    if(k==0) break;
                }
            }
            
        }
        return sol;

    }
}
