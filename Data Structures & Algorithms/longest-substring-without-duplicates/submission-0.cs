public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length ==0 ) return 0;
        var map = new Dictionary<char,int>();
        var left = 0;
        var right = 1;
        var max =1 ;
        map[s[left]] =0;
        while(right < s.Length){
            if(map.ContainsKey(s[right])){
                var previous = map[s[right]];
                while(left <= previous){
                    map.Remove(s[left]);
                    left++;
                }
            }
            map[s[right]]=right;
            var currLength = right-left+1;
            max = Math.Max(max,currLength);
            right++;

        }
        return max;
    }
}
