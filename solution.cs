public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        for(int i = 1; i < s.Length; i++){
            if(s.Length % i == 0){
                bool broke = false;
                for(int j = i; j < s.Length; j += i){
                    if(!s.Substring(0, i).Equals(s.Substring(j, i))){
                        broke = true;
                        break;
                    }
                }

                if(!broke){
                    return true;
                }
            }
        }

        return false;
    }
}
