public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var sb = new StringBuilder();
        var n = word1.Length< word2.Length? word1.Length:word2.Length;
        var first = true;
        for(int i =0;i<2*n;i++){
            if(first){
                sb.Append(word1[i/2]);
                first=false;
            }else{
                sb.Append(word2[i/2]);
                first = true;
            }

        }
        if(word1.Length < word2.Length){

            sb.Append(word2.Substring(word1.Length));
            return sb.ToString();
        }else if(word1.Length > word2.Length){
             sb.Append(word1.Substring(word2.Length));
            return sb.ToString();
        }else{
            return sb.ToString();
        }
        
    }
}