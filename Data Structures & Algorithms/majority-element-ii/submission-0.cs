public class Solution {
    public List<int> MajorityElement(int[] nums) {
        //num,count
        var hashMap = new Dictionary<int, int>();
        foreach(var num in nums){
            if(hashMap.ContainsKey(num)){
                hashMap[num] = hashMap[num]+1;
            }else{
                // decrease count
                if(hashMap.Count < 3){
                    hashMap[num] = 1;
                }else{
                    foreach(var dic in hashMap){
                        hashMap[dic.Key] = hashMap[dic.Key]-1;
                        if(hashMap[dic.Key] == 0){
                            hashMap.Remove(dic.Key);
                        }
                    }
                }
                
                // decrease count
            }
           
        }
        var list = new List<int>();
        int k = nums.Length/3;
        foreach(var dic in hashMap){
            var count = 0;
            foreach(var num in nums){
                    if(dic.Key == num) count++;
            }
            if(count > k) list.Add(dic.Key);
        }
        return list;

        
    }
}