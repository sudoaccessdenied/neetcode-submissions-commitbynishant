public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var result = new List<List<string>>();
        var stack = new Stack<string>(strs);
        var temp = new Stack<string>();
        while(!IsEmpty(stack)){
            var pop = stack.Pop();
            var anagrams = new List<string>();
            anagrams.Add(pop);
            while(!IsEmpty(stack)){
                   var pop2 = stack.Pop();
                if(IsAnagram(pop,pop2)){
                      anagrams.Add(pop2);
                }else {
                    temp.Push(pop2);
                } 
            }
            result.Add(anagrams);
            stack = temp;
            temp = new Stack<string>();

        }
        return result;

        
    }

    public bool IsAnagram(string s1 , string s2){

        var set = new int[26];
        foreach(var ch in s1.ToCharArray()){
            set[GetIndex(ch)]++;
        }
        foreach(var ch in s2.ToCharArray()){
            set[GetIndex(ch)]--;
        }

        foreach(var i in set){
            if(i < 0 || i > 0) return false;
        }
        return true;
    }

    private int GetIndex(char c){
        return c -'a';
    }

    public static bool IsEmpty<T>(Stack<T> stack){
        return stack.Count <= 0;
    }
}
