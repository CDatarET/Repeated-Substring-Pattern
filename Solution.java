class Solution {
    public boolean repeatedSubstringPattern(String s) {
        for(int i = 1; i < s.length(); i++){
            if(s.length() % i == 0){
                boolean broke = false;
                for(int j = i; j < s.length(); j += i){
                    if(!s.substring(0, i).equals(s.substring(j, j + i))){
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
