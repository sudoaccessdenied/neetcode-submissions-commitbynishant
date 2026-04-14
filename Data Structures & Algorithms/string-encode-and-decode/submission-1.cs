public class Solution {
    public const string Delimeter = "=>";
    public string Encode(IList<string> strs) {
        if(strs.Count ==0) return null;

        return string.Join(Delimeter,strs);
        // var sb = new StringBuilder();
        // foreach(var str in strs){
        //     sb.Append(Delimeter);
        //     sb.Append(str);
        // }
        // return sb.ToString();
    }

    public List<string> Decode(string s) {

        if(s == null) return new List<string>();
        var strs = s.Split(Delimeter);
        return new List<string>(strs);
   }
}
