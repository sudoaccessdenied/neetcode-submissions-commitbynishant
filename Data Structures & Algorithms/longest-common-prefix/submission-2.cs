public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 1) return strs[0];
        var minLengthString = GetMinLengthString(strs);
        Console.WriteLine(minLengthString);
        
        for(int i = 0;i < minLengthString.Length;i++)
        {
            foreach(var first in strs)
            {
                Console.WriteLine(first);
                if(minLengthString[i]!=first[i])
                {
                    Console.WriteLine(i);  
                    return minLengthString.Substring(0,i);
                }
            }
        }
        
        return minLengthString;
    }
    private string GetMinLengthString(string[] strs){
        var length = 999;
        var minLengthString = strs[0];
        foreach(var str in strs){
            if(length > str.Length){
                length = str.Length;
                minLengthString = str;
            }
           
        }
        return minLengthString;
    }
}