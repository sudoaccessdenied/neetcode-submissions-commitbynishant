public class Solution {
    public bool IsAnagram(string s, string t) {
        var map = new int[26];
        foreach(var sChar in  s.ToCharArray()){
            var index = sChar - 'a';
            map[index]++; 
        }

        foreach(var sChar in  t.ToCharArray()){
            var index = sChar - 'a';
            map[index]--; 
        }
        for(int  i = 0;i< 26;i++){
            if(map[i] >0 || map[i] < 0){
                return false;
            }
        }
        return true;

    }
}
