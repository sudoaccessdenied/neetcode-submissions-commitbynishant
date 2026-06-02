public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s2.Length<s1.Length) return false;
        var s1Hash = new int[26];
        var windowHash = new int[26];
        var windowSize = s1.Length;
        for (int i = 0; i < s1.Length; i++) {
            var index1 = s1[i] - 'a';
            var index2 = s2[i] - 'a';
            s1Hash[index1]++;
            windowHash[index2]++;
        }
        var match = 0;
        for (int i = 0; i < 26; i++) {
            if (s1Hash[i] == windowHash[i]) {
                match++;
            }
        }

        if (match == 26)
            return true;
        for (int i = windowSize; i < s2.Length; i++) {
            // add new char
            var ch = s2[i];
            var index = ch - 'a';

            if (s1Hash[index] != windowHash[index] && s1Hash[index] == windowHash[index]+1) {
                match++;
            } 
            if (s1Hash[index] == windowHash[index] && s1Hash[index] != windowHash[index]+1) {
                match--;
            } 
            windowHash[index]++;
            // remove char
            var ch2 = s2[i - windowSize];
            var index2 = ch2 - 'a';
            if (s1Hash[index2] != windowHash[index2] && s1Hash[index2] == windowHash[index2]-1) {
                match++;
            } 
            if (s1Hash[index2] == windowHash[index2] && s1Hash[index2] != windowHash[index2]-1) {
                match--;
            } 
            windowHash[index2]--;
            // Console.WriteLine("ch "+ ch +" ch2"+ch2 +" match "+match);

            if (match == 26)
                return true;
        }
        return match ==26;
    }
}
// create 26 hash for s1 and 26 hash for matching
// First create the freq for s1 and and windows s2 of leng s1.Len
//  Create match count first
// now if match count == 26  then return true.
// for i = s1.Length+1 to s2.Length
// window hash update
// winodw  i = s1.Length;
// s1Hash[char[i]] == windowHash[char[i]] match++ else match --
// s1Hash[char[i-len]] == windowHash[char[i-llen]] match++ else match--
// return match == 26
// ab , windowSize = 2
// 0,1,2