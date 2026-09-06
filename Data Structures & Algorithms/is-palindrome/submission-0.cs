public class Solution {
    public bool IsPalindrome(string s) {
        int l=0;
        int r=s.Length-1;

        while(l<=r){
            if(!char.IsLetterOrDigit(s[l])) {l++; continue;}
            if(!char.IsLetterOrDigit(s[r])) {r--; continue;}
            if(char.ToLower(s[l])!=char.ToLower(s[r])) return false;
            l++;
            r--;
        }
        return true;
    }
}
