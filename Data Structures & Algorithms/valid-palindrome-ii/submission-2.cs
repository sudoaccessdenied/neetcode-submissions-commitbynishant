public class Solution {
    public bool ValidPalindrome(string s) {
        var left = 0;
        var right = s.Length-1;
        while(left< right){
            if(s[left]==s[right]){
                left++;
                right--;
            }else{

                return ValidPalindrome(s,left+1,right) || ValidPalindrome(s,left,right-1);
            }

        }
        return true;
    }

    private bool ValidPalindrome(string s , int left, int right) {
        while(left< right){
            if(s[left]!=s[right]){
               return false;
            }
            left++;
            right--;

        }
        return true;
    }
}